using bigCRUD.Application.Models;
using bigCRUD.Core.Commands.OrdersDetails;
using bigCRUD.Core.Commands.Products;
using bigCRUD.Core.Queries.Orders;
using bigCRUD.Core.Queries.OrdersDetails;
using bigCRUD.Core.Queries.Products;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace bigCRUD.EndPoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class orderDetailsController : ControllerBase
    {
        private readonly IMediator _sender;

        public orderDetailsController(IMediator sender)
        {
            _sender = sender;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrderDetails()
        {
            var products = await _sender.Send(new GetAllOrdersDetailsQuery());
            return Ok(products);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderDetail orderDetail)
        {
            Log.Information("orderDetail ==>", orderDetail);
            var p = await _sender.Send(new CreateOrdersDetailsCommand(orderDetail));
            return Ok(p);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Put(OrderDetail productd)
        {
            var p = await _sender.Send(new UpdateOrderDetailsCommand(productd));
            return Ok(p);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var p = await _sender.Send(new DeleteOrderDetailCommand(id));
            return Ok(p);
        }

        [HttpGet("{objectId}")]
        public async Task<IActionResult> getById(int objectId)
        {
            var p = await _sender.Send(new GetOrderDetailsByIdQuery(objectId));
            return Ok(p);

        }

    }
}
