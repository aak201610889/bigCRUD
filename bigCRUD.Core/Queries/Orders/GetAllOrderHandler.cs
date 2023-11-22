using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderRepository;
using MediatR;
using bigCRUD.Application.Models;

namespace bigCRUD.Core.Queries.Orders
{
    public class GetAllOrderHandler : IRequestHandler<GetAllOrderQuery, Response<List<Order>>>
    {


        private readonly IOrderRepository _orderRepository;

        public GetAllOrderHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Response<List<Order>>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
        {
            return await _orderRepository.GetAll();
        }
    }
}
