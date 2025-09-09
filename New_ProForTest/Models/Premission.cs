using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace New_ProForTest
{
    public class Premission
    {
        [Key]
        public int Id { get; set; }

        public bool ISCategory { get; set; } = false;
        public bool ISProduct { get; set; } = false;
        public bool ISEmployee { get; set; } = false;
        public bool ISSupplier { get; set; } = false;
        public bool ISUserRole { get; set; } = false;

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
   
    }
}
