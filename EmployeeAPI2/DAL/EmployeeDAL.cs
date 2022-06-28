
using DAL.Entities;
using System.Linq;


namespace DAL
{
    public class EmployeeDAL
    {
        public List<NewEmp> GetEmployeeList()
        {
            var db = new DataContext();
            return db.Employee.ToList();
        }
        public NewEmp GetEmployeeById(int id)
        {
            
            var db = new DataContext();

           var id2 = db.Find(x => x.empId == id);

            return id2;
        }

        public List<NewEmp> GetEmployeeById()
        {
            throw new NotImplementedException();
        }

        public List<NewEmp> AddEmp()
        {
            throw new NotImplementedException();
        }

        public List<NewEmp> AddEmp(NewEmp emp)
        {
            var data = new DataContext();
              data.Employee.Add(emp);
            return data.SaveChanges();
            
        }


        public List<NewEmp> DeleteEmp(int id, DataContext db)
        { 
            
            db.Employee.Remove(x => x.empId == id);
            return db.SaveChanges(); 
             
            
        }
    }
}