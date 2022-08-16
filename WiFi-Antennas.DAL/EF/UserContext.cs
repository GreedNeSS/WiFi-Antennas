using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.DAL.Entities;

namespace WiFi_Antennas.DAL.EF
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public UserContext(DbContextOptions<UserContext> context) : base(context)
        {
            Database.EnsureCreated();
        }
    }
}
