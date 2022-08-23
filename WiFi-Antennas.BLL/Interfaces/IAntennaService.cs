using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.DAL.Entities;

namespace WiFi_Antennas.BLL.Interfaces
{
    public interface IAntennaService
    {
        Task<List<AntennaDTO>> GetAntennasAsync(int take, int skip);
        Task<AntennaDTO> GetAntennaAsync(int id);
        Task CreateAsync(AntennaDTO antenna);
        Task UpdateAsync(AntennaDTO antenna);
        Task DeleteAsync(int antennaId);
    }
}
