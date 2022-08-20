using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.DAL.Entities;

namespace WiFi_Antennas.BLL.Mappers
{
    public static class AntennaMapper
    {
        public static Antenna MyMethod(this AntennaDTO antennaDTO)
        {
            return new Antenna()
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
