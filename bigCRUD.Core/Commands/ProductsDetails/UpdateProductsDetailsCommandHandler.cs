﻿using bigCRUD.Application.Models;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.ProductDetailsRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Commands.ProductsDetails
{
    public class UpdateProductsDetailsCommandHandler : IRequestHandler<UpdateProductsDetailsCommand, Response<bool>>
    {
        private readonly IProductDetailsRepository _productDetailsRepository;

        public UpdateProductsDetailsCommandHandler(IProductDetailsRepository productDetailsRepository)
        {
            _productDetailsRepository = productDetailsRepository;
        }

        public async Task<Response<bool>> Handle(UpdateProductsDetailsCommand request, CancellationToken cancellationToken)
        {
            return await _productDetailsRepository.Update(request.productDetails, cancellationToken);
        }
    }
}
