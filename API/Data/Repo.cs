using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Data
{
    public class Repo
    {
        private readonly DataContext _context;
        private readonly ILogger _logger;
        public DbSet<AppUser> AppUserSet;

        public Repo(DataContext context, ILogger<Repo> logger)
        {
            _context = context;
            _logger = logger; 
            this.AppUserSet = _context.Users;
        }
 
        public async Task<IEnumerable<AppUser>> getAllUser()
        {
            return await AppUserSet.ToListAsync();
        }
        
        public async Task<AppUser> getUser(int id)
        {
            return await AppUserSet.FindAsync(id);
        }
    }
}