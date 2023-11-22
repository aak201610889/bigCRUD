using bigCRUD.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderDetailRepository;

namespace bigCRUD.Core.Commands.OrdersDetails
{
    public class CreateOrdersDetailsCommandHandler : IRequestHandler<CreateOrdersDetailsCommand, Response<OrderDetail>>
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public CreateOrdersDetailsCommandHandler(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<Response<OrderDetail>> Handle(CreateOrdersDetailsCommand request, CancellationToken cancellationToken)
        {
            return await _orderDetailRepository.Create(request.OrderDetail);
        }
    }
}
