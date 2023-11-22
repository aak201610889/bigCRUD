using bigCRUD.Application.Models;
using MediatR;

namespace bigCRUD.Core.Queries.Users
{
    public record GetAllUserQuery : IRequest<Response<List<User>>>
    {
    }

}
