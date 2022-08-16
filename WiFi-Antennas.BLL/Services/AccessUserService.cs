using WiFi_Antennas.DAL.Entities;
using WiFi_Antennas.DAL.Interfaces;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.BLL.Interfaces;

namespace WiFi_Antennas.BLL.Services
{
    public class AccessUserService : IAccessUserService
    {
        IUserRepository _repository;

        public AccessUserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public bool IsAllowed(UserDTO userDTO)
        {
            User? user = _repository.GetUser(userDTO.Login ?? string.Empty, userDTO.Password ?? string.Empty);

            if (user == null)
            {
                return false;
            }

            return true;
        }
    }
}
