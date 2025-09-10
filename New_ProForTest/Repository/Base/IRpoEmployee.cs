namespace New_ProForTest.Repository.Base
{
    public interface IRpoEmployee : IRepository<Employee>
    {
        Employee Login(string username, string password);
    }
}
