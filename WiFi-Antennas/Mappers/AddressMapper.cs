using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.Models;

namespace WiFi_Antennas.Mappers
{
    public static class AddressMapper
    {
        public static AddressDTO ToDTO(this AddressViewModel addressViewModel)
        {
            AddressDTO addressDTO = new AddressDTO();

            addressDTO.City = addressViewModel.City;
            addressDTO.Street = addressViewModel.Street;
            addressDTO.House = addressViewModel.House;
            addressDTO.Building = addressViewModel.Building;
            addressDTO.Entrance = addressViewModel.Entrance;

            return addressDTO;
        }
        public static AddressViewModel ToViewModel(this AddressDTO addressDTO)
        {
            AddressViewModel addressViewModel = new AddressViewModel();

            addressViewModel.City = addressDTO.City;
            addressViewModel.Street = addressDTO.Street;
            addressViewModel.House = addressDTO.House;
            addressViewModel.Building = addressDTO.Building;
            addressViewModel.Entrance = addressDTO.Entrance;
            addressViewModel.ShortAddress = addressDTO.ShortAddress;

            return addressViewModel;
        }
    }
}
