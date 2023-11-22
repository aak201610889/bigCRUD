using bigCRUD.Application.Models;


namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.UserRepository
{
    public interface IUserRepository
    {
        public Task<Response<User>> Create(User entity);
        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken);
        public Task<Response<List<User>>> GetAll();
        public Task<Response<User>> GetById(int objectId, CancellationToken cancellationToken);
        public Task<Response<bool>> Update(User entity, CancellationToken cancellationToken);

    }
}
