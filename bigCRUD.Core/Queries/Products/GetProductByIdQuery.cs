using bigCRUD.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Queries.Products
{
    public record GetProductByIdQuery(int objectId) : IRequest<Response<Product>>
    {
    }
}
