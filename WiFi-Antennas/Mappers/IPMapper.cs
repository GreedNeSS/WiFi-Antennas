using System;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.Models;

namespace WiFi_Antennas.Mappers
{
    public static class IPMapper
    {
        public static IPDTO ToDTO(this IP ip)
        {
            return new IPDTO
            {
                Sections = ip.Sections,
            };
        }

        public static IP ToToViewModel(this IPDTO ipDTO)
        {
            Console.WriteLine(ipDTO.Sections.Count);
            IP ip = new IP();
            ip.Sections = ipDTO.Sections;
            ip.StringIP = ipDTO.StringIP;
            return ip;
        }
    }
}
