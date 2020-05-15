using System;
using System.Collections.Generic;
using DotnetCoreWebApplication.Model;
using DotnetCoreWebApplication.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreWebApplication.Controller
{
    [ApiController]
    [Route("user-states")]
    public class UserStateController : ControllerBase
    {
        private readonly IUserStateRepository _repository;

        public UserStateController(IUserStateRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("{userId}")]
        public ActionResult<IEnumerable<UserState>> FindByUserId(string userId)
        {
            Int64.Parse(userId);
            return Ok(_repository.FindByUserId(Int32.Parse(userId)));
        }
    }
}