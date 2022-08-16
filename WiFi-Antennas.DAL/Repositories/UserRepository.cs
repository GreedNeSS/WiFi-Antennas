using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.DAL.EF;
using WiFi_Antennas.DAL.Entities;
using WiFi_Antennas.DAL.Interfaces;

namespace WiFi_Antennas.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private UserContext db;

        public UserRepository(UserContext context)
        {
            db = context;
        }

        public User? GetUser(string login, string password)
        {
            return db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }
    }
}
