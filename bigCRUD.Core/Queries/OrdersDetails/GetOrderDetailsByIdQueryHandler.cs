using bigCRUD.Application.Models;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderDetailRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Queries.OrdersDetails
{
    public class GetOrderDetailsByIdQueryHandler : IRequestHandler<GetOrderDetailsByIdQuery, Response<OrderDetail>>
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public GetOrderDetailsByIdQueryHandler(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<Response<OrderDetail>> Handle(GetOrderDetailsByIdQuery request, CancellationToken cancellationToken)
        {
            return await _orderDetailRepository.GetById(request.orderDetail, cancellationToken);
        }
    }
}
