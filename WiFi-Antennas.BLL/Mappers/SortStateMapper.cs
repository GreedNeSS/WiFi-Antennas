using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.DAL.EF;

namespace WiFi_Antennas.BLL.Mappers
{
    public static class SortStateMapper
    {
        public static SortState ToDAL(this SortStateDTO sortStateDTO)
        {
            SortState sortState = sortStateDTO switch
            {
                SortStateDTO.AddressAsc => SortState.AddressAsc,
                SortStateDTO.AddressDesc => SortState.AddressDesc,
                SortStateDTO.SSIDAsc => SortState.SSIDAsc,
                SortStateDTO.SSIDDesc => SortState.SSIDDesc,
                SortStateDTO.IpAsc => SortState.IpAsc,
                SortStateDTO.IpDesc => SortState.IpDesc,
                _ => SortState.IpAsc,
            };

            return sortState;
        }
    }
}
