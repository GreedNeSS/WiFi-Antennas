using System;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.Models;

namespace WiFi_Antennas.Mappers
{
    public static class AntennaMapper
    {
        public static AntennaDTO ToDTO(this AntennaViewModel antennaView)
        {
            AddressDTO addressDTO = new AddressDTO();

            addressDTO.City = antennaView.Address.City;
            addressDTO.Street = antennaView.Address.Street;
            addressDTO.House = antennaView.Address.House;
            addressDTO.Building = antennaView.Address.Building;
            addressDTO.Entrance = antennaView.Address.Entrance;

            return new AntennaDTO()
            {
                Address = addressDTO,
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
            Address address = new Address();

            address.City = antennaDTO.Address.City;
            address.Street = antennaDTO.Address.Street;
            address.House = antennaDTO.Address.House;
            address.Building = antennaDTO.Address.Building;
            address.Entrance = antennaDTO.Address.Entrance;
            address.ShortAddress = antennaDTO.Address.ShortAddress;

            return new AntennaViewModel()
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
    }
}
