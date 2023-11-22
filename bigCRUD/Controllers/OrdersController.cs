using bigCRUD.Application.Models;
using bigCRUD.Core.Commands.Orders;
using bigCRUD.Core.Commands.Products;
using bigCRUD.Core.Queries.Orders;
using bigCRUD.Core.Queries.Products;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace bigCRUD.EndPoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ISender _sender;

        public OrdersController(ISender sender)
        {
            _sender = sender;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var products = await _sender.Send(new GetAllOrderQuery());
            return Ok(products);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Order order)
        {
            Log.Information("order ==>", order);
            var p = await _sender.Send(new CreateOrderCommand(order));
            return Ok(p);
        }


        [HttpPost("update")]
        public async Task<IActionResult> Put(Order productd)
        {
            var p = await _sender.Send(new UpdateOrderCommand(productd));
            return Ok(p);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var p = await _sender.Send(new DeleteOrderCommand(id));
            return Ok(p);
        }

        [HttpGet("{objectId}")]
        public async Task<IActionResult> getById(int objectId)
        {
            var p = await _sender.Send(new GetOrderByIdQuery(objectId));
            return Ok(p);

        }
    }
}
