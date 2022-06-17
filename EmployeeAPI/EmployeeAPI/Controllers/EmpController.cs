
using System;
using Npgsql;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;




namespace EmployeeAPI.Controllers
{
    public class EmpController : Controller
    {

        NpgsqlConnection constring = new NpgsqlConnection("Server=localhost;Port=5432;Database=employee;User Id=postgres;Password=Bark9631!;");
        AddEmpModel newEmpObj = new AddEmpModel();
        GetEmpModel getEmpObj = new GetEmpModel();
        DeleteEmpModel delEmpObj = new DeleteEmpModel();


        public IActionResult Index()
        {
            return View();
        }

        [Route("GetEmployee")]
        [HttpGet]

        public IActionResult GetEmployee(int id)
        {
            return Ok(getEmpObj.GetEmployee(id));
        }

        [Route("addEmployee")]
        [HttpGet]

        public IActionResult AddEmployee(AddEmpModel addEmp)
        {
            try
            {
                return Created("", newEmpObj.AddEmployee(addEmp));
            }
            catch (System.Exception es)
            {
                return BadRequest(es.Message);
            }
        }


        //[Route("updateEmployee")]
        //[HttpPut]

        //public IActionResult UpdateEmployee(AddEmpModel updEmp)
        //{
        //    try
        //    {
        //        return Accepted("", newEmpObj.UpdateEmployee(updEmp));
        //    }
        //    catch (System.Exception es)
        //    {
        //        return BadRequest(es.Message);
        //    }
        //}

        [Route("DeleteEmployee")]
        [HttpDelete]

        public IActionResult DeleteEmployee(int id)
        {
            return Ok(delEmpObj.DeleteEmployee(id));
        }
    }
}
