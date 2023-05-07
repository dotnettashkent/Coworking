using Coworking.Service.DTOs;
using Coworking.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coworking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async ValueTask<ActionResult> CreateAsync(UserCreationDto dto)
        {
            return Ok(
                new
                {
                    Code = 200,
                    Error = "Success",
                    Data = await this.userService.CreateAsync(dto)
                });
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllUserAsync()
        {
            return Ok(new
                {
                    Code = 200,
                    Error = "Success",
                    Data = await this.userService.GetAllAsync()
                });
        }

        [HttpDelete]
        public async ValueTask<bool> DeletedAsync(long id)
        {
            return await userService.DeleteAsync(id);
        }
    }
}
