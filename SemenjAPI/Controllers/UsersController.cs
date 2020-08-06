using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FluentValidation;
using SemenjAPI.Interfaces;
using SemenjAPI.ModelsDto;
using SemenjAPI.ModelsRo;
using SemenjAPI.Validators;
using Microsoft.AspNetCore.Http;

namespace SemenjAPI.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult<UserRo>> Post(
            [FromBody] UserDto userDto)
        {
            var userValidator = new UserValidator();
            userValidator.ValidateAndThrow(userDto);

            var newUser = await userService.CreateUser(userDto);
            var result = new UserRo(
                 message : "User created successfully!",
                 username : userDto.Username,
                 password : userDto.Password,
                 error : "No error! :)"
                );

            return result;
        }

    }
}
