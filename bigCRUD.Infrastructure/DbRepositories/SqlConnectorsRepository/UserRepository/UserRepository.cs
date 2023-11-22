using bigCRUD.Application.Models;

namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.UserRepository
{
    public class UserRepository : IUserRepository
    {


        private readonly IRepository<User> _sqlDbRepository;

        public UserRepository(IRepository<User> sqlDbRepository)
        {
            _sqlDbRepository = sqlDbRepository;
        }

        public async Task<Response<User>> Create(User entity)
        {
            return await _sqlDbRepository?.Create(entity);
        }

        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Delete(id, cancellationToken);
        }

        public Task<Response<List<User>>> GetAll()
        {
            return _sqlDbRepository?.GetAll();
        }


        public Task<Response<User>> GetById(int objectId, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.GetById(objectId, cancellationToken);
        }

        public Task<Response<bool>> Update(User entity, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Update(entity, cancellationToken);
        }

    }
}
