using New_ProForTest.Data;
using New_ProForTest.Repository.Base;

namespace New_ProForTest.Repository
{
    public class UintOfWork : IUintOfWork
    {
        private readonly AppDbContext _context;
        public UintOfWork(AppDbContext context)
        {
            _context    = context;
            Categories  = new MainRepository<Categoty>  (context);
            Products    = new MainRepository<Product>   (context);
            Employees   = new RpoEmployee (context);
            UserRoles   = new MainRepository<UserRole>  (context);
            Premissions = new MainRepository<Premission>(context);
            Suppliers   = new MainRepository<Supplier>  (context);

        }

        public IRepository<Categoty>   Categories  { get; }
        public IRepository<Product>    Products    { get; }
        public IRpoEmployee            Employees  { get; }
        public IRepository<UserRole>   UserRoles   { get; }
        public IRepository<Premission> Premissions { get; }
        public IRepository<Supplier>   Suppliers   { get; }
      
        public void Save()
        {
            _context.SaveChanges();
        }

       
    }
}
