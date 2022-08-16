using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.BLL.DTO;

namespace WiFi_Antennas.BLL.Interfaces
{
    public interface IAccessUserService
    {
        bool IsAllowed(UserDTO userDTO);
    }
}
