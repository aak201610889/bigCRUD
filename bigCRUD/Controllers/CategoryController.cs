using bigCRUD.Application.Models;
using bigCRUD.Core.Commands.Categories;

using bigCRUD.Core.Queries.Categories;
using bigCRUD.Core.Queries.Products;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bigCRUD.EndPoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _sender;

        public CategoryController(IMediator sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            var categories = await _sender.Send(new GetAllCategoryQuery());
            return Ok(categories);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Category category)
        {
            var p = await _sender.Send(new CreateCategoryCommand(category));
            return Ok(p);
        }


        [HttpPost("update")]
        public async Task<IActionResult> Put(Category productd)
        {
            var p = await _sender.Send(new UpdateCategoryCommand(productd));
            return Ok(p);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var p = await _sender.Send(new DeleteCategoryCommand(id));
            return Ok(p);
        }

        [HttpGet("{objectId}")]
        public async Task<IActionResult> getById(int objectId)
        {
            var p = await _sender.Send(new GetCategoryByIdQuery(objectId));
            return Ok(p);

        }
    }
}
