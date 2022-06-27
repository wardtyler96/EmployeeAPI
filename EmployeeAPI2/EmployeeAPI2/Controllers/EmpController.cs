
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;


namespace EmployeeAPI2.Controllers
{
    public class EmpController : Controller
    {

        private readonly BLL.EmployeeBLL _BLL;
        public EmpController()
        {
            _BLL = new BLL.EmployeeBLL();
        }

        public IActionResult Index()
        {
            return View();
        }
        #region Add Employee
        //Adds new Employees
        [Route("AddEmployee")]
        [HttpPost] 
        public Task<ActionResult<List<NewEmp>>> AddEmp()
        {
            return _BLL.AddEmp();
        }
        #endregion

        #region Delete Employees
        //Deletes Employees
        [Route("DeleteEmployee")]   
        [HttpDelete]

        public Task<ActionResult<List<NewEmp>>> DeleteEmp(int id)
        {
            return _BLL.DeleteEmp();
        }
        #endregion
    }
}
