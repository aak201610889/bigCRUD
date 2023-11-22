using bigCRUD.Application.Models;
using bigCRUD.Core.Queries.Products;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductDetailsRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Queries.productsDetails
{
    public class GetAllProductsDeailsHandler : IRequestHandler<GetAllProductsDeailsQuery, Response<List<ProductDetails>>>
    {
        private readonly IProductDetailsRepository _productDetailsRepository;

        public GetAllProductsDeailsHandler(IProductDetailsRepository productDetailsRepository)
        {
            _productDetailsRepository = productDetailsRepository;
        }

        public async Task<Response<List<ProductDetails>>> Handle(GetAllProductsDeailsQuery request, CancellationToken cancellationToken)
        {
            return await _productDetailsRepository.GetAll();
        }
    }
}
