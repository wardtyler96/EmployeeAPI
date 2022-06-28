

using DAL.Entities;

namespace EmployeeAPI2.BLL
{
    public class EmployeeBLL
    { 
        public List<NewEmp> GetEmployeeList()
        {
            var data = new DataContext();
            return data.Employee.ToList();
        }
        public NewEmp GetEmployeeById(int id)
        {
            try
            {
                var data = new DataContext();
                NewEmp id2 = data.Employee.Find(id);
                return id2;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {

            }
        }

        public string AddEmp(NewEmp emp)
        {
            try
            {
                var data = new DataContext();
                data.Employee.Add(emp);
                data.SaveChanges();
                return "Employee Was Added";
            }
            catch (DbUpdateException es)
            {
                throw new DbUpdateException(es.Message);
            }
            finally {
                
            }
        }

        public string DeleteEmp(int id)
        {
            try
            {
                var data = new DataContext();
                var id3 = data.Employee.Find(id);

                if (id3 != null)
                {
                    data.Employee.Remove(id3);
                    data.SaveChanges();
                    return "Employee Was Deleted";
                }
                else
                {
                    return "Employee Was Null";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }
    }
}