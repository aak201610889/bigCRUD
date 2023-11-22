using bigCRUD.Application.Models;
using bigCRUD.Application.Models.Dtos;
using bigCRUD.Core.Commands.Products;
using bigCRUD.Core.Commands.ProductsDetails;
using bigCRUD.Core.Queries.Products;
using bigCRUD.Core.Queries.productsDetails;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using static System.Net.Mime.MediaTypeNames;

namespace bigCRUD.EndPoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly ISender _sender;

        public ProductDetailsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductDetails()
        {
            var products = await _sender.Send(new GetAllProductsDeailsQuery());
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] ProductDetailsDto dto)
        {
            using var dataStream = new MemoryStream();
            await dto.Image.CopyToAsync(dataStream);
            var productDetail = new ProductDetails
            {
                ProductId = dto.ProductId,
                Image = dataStream.ToArray(),
                Rate = dto.Rate,
                Description = dto.Description

            };

            Log.Information("product details", productDetail);
            var p = await _sender.Send(new CreateProductsDetailsCommand(productDetail));
            return Ok(p);
        }





        [HttpPost("update")]
        public async Task<IActionResult> Put(ProductDetails productd)
        {
            var p = await _sender.Send(new UpdateProductsDetailsCommand(productd));
            return Ok(p);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var p = await _sender.Send(new DeleteProductsDetailsCommand(id));
            return Ok(p);
        }

        [HttpGet("{objectId}")]
        public async Task<IActionResult> getById(int objectId)
        {
            var p = await _sender.Send(new GetProductDetailByIdQuery(objectId));
            return Ok(p);

        }
    }
}
