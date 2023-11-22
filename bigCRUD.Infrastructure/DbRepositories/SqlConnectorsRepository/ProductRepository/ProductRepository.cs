using bigCRUD.Application.Models;

namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {


        private readonly IRepository<Product> _sqlDbRepository;

        public ProductRepository(IRepository<Product> sqlDbRepository)
        {
            _sqlDbRepository = sqlDbRepository;
        }

        public async Task<Response<Product>> Create(Product entity)
        {
            return await _sqlDbRepository?.Create(entity);
        }

        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Delete(id, cancellationToken);
        }

        public Task<Response<List<Product>>> GetAll()
        {
            return _sqlDbRepository?.GetAll();
        }


        public Task<Response<Product>> GetById(int objectId, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.GetById(objectId, cancellationToken);
        }

        public Task<Response<bool>> Update(Product entity, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Update(entity, cancellationToken);
        }

    }
}
