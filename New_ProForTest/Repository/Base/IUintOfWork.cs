namespace New_ProForTest.Repository.Base
{
    public interface IUintOfWork
    {
    
        IRepository<Categoty> Categories { get; }
        IRepository<Product> Products { get; }
        IRpoEmployee Employees { get; }
        IRepository<UserRole> UserRoles { get; }
        IRepository<Premission> Premissions { get; }
        IRepository<Supplier> Suppliers { get; }
 
        void Save();
    }
}
