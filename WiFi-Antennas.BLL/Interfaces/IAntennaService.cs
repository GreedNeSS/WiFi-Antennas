using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.DAL.EF;
using WiFi_Antennas.DAL.Entities;

namespace WiFi_Antennas.BLL.Interfaces
{
    public interface IAntennaService
    {
        Task<List<AntennaDTO>> GetAntennasAsync(int take, int skip, string ssid, string ip,
            string address, SortStateDTO sortState = SortStateDTO.IpAsc);
        Task<int> GetCountAsync(string ssid, string ip, string address);
        Task<AntennaDTO> GetAntennaAsync(int id);
        Task CreateAsync(AntennaDTO antenna);
        Task UpdateAsync(AntennaDTO antenna);
        Task DeleteAsync(int antennaId);
    }
}
