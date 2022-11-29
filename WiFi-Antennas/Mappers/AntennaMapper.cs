using System;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.Models;

namespace WiFi_Antennas.Mappers
{
    public static class AntennaMapper
    {
        public static AntennaDTO ToDTO(this AntennaViewModel antennaView)
        {
            return new AntennaDTO()
            {
                Address = antennaView.Address,
                Channel = antennaView.Channel,
                ChannelWidth = antennaView.ChannelWidth,
                Ip = antennaView.Ip,
                IsServer = antennaView.IsServer,
                Login = antennaView.Login,
                AccessPointPassword = antennaView.AccessPointPassword,
                HardwarePassword = antennaView.HardwarePassword,
                SSID = antennaView.SSID,
                Id = antennaView.Id,
                Producer = antennaView.Producer,
                Commentary = antennaView.Commentary,
            };
        }
        public static AntennaViewModel ToViewModel(this AntennaDTO antennaDTO)
        {
            return new AntennaViewModel()
            {
                Address = antennaDTO.Address,
                Channel = antennaDTO.Channel,
                ChannelWidth = antennaDTO.ChannelWidth,
                Ip = antennaDTO.Ip,
                IsServer = antennaDTO.IsServer,
                Login = antennaDTO.Login,
                AccessPointPassword = antennaDTO.AccessPointPassword,
                HardwarePassword = antennaDTO.HardwarePassword,
                SSID = antennaDTO.SSID,
                Id = antennaDTO.Id,
                Producer = antennaDTO.Producer,
                Commentary = antennaDTO.Commentary,
            };
        }
    }
}
