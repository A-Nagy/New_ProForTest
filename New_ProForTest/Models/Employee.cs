using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace New_ProForTest
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }=null;
        public string Phone { get; set; }
        public decimal Salary { get; set; } = 0;
      
        public bool IsActive { get; set; }  = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; }
        public int? UserDelete { get; set; }
        public int UserRoleId { get; set; }
        public UserRole? UserRole { get; set; }
        public ICollection<Premission>? Premissions { get; set; }
    }
}
