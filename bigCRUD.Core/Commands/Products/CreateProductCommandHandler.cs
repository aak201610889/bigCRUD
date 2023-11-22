using bigCRUD.Application.Models;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductRepository;

namespace bigCRUD.Core.Commands.Products
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Response<Product>>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }



        public async Task<Response<Product>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var response =await _productRepository.Create(request.product);

            return response;
        }
    }
}
