using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.DAL.Entities;

namespace WiFi_Antennas.BLL.Mappers
{
    public static class AddressMapper
    {
        public static string AddressToString(this AddressDTO addressDTO)
        {
            string address = "";

            if (!string.IsNullOrEmpty(addressDTO.City))
            {
                address += $"г. {addressDTO.City?.Trim()}, ";
            }

            address += $"ул. {addressDTO.Street?.Trim()}, ";
            address += $"д. {addressDTO.House?.Trim()}";

            if (!string.IsNullOrEmpty(addressDTO.Building))
            {
                address += $", к. {addressDTO.Building?.Trim()}";
            }
            if (!string.IsNullOrEmpty(addressDTO.Entrance))
            {
                address += $", п. {addressDTO.Entrance?.Trim()}";
            }

            return address;
        }

        public static AddressDTO StringToAddressDTO(this Antenna antenna)
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

            return address;
        }
    }
}
