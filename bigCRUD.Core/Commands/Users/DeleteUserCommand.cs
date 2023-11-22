using bigCRUD.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Commands.Users
{
    public record DeleteUserCommand(int id) : IRequest<Response<bool>>
    {
    }
}
