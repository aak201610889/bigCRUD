using bigCRUD.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IRepository<Order> _sqlDbRepository;

        public OrderRepository(IRepository<Order> sqlDbRepository)
        {
            _sqlDbRepository = sqlDbRepository;
        }
        public async Task<Response<Order>> Create(Order entity)
        {
            return await _sqlDbRepository?.Create(entity);
        }

        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Delete(id, cancellationToken);
        }

        public Task<Response<List<Order>>> GetAll()
        {
            return _sqlDbRepository?.GetAll();
        }

        public Task<Response<Order>> GetById(int objectId, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.GetById(objectId, cancellationToken);
        }

        public Task<Response<bool>> Update(Order entity, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Update(entity, cancellationToken);
        }
    }
}
