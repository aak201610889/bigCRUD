using bigCRUD.Application.Models;
using bigCRUD.Core.Commands.Products;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductDetailsRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Commands.ProductsDetails
{
    public class DeleteProductsDetailsCommandHandler : IRequestHandler<DeleteProductsDetailsCommand, Response<bool>>
    {
        private readonly IProductDetailsRepository _productDetailsRepository;

        public DeleteProductsDetailsCommandHandler(IProductDetailsRepository productDetailsRepository)
        {
            _productDetailsRepository = productDetailsRepository;
        }

        public async Task<Response<bool>> Handle(DeleteProductsDetailsCommand request, CancellationToken cancellationToken)
        {
            return await _productDetailsRepository.Delete(request.id, cancellationToken);

        }
    }
}
