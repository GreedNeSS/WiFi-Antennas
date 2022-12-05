using Microsoft.EntityFrameworkCore.Infrastructure;
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
        public static Antenna ToEntity(this AntennaDTO antennaDTO)
        {
            string address = "";

            if (string.IsNullOrEmpty(antennaDTO.Address.City))
            {
                address += $"г. {antennaDTO.Address.City}, ";
            }

            address += $"ул. {antennaDTO.Address.Street}, ";
            address += $"д. {antennaDTO.Address.Street}";

            if (string.IsNullOrEmpty(antennaDTO.Address.Building))
            {
                address += $", к. {antennaDTO.Address.Building}";
            }
            if (string.IsNullOrEmpty(antennaDTO.Address.Entrance))
            {
                address += $", п. {antennaDTO.Address.Entrance}";
            }

            return new Antenna()
            {
                Address = address,
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
            AddressDTO address = new AddressDTO();
            address.ShortAddress = antenna.Address;
            string[] chanks = antenna.Address.Split(",");

            foreach (var item in chanks)
            {
                if (item.Contains("г."))
                {
                    address.City = 
                }
            }

            return new AntennaDTO
            {
                Address = address,
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
