using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Logic
{

    public class LogicClass
    {

        private readonly Repo _repo;

        public LogicClass(Repo repo)
        {
            _repo = repo;
        }


        public async Task<IEnumerable<AppUser>> getAllUsers()
        {
            return await _repo.getAllUser();
        }

        public async Task<AppUser> getUser(int id)
        {
            return await _repo.getUser(id);
        }
    
        
    }
}