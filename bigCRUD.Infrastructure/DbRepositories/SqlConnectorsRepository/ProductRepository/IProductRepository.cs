using bigCRUD.Application.Models;


namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductRepository
{
    public interface IProductRepository
    {
        public Task<Response<Product>> Create(Product entity);
        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken);
        public Task<Response<List<Product>>> GetAll();
        public Task<Response<Product>> GetById(int objectId, CancellationToken cancellationToken);
        public Task<Response<bool>> Update(Product entity, CancellationToken cancellationToken);

    }
}
