﻿using System;
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
        public static Antenna ToEntity(this AntennaDTO antennaDTO)
        {
            return new Antenna()
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

        public static AntennaDTO ToDTO(this Antenna antenna)
        {
            return new AntennaDTO
            {
                Address = antenna.Address,
                Channel = antenna.Channel,
                ChannelWidth = antenna.ChannelWidth,
                Ip = antenna.Ip,
                IsServer = antenna.IsServer,
                Login = antenna.Login,
                AccessPointPassword = antenna.AccessPointPassword,
                HardwarePassword = antenna.HardwarePassword,
                SSID = antenna.SSID,
                Id = antenna.Id,
                Producer = antenna.Producer,
                Commentary = antenna.Commentary,
            };
        }
    }
}
