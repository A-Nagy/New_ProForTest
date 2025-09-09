namespace New_ProForTest.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> FindAll();
        T Find(int Id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
