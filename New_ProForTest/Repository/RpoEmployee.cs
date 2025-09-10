using New_ProForTest.Data;
using New_ProForTest.Repository.Base;

namespace New_ProForTest.Repository
{
    public class RpoEmployee : MainRepository<Employee>, IRpoEmployee
    {
        private readonly AppDbContext _dbContext;
        public RpoEmployee(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Employee Login(string username, string password)
        {
            var emp = _dbContext.Employees.FirstOrDefault(e=>e.UserName==username&&e.Password==password);
            return emp;
        }



    }
}
