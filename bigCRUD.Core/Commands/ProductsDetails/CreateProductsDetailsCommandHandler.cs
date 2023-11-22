using bigCRUD.Application.Models;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductDetailsRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Commands.ProductsDetails
{
    public class CreateProductsDetailsCommandHandler : IRequestHandler<CreateProductsDetailsCommand, Response<ProductDetails>>
    {

        private readonly IProductDetailsRepository _productDetailsRepository;

        public CreateProductsDetailsCommandHandler(IProductDetailsRepository productDetailsRepository)
        {
            _productDetailsRepository = productDetailsRepository;
        }

        public async Task<Response<ProductDetails>> Handle(CreateProductsDetailsCommand request, CancellationToken cancellationToken)
        {
            var response = await _productDetailsRepository.Create(request.productDetails);
            return response;
        }
    }
}
