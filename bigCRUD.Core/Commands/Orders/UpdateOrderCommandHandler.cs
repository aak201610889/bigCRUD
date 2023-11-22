using bigCRUD.Application.Models;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Commands.Orders
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, Response<bool>>
    {
        private readonly IOrderRepository _orderRepository;

        public UpdateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Response<bool>> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            return await _orderRepository.Update(request.order, cancellationToken);
        }
    }
}
