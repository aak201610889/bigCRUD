using bigCRUD.Application.Models;
using bigCRUD.Core.Commands.Products;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Commands.Orders
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Response<Order>>
    {
        private readonly IOrderRepository _orderRepository;

        public CreateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Response<Order>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            return await _orderRepository.Create(request.order);
        }
    }
}
