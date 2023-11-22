using bigCRUD.Application.Models;


namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductDetailsRepository
{
    public interface IProductDetailsRepository
    {
        public Task<Response<ProductDetails>> Create(ProductDetails entity);
        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken);
        public Task<Response<List<ProductDetails>>> GetAll();
        public Task<Response<ProductDetails>> GetById(int objectId, CancellationToken cancellationToken);
        public Task<Response<bool>> Update(ProductDetails entity, CancellationToken cancellationToken);
    }
}

