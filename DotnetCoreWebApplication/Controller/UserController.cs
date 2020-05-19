using System.Net.Mime;
using DotnetCoreWebApplication.Controller.Resource;
using DotnetCoreWebApplication.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreWebApplication.Controller
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult FindAllUsers()
        {
            return Ok(_repository.FindAll());
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        public ActionResult<UserRegistryResponse> Register([FromBody] UserRegistryRequest userRegistryRequest)
        {
            var mockUserRegistryResponse = new UserRegistryResponse
            {
                NickName = userRegistryRequest.NickName,
                Name = userRegistryRequest.Name,
                AccessToken = "621629ac-215d-47bd-a293-ad397758958c"
            };
            return Ok(mockUserRegistryResponse);
        }
        
    }
}