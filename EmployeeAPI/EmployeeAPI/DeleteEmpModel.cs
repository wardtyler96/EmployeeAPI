
using Npgsql;
namespace EmployeeAPI

{
    public class DeleteEmpModel
    {
        NpgsqlConnection constring = new NpgsqlConnection("Server=localhost;Port=5432;Database=employee;User Id=postgres;Password=Bark9631!;");
        public string DeleteEmployee(int empId)
        {
            NpgsqlCommand deleteEmployee = new NpgsqlCommand("delete from Employee where empId=@empId", constring);
            deleteEmployee.Parameters.AddWithValue("@empId", empId);
            try
            {
                constring.Open();
                deleteEmployee.ExecuteNonQuery();
            }
            catch (System.Exception es)
            {

                System.Console.WriteLine(es.Message);
            }
            finally
            {
                constring.Close();
            }
            return "Employee Deleted";
        }
    }
}
