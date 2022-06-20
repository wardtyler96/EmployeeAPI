using System;
using Npgsql;

namespace EmployeeAPI
{
    public class AddEmpModel
    {
        public int empId { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        NpgsqlConnection constring = new NpgsqlConnection("Server=localhost;Port=5432;Database=employee;User Id=postgres;Password=Bark9631!;");

        public string AddEmployee(AddEmpModel newEmp)
        {
            NpgsqlCommand addEmployee = new NpgsqlCommand(@"insert into Employee values(@empId,@firstName,@lastName,@email)",constring);
            addEmployee.Parameters.AddWithValue(@"empId", newEmp.empId);
            addEmployee.Parameters.AddWithValue(@"firstName", newEmp.firstName);
            addEmployee.Parameters.AddWithValue(@"lastName", newEmp.lastName);
            addEmployee.Parameters.AddWithValue(@"email", newEmp.email);
            try
            {
                constring.Open();
                addEmployee.ExecuteNonQuery();
            }
            catch (System.Exception es)
            {
                throw new Exception(es.Message);
            }
            finally
            {
                constring.Close();
            }

            return "Employee Added";
        }
        public string UpdateEmployee(AddEmpModel updateEmp)
        {
            NpgsqlCommand updateEmployee = new NpgsqlCommand("update Employee set firstName=@firstName, lastName=@lastName, email=@email where empId=@empId", constring);
            updateEmployee.Parameters.AddWithValue(@"firstName", updateEmp.firstName);
            updateEmployee.Parameters.AddWithValue(@"lastName", updateEmp.lastName);    
            updateEmployee.Parameters.AddWithValue(@"email", updateEmp.email);
            
            try
            {
                constring.Open();
                updateEmployee.ExecuteNonQuery();
            }
            catch(System.Exception es)
            {
                throw new Exception (es.Message);
            }
            finally
            {
                constring.Close();
            }

            return "Updated Employee";
        }

    }

}
