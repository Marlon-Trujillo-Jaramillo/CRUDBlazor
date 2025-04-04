namespace CRUD.Frontend.Services
{
    public interface IRepository
    {
        Task<T> GetAsync<T>(string url);
        Task<Object> PostAsync<T>(string url, T entity);
        Task<object> PutAsync<T>(string url, int id, T entity);
        Task<T> GetByIdAsync<T>(string url, int id);
        Task<Object> DeleteAsync(String url);

    }
}
