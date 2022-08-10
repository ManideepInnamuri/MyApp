using Microsoft.EntityFrameworkCore;
using MyApp.Common.Data;
using MyApp.Common.Entities;
using MyApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data.Implementations
{
    public class UsersRepository : IUsersRepository
    {
        private readonly DataContext _context;

        public UsersRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AppUser>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<AppUser> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }
    }
}
