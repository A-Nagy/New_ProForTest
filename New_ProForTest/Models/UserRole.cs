using System.ComponentModel.DataAnnotations;

namespace New_ProForTest
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
