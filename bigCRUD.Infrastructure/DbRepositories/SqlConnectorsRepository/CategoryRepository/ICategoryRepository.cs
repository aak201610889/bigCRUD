using bigCRUD.Application.Models;


namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.CategoryRepository
{
    public interface ICategoryRepository
    {
        public Task<Response<Category>> Create(Category entity);
        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken);
        public Task<Response<List<Category>>> GetAll();
        public Task<Response<Category>> GetById(int objectId, CancellationToken cancellationToken);
        public Task<Response<bool>> Update(Category entity, CancellationToken cancellationToken);

    }
}
