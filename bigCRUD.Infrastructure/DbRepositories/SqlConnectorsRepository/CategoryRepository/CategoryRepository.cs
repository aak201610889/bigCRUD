using bigCRUD.Application.Models;

namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {


        private readonly IRepository<Category> _sqlDbRepository;

        public CategoryRepository(IRepository<Category> sqlDbRepository)
        {
            _sqlDbRepository = sqlDbRepository;
        }

        public async Task<Response<Category>> Create(Category entity)
        {
            return await _sqlDbRepository?.Create(entity);
        }

        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Delete(id, cancellationToken);
        }

        public Task<Response<List<Category>>> GetAll()
        {
            return _sqlDbRepository?.GetAll();
        }


        public Task<Response<Category>> GetById(int objectId, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.GetById(objectId, cancellationToken);
        }

        public Task<Response<bool>> Update(Category entity, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Update(entity, cancellationToken);
        }

    }
}
