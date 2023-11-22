using bigCRUD.Application.Models;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Commands.Products
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Response<bool>>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Response<bool>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return await _productRepository.Update(request.product, cancellationToken);
        }
    }
}
