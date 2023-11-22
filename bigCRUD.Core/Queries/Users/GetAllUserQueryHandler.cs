
using bigCRUD.Application.Models;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.UserRepository;
using MediatR;

namespace bigCRUD.Core.Queries.Users
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserQuery, Response<List<User>>>
    {

        private readonly IUserRepository _userRepository;

        public GetAllUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Response<List<User>>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetAll();
        }


    }
}
