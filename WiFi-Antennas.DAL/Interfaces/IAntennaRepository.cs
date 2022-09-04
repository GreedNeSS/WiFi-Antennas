using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.DAL.EF;
using WiFi_Antennas.DAL.Entities;

namespace WiFi_Antennas.DAL.Interfaces
{
    public interface IAntennaRepository
    {
        Task<List<Antenna>> GetAntennas(int take, int skip, string ssid, string ip, string address, SortState sortState);
        Task<Antenna?> GetAntenna(int id);
        Task Create(Antenna antenna);
        Task Update(Antenna antenna);
        Task Delete(Antenna antenna);
        Task<int> GetCount();
    }
}
