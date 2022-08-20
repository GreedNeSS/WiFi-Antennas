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
    }
}
