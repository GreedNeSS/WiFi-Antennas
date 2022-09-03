using System;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.DAL.EF;
using WiFi_Antennas.Models;

namespace WiFi_Antennas.Mappers
{
    public static class SortStateMapper
    {
        public static SortStateDTO ToDTO(this SortStateViewModel sortStateViewModel)
        {
            SortStateDTO sortState = sortStateViewModel switch
            {
                SortStateViewModel.AddressAsc => SortStateDTO.AddressAsc,
                SortStateViewModel.AddressDesc => SortStateDTO.AddressDesc,
                SortStateViewModel.SSIDAsc => SortStateDTO.SSIDAsc,
                SortStateViewModel.SSIDDesc => SortStateDTO.SSIDDesc,
                SortStateViewModel.IpDesc => SortStateDTO.IpDesc,
                _ => SortStateDTO.IpAsc,
            };

            return sortState;
        }

        public static SortStateViewModel ToViewModel(this SortStateDTO sortStateDTO)
        {
            SortStateViewModel sortStateViewModel = sortStateDTO switch
            {
                SortStateDTO.AddressAsc => SortStateViewModel.AddressAsc,
                SortStateDTO.AddressDesc => SortStateViewModel.AddressDesc,
                SortStateDTO.SSIDAsc => SortStateViewModel.SSIDAsc,
                SortStateDTO.SSIDDesc => SortStateViewModel.SSIDDesc,
                SortStateDTO.IpDesc => SortStateViewModel.IpDesc,
                _ => SortStateViewModel.IpAsc,
            };

            return sortStateViewModel;
        }
    }
}
