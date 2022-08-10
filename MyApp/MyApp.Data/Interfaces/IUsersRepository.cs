using MyApp.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data.Interfaces
{
    public interface IUsersRepository
    {
        Task<IEnumerable<AppUser>> GetUsers();
        Task<AppUser> GetUser(int id);
    }
}
