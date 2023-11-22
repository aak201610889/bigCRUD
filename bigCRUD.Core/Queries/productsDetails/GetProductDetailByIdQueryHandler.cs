using bigCRUD.Application.Models;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductDetailsRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Queries.productsDetails
{
    internal class GetProductDetailByIdQueryHandler : IRequestHandler<GetProductDetailByIdQuery, Response<ProductDetails>>
    {
        private readonly IProductDetailsRepository _productDetailsRepository;

        public GetProductDetailByIdQueryHandler(IProductDetailsRepository productDetailsRepository)
        {
            _productDetailsRepository = productDetailsRepository;
        }

        public async Task<Response<ProductDetails>> Handle(GetProductDetailByIdQuery request, CancellationToken cancellationToken)
        {
            return await _productDetailsRepository.GetById(request.objectId, cancellationToken).ConfigureAwait(false);
        }
    }
}
