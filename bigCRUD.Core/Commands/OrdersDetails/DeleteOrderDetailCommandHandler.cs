using bigCRUD.Application.Models;
using bigCRUD.Infrastructure.DbRepositories.SqlConnectorsRepository.OrderDetailRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core.Commands.OrdersDetails
{
    public class DeleteOrderDetailCommandHandler : IRequestHandler<DeleteOrderDetailCommand, Response<bool>>
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public DeleteOrderDetailCommandHandler(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<Response<bool>> Handle(DeleteOrderDetailCommand request, CancellationToken cancellationToken)
        {
            return await _orderDetailRepository.Delete(request.id, cancellationToken);
        }
    }
}
