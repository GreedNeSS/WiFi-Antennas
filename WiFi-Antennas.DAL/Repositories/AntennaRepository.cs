using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.DAL.EF;
using WiFi_Antennas.DAL.Entities;
using WiFi_Antennas.DAL.Interfaces;

namespace WiFi_Antennas.DAL.Repositories
{
    internal class AntennaRepository : IAntennaRepository
    {
        private ApplicationContext db;

        public AntennaRepository(ApplicationContext context)
        {
            db = context;
        }

        public async Task Create(Antenna antenna)
        {
            await db.Antennas.AddAsync(antenna);
            await db.SaveChangesAsync();
        }

        public async Task Delete(Antenna antenna)
        {
            db.Entry(antenna).State = EntityState.Deleted;
            await db.SaveChangesAsync();
        }

        public async Task<Antenna?> GetAntenna(int id)
        {
            Antenna? antenna = await db.Antennas.FirstOrDefaultAsync(a => a.Id == id);
            return antenna;
        }

        public List<Antenna> GetAntennas(int take, int skip)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Antenna antenna)
        {
            db.Antennas.Update(antenna);
            await db.SaveChangesAsync();
        }
    }
}
