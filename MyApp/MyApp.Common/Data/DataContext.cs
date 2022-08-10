using Microsoft.EntityFrameworkCore;
using MyApp.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Common.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
                
        }
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
