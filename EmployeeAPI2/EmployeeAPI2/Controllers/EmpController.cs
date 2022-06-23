using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

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
        #region Add Employee
        //Adds new Employees
        [Route("AddEmployee")]
        [HttpPost] 
        public async Task<ActionResult<List<NewEmp>>> AddEmp(NewEmp emp)
        {
            _context.Employee.Add(emp);
            await _context.SaveChangesAsync();
            return Ok(await _context.Employee.ToListAsync());
        }
        #endregion

        #region Delete Employees
        //Deletes Employees
        [Route("DeleteEmployee")]   
        [HttpDelete]

        public async Task<ActionResult<List<NewEmp>>> DeleteEmp(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            
            if(employee == null)
            {
                return BadRequest("Employee Does Not Exist In Database");
            }
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return Ok(await _context.Employee.ToListAsync());
        }
        #endregion
    }
}
