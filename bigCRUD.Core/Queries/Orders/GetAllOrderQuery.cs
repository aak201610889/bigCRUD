using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bigCRUD.Application.Models;
namespace bigCRUD.Core.Queries.Orders
{
    public record GetAllOrderQuery : IRequest<Response<List<Order>>> { }
}
