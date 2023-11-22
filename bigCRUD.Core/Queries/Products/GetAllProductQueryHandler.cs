
using bigCRUD.Application.Models;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductRepository;
using MediatR;

namespace bigCRUD.Core.Queries.Products
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, Response<List<Product>>>
    {

        private readonly IProductRepository _productRepository;

        public GetAllProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Response<List<Product>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetAll();
        }
    }
}
