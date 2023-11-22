using bigCRUD.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderDetailRepository
{
    public interface IOrderDetailRepository
    {
        public Task<Response<OrderDetail>> Create(OrderDetail entity);
        public Task<Response<bool>> Delete(int id, CancellationToken cancellationToken);
        public Task<Response<List<OrderDetail>>> GetAll();
        public Task<Response<OrderDetail>> GetById(int objectId, CancellationToken cancellationToken);
        public Task<Response<bool>> Update(OrderDetail entity, CancellationToken cancellationToken);
    }
}

