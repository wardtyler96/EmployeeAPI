using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class NewEmp
    {
        [Key]
        public int empId { get; set; }

        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;

    }

}
