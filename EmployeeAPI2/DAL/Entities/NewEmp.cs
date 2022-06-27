using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class NewEmp
    {
        [Key]
        public int empId { get; set; }

        public string firstName { get; set; } = string.Empty;

        internal void Add()
        {
            throw new NotImplementedException();
        }

        public string lastName { get; set; } = string.Empty;

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

}
