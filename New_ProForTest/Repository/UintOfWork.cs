using New_ProForTest.Data;
using New_ProForTest.Repository.Base;

namespace New_ProForTest.Repository
{
    public class UintOfWork : IUintOfWork
    {
        private readonly AppDbContext _context;
        public UintOfWork(AppDbContext context)
        {
            _context = context;
        }
        void Commit()
        {
            _context.SaveChanges();
        }

       
    }
}
