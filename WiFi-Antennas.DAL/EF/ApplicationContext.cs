using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.DAL.Entities;

namespace WiFi_Antennas.DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Antenna> Antennas { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> context) : base(context)
        {
            Database.EnsureCreated();
        }
    }
}
