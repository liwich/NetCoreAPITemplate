using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Training.API.Operations.Users;
using Training.DTO;

namespace Training.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IServiceProvider _IoC;

        public UsersController(IServiceProvider services)
        {
            _IoC = services;
        }

        [HttpGet]
        public async Task<List<DTO.User>> GetUsers()
        {
            return await _IoC.GetService<GetAll>().Execute();
        }
        
        [HttpGet]
        [Route("/{id}")]
        public async Task<DTO.User> GetUserById([FromRoute] string id)
        {
            //TODO implement GetUserById Operation
            return new User() { Email = "xxx", Id = "xxx", FullName = "xxx", Gender = "" };
        }

        [HttpPost]
        [Route("signup")]
        public async Task<DTO.User> SignUp(UserSignup user)
        {
            return await _IoC.GetService<SignUp>().Execute(user);
        }
    }
}