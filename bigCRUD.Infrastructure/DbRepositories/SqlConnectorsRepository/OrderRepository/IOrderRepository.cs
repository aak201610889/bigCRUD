using bigCRUD.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderRepository
{
    public interface IOrderRepository
    {
        public Task<Response<Order>> Create(Order entity);
        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken);
        public Task<Response<List<Order>>> GetAll();
        public Task<Response<Order>> GetById(int objectId, CancellationToken cancellationToken);
        public Task<Response<bool>> Update(Order entity, CancellationToken cancellationToken);
    }
}
