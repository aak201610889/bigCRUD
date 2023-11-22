using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using bigCRUD.Application.Models;
namespace bigCRUD.Core.Queries.OrdersDetails
{
    public record GetAllOrdersDetailsQuery : IRequest<Response<List<OrderDetail>>> { }
}
