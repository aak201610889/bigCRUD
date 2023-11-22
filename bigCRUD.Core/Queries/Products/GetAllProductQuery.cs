using bigCRUD.Application.Models;
using MediatR;

namespace bigCRUD.Core.Queries.Products
{
    public record GetAllProductQuery : IRequest<Response<List<Product>>>
    {
    }

}
