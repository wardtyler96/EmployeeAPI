using System;
using Npgsql;
namespace EmployeeAPI
{

    public class GetEmpModel
    {
        public int empId { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        NpgsqlConnection constring = new NpgsqlConnection("Server=localhost;Port=5432;Database=employee;User Id=postgres;Password=Bark9631!;");

        public GetEmpModel GetEmployee(int id)
        {
            GetEmpModel emp = null;
            NpgsqlCommand getEmployee = new NpgsqlCommand("select * from Employee where empId=@empId", constring);
            getEmployee.Parameters.AddWithValue("@empId",id);
            NpgsqlDataReader read;

            try
            {
                constring.Open();
                read = getEmployee.ExecuteReader();

                if (read.Read())
                {
                    emp = new GetEmpModel();
                    emp.empId = id;
                    emp.firstName = Convert.ToString(read[1]);
                    emp.lastName = Convert.ToString(read[2]);
                    emp.email = Convert.ToString(read[3]);

                    return emp;
                }
            }
            catch (System.Exception es)
            {
                throw new Exception(es.Message);
            }
            finally
            {
                constring.Close();
            }
           
            return emp;
        }

       
    }
}

