using bigCRUD.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderDetailRepository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly IRepository<OrderDetail> _sqlDbRepository;

        public OrderDetailRepository(IRepository<OrderDetail> sqlDbRepository)
        {
            _sqlDbRepository = sqlDbRepository;
        }
        public async Task<Response<OrderDetail>> Create(OrderDetail entity)
        {
            return await _sqlDbRepository?.Create(entity);
        }

        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Delete(id, cancellationToken);
        }

        public Task<Response<List<OrderDetail>>> GetAll()
        {
            return _sqlDbRepository?.GetAll();
        }

        public Task<Response<OrderDetail>> GetById(int objectId, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.GetById(objectId, cancellationToken);
        }

        public Task<Response<bool>> Update(OrderDetail entity, CancellationToken cancellationToken)
        {
            return _sqlDbRepository.Update(entity, cancellationToken);
        }
    }
}
