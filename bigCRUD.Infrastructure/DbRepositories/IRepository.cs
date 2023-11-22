using bigCRUD.Application.Models;

namespace bigCRUD.Infrastructure.DbRepositories
{
    public interface IRepository<T>
    {
        Task<Response<T>> Create(T entity);

        Task<Response<bool>> Update(T entity, CancellationToken cancellationToken);

        Task<Response<bool>> Delete(int id, CancellationToken cancellationToken);
        Task<Response<T>> GetById(int objectId, CancellationToken cancellationToken);
        Task<Response<List<T>>> GetAll();


    }
}
