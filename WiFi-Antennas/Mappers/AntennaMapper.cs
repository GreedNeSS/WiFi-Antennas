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
                Password = antennaView.Password,
                SSID = antennaView.SSID,
                Id = antennaView.Id,
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
                Password = antennaDTO.Password,
                SSID = antennaDTO.SSID,
                Id = antennaDTO.Id,
            };
        }
    }
}
