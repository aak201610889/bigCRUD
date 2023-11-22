using bigCRUD.Application.Models;

using bigCRUD.Core.Commands.Products;
using bigCRUD.Core.Commands.Users;
using bigCRUD.Core.Queries.Products;
using bigCRUD.Core.Queries.Users;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bigCRUD.EndPoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _sender;

        public UsersController(IMediator sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _sender.Send(new GetAllUserQuery());
            return Ok(users);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            var u = await _sender.Send(new CreateUserCommand(user));
            return Ok(u);
        }


        [HttpPost("update")]
        public async Task<IActionResult> Put(User productd)
        {
            var p = await _sender.Send(new UpdateUserCommand(productd));
            return Ok(p);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var p = await _sender.Send(new DeleteUserCommand(id));
            return Ok(p);
        }

        [HttpGet("{objectId}")]
        public async Task<IActionResult> getById(int objectId)
        {
            var p = await _sender.Send(new GetUserByIdQuery(objectId));
            return Ok(p);

        }
    }
}
