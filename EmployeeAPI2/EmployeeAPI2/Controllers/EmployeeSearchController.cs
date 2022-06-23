﻿using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI2.Controllers
{
    public class EmployeeSearchController : Controller
    {
        private readonly DataContext _context;
        public EmployeeSearchController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        #region Employee List
        //Gets the entire employee list
        [Route("EmployeeList")]
        [HttpGet]
        public async Task<ActionResult<List<NewEmp>>> Get()
        {
            return Ok(await _context.Employee.ToListAsync());
        }
        #endregion

        #region Get a Single Employee
        //Will pull a single employee
        [Route("SingleEmployee")]
        [HttpGet]
        public async Task<ActionResult<List<NewEmp>>> Get(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return BadRequest("Employee Not Found");
            }
            return Ok(employee);
        }
        #endregion
    }
}
