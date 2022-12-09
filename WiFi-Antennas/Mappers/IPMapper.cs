using System;
using System.Net;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.Models;

namespace WiFi_Antennas.Mappers
{
    public static class IPMapper
    {
        public static IPDTO ToDTO(this IPViewModel ip)
        {
            IPDTO iPDTO = new IPDTO();
            iPDTO.Sections.Add(ip.Section1);
            iPDTO.Sections.Add(ip.Section2);
            iPDTO.Sections.Add(ip.Section3);
            iPDTO.Sections.Add(ip.Section4);
            return iPDTO;
        }

        public static IPViewModel ToToViewModel(this IPDTO ipDTO)
        {
            IPViewModel ip = new IPViewModel();
            ip.Section1 = ipDTO.Sections[0];
            ip.Section2 = ipDTO.Sections[1];
            ip.Section3 = ipDTO.Sections[2];
            ip.Section4 = ipDTO.Sections[3];
            ip.StringIP = ipDTO.StringIP;
            return ip;
        }
    }
}
