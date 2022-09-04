using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using WiFi_Antennas.DAL.EF;
using WiFi_Antennas.DAL.Entities;
using WiFi_Antennas.DAL.Interfaces;

namespace WiFi_Antennas.DAL.Repositories
{
    public class AntennaRepository : IAntennaRepository
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

        public async Task<List<Antenna>> GetAntennas(int take, int skip, string ssid, string ip,
            string address, SortState sortState = SortState.IpAsc)
        {
            IQueryable<Antenna> antennas = db.Antennas;

            if (!string.IsNullOrEmpty(ssid))
            {
                antennas = antennas.Where(a => a.SSID!.Contains(ssid));
            }

            if (!string.IsNullOrEmpty(ip))
            {
                antennas = antennas.Where(a => a.Ip!.Contains(ip));
            }

            if (!string.IsNullOrEmpty(address))
            {
                antennas = antennas.Where(a => a.Address!.Contains(address));
            }

            antennas = sortState switch
            {
                SortState.IpDesc => antennas.OrderByDescending(a => a.Ip),
                SortState.SSIDDesc => antennas.OrderByDescending(a => a.SSID),
                SortState.SSIDAsc => antennas.OrderBy(a => a.SSID),
                SortState.AddressAsc => antennas.OrderBy(a => a.Address),
                SortState.AddressDesc => antennas.OrderByDescending(a => a.Address),
                _ => antennas.OrderBy(a => a.Ip)
            };

            List<Antenna> antennaList = await antennas.Skip(skip).Take(take).ToListAsync();
            return antennaList;
        }

        public async Task<int> GetCount()
        {
            int count = await db.Antennas.CountAsync();
            return count;
        }

        public async Task Update(Antenna antenna)
        {
            db.Antennas.Update(antenna);
            await db.SaveChangesAsync();
        }
    }
}
