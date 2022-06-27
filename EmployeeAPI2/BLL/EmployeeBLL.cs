using DAL.Entities;
using System.Collections.Generic;
namespace BLL
{
    public class EmployeeBLL
    {
        private readonly DAL.EmployeeDAL _DAL;


        public EmployeeBLL()
        {
            _DAL = new DAL.EmployeeDAL();
        }
     
        public List<NewEmp> GetEmployeeList()
        {
            return _DAL.GetEmployeeList();
        }

        public List<NewEmp> GetEmployeeById()
        {
            return _DAL.GetEmployeeById();
        }
        public List<NewEmp> AddEmp()
        {
            return _DAL.AddEmp();
        }
    }
}