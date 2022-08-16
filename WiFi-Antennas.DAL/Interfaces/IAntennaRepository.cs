using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.DAL.Entities;

namespace WiFi_Antennas.DAL.Interfaces
{
    public interface IAntennaRepository
    {
        List<Antenna> GetAntennas(int take, int skip);
        bool Create(Antenna antenna);
        bool Update(Antenna antenna);
        bool Delete(Antenna antenna);
    }
}
