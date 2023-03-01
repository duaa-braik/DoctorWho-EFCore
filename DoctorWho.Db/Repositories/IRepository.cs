namespace DoctorWho.Db.Repositories
{
    public interface IRepository<T> where T : class
    {
        public T GetById(int id);
        public int Add(T t);
        public int Update(T t);
        public int Delete(int Id);
    }
}
