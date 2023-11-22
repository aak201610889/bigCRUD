using bigCRUD.Application.Models;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.UserRepository;

namespace bigCRUD.Core.Commands.Users
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Response<User>>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository UserRepository)
        {
            _userRepository = UserRepository;
        }



        public async Task<Response<User>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var response = await _userRepository.Create(request.user);

            return response;
        }
    }
}
