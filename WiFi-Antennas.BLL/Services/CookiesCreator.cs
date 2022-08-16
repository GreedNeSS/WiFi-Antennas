using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.BLL.Interfaces;

namespace WiFi_Antennas.BLL.Services
{
    public class TokenCreator : ITokenCreator
    {
        public ClaimsPrincipal GetClaimsPrincipal(UserDTO userDTO)
        {
            var claims = new List<Claim> { new(ClaimTypes.Name, userDTO.Login!) };
            var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            return claimsPrincipal;
        }
    }
}
