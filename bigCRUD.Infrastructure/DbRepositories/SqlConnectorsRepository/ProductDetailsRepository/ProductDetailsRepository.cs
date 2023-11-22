using bigCRUD.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductDetailsRepository
{
    public class ProductDetailsRepository : IProductDetailsRepository
    {
        private readonly IRepository<ProductDetails> _sqlDbRepository;

        public ProductDetailsRepository(IRepository<ProductDetails> sqlDbRepository)
        {
            _sqlDbRepository = sqlDbRepository;
        }

        public async Task<Response<ProductDetails>> Create(ProductDetails entity)
        {
            return await _sqlDbRepository?.Create(entity);
        }

        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Delete(id, cancellationToken);
        }

        public Task<Response<List<ProductDetails>>> GetAll()
        {
            return _sqlDbRepository?.GetAll();
        }

        public Task<Response<ProductDetails>> GetById(int objectId, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.GetById(objectId, cancellationToken);
        }

        public Task<Response<bool>> Update(ProductDetails entity, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Update(entity, cancellationToken);
        }
    }
}
