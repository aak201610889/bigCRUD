using bigCRUD.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Queries.Users
{
    public record GetUserByIdQuery(int objectId) : IRequest<Response<User>>
    {
    }
}
