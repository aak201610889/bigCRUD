using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bigCRUD.Application.Models;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderDetailRepository;
using MediatR;
namespace bigCRUD.Core.Commands.OrdersDetails
{
    public class UpdateOrderDetailsCommandHandler : IRequestHandler<UpdateOrderDetailsCommand, Response<bool>>
    {
        private readonly IOrderDetailRepository _orderDetailRespository;

        public UpdateOrderDetailsCommandHandler(IOrderDetailRepository orderDetailRespository)
        {
            _orderDetailRespository = orderDetailRespository;
        }

        public async Task<Response<bool>> Handle(UpdateOrderDetailsCommand request, CancellationToken cancellationToken)
        {
            return await _orderDetailRespository.Update(request.orderDetail, cancellationToken);
        }
    }
}
