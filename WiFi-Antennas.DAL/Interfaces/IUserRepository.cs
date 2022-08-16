using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.DAL.Entities;

namespace WiFi_Antennas.DAL.Interfaces
{
    public interface IUserRepository
    {
        User? GetUser(string login, string password);
    }
}
