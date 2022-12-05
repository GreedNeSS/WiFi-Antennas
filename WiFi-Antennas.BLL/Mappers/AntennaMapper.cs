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

            if (!string.IsNullOrEmpty(antennaDTO.Address.City))
            {
                address += $"г. {antennaDTO.Address.City?.Trim()}, ";
            }

            address += $"ул. {antennaDTO.Address.Street?.Trim()}, ";
            address += $"д. {antennaDTO.Address.House?.Trim()}";

            if (!string.IsNullOrEmpty(antennaDTO.Address.Building))
            {
                address += $", к. {antennaDTO.Address.Building?.Trim()}";
            }
            if (!string.IsNullOrEmpty(antennaDTO.Address.Entrance))
            {
                address += $", п. {antennaDTO.Address.Entrance?.Trim()}";
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
                    address.City = item.Replace("г. ", "").Trim();
                }
                if (item.Contains("ул."))
                {
                    address.Street = item.Replace("ул. ", "").Trim();
                }
                if (item.Contains("д."))
                {
                    address.House = item.Replace("д. ", "").Trim();
                }
                if (item.Contains("к."))
                {
                    address.Building = item.Replace("к. ", "").Trim();
                }
                if (item.Contains("п."))
                {
                    address.Entrance = item.Replace("п. ", "").Trim();
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
