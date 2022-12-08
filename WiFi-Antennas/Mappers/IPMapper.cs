using System;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.Models;

namespace WiFi_Antennas.Mappers
{
    public static class IPMapper
    {
        public static IPDTO ToDTO(this IPViewModel ip)
        {
            return new IPDTO
            {
                Sections = ip.Sections,
            };
        }

        public static IPViewModel ToToViewModel(this IPDTO ipDTO)
        {
            Console.WriteLine(ipDTO.Sections.Count);
            IPViewModel ip = new IPViewModel();
            ip.Sections = ipDTO.Sections;
            ip.StringIP = ipDTO.StringIP;
            return ip;
        }
    }
}
