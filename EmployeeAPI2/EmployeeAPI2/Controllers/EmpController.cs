using Microsoft.AspNetCore.Mvc;


namespace EmployeeAPI2.Controllers
{
    public class EmpController : Controller
    {

        private readonly DataContext _context;
        public EmpController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("AddEmployee")]
        [HttpPost] 
        public async Task<ActionResult<List<NewEmp>>> AddEmp(NewEmp emp)
        {
            _context.Employee.Add(emp);
            await _context.SaveChangesAsync();
            return Ok(await _context.Employee.ToListAsync());
        }

        [Route("Delete")]   
        [HttpDelete]

        public async Task<ActionResult> DeleteEmp(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return Ok(await _context.Employee.ToListAsync());
        }
        
        
    }
}
