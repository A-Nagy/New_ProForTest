using Microsoft.EntityFrameworkCore;
using New_ProForTest.Data;
using New_ProForTest.Repository.Base;

namespace New_ProForTest.Repository
{
    public class MainRepository<T> :IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        public MainRepository(AppDbContext context)
        {
            _context = context;
        }
  
        public T Find(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public IEnumerable<T> FindAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
          
        }
    }
}
