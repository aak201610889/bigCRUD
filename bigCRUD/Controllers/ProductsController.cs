
using bigCRUD.Application.Models;
using bigCRUD.Application.Models.Dtos;
using bigCRUD.Core.Commands.Products;
using bigCRUD.Core.Queries.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Serilog;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bigCRUD.EndPoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _sender;

        public ProductsController(IMediator sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _sender.Send(new GetAllProductQuery());
            return Ok(products);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] ProductDto dto)

        {
            using var dataStream = new MemoryStream();
            await dto.ProductImage.CopyToAsync(dataStream);
            var product = new Product
            {
                ProductImage = dataStream.ToArray(),
                CategoryId = dto.CategoryId,
                Description = dto.Description,
                price = dto.price,
                Name = dto.Name,


            };
            var p = await _sender.Send(new CreateProductCommand(product));
            return Ok(p);
        }




        [HttpPost("update")]
        public async Task<IActionResult> Put([FromForm] Product2Dto dto)

        {
            using var dataStream = new MemoryStream();
            await dto.ProductImage.CopyToAsync(dataStream);
            var product = new Product
            {

                ProductImage = dataStream.ToArray(),
                CategoryId = dto.CategoryId,
                Description = dto.Description,
                price = dto.price,
                Name = dto.Name,


            };
            var p = await _sender.Send(new UpdateProductCommand(product));
            return Ok(p);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var p = await _sender.Send(new DeleteProductCommand(id));
            return Ok(p);
        }

        [HttpGet("{objectId}")]
        public async Task<IActionResult> getById(int objectId)
        {
            var p = await _sender.Send(new GetProductByIdQuery(objectId));
            return Ok(p);

        }
    }
}
