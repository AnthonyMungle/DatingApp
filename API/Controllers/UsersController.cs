using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Logic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly LogicClass _Logic;

        public UsersController(LogicClass context)
        {
            _Logic = context; 
        }


        [HttpGet]
        public async Task<IEnumerable<AppUser>> GetUsers()
        {
            return await _Logic.getAllUsers();
        }

        [HttpGet("{id}")]
        public async Task<AppUser> GetUser(int id)
        {
            return await _Logic.getUser(id);
        }

    }
}