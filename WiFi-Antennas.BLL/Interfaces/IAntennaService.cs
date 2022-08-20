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
        Task<List<AntennaDTO>> GetAntennas(int take, int skip);
        Task<AntennaDTO> GetAntenna(int id);
        void Create(AntennaDTO antenna);
        void Update(AntennaDTO antenna);
        void Delete(AntennaDTO antenna);
    }
}
