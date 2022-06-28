
using Microsoft.AspNetCore.Mvc;
using DAL.Entities;

namespace EmployeeAPI2.Controllers
{
    public class EmployeeSearchController : Controller
    {
        private readonly BLL.EmployeeBLL _BLL;
        public EmployeeSearchController()
        {
            _BLL = new BLL.EmployeeBLL();
        }

        public IActionResult Index()
        {
            return View();
        }
        #region Employee List
        //Gets the entire employee list
        [Route("EmployeeList")]
        [HttpGet]
        public  List<NewEmp> GetEmployeeList()
        {
            return _BLL.GetEmployeeList();
        }
        #endregion

        #region Get a Single Employee
        //Will pull a single employee
        [Route("SingleEmployee")]
        [HttpGet]
        public NewEmp GetEmployeeById(int id)
        {
            return _BLL.GetEmployeeById(id);
        }
        #endregion
    }
}
