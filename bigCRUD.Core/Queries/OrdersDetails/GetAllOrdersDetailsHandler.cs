using bigCRUD.Application.Models;
using bigCRUD.Core.Queries.Orders;
using bigCRUD.Core.Queries.Products;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.CategoryRepository;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderDetailRepository;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Queries.OrdersDetails
{
    public class GetAllOrdersDetailsHandler : IRequestHandler<GetAllOrdersDetailsQuery, Response<List<OrderDetail>>>
    {

        private readonly IOrderDetailRepository _orderDetailRepository;

        public GetAllOrdersDetailsHandler(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<Response<List<OrderDetail>>> Handle(GetAllOrdersDetailsQuery request, CancellationToken cancellationToken)
        {
            return await _orderDetailRepository.GetAll();
        }


    }
}
