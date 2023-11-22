using bigCRUD.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Queries.productsDetails
{
    public record class GetProductDetailByIdQuery(int objectId) : IRequest<Response<ProductDetails>>
    {
    }
}
