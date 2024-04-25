namespace LoginPractica.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        //Task<IEnumerable<T>> Get();
        //Task<T> Find(int id);
        Task<T> Find(string correo, string password);
        //Task<T> Add(T model);
        //Task<T> Update(T model);
        //Task<int> Remove(T model);
    }
}
