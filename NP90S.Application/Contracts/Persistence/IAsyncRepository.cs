namespace NP90S.Application.Contracts.Persistence
{
  public interface IAsyncRepository<T> where T : class
  {
    Task<T?> GetById(long id);
    Task<IReadOnlyList<T>> ListAll();
    Task<T> Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
    Task<IReadOnlyList<T>> GetPagedReponse(int page, int size);
  }
}
