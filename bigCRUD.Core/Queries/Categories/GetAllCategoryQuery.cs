using bigCRUD.Application.Models;
using MediatR;
namespace bigCRUD.Core.Queries.Categories
{
    public record GetAllCategoryQuery : IRequest<Response<List<Category>>>
    {
    }

}
