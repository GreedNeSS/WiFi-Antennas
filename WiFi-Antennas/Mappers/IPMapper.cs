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
                Ip = ip.Ip,
            };
        }

        public static IP ToToViewModel(this IPDTO ipDTO)
        {
            Console.WriteLine(ipDTO.Ip.Count);
            IP ip = new IP();
            ip.Ip = ipDTO.Ip;
            ip.StringIP = ipDTO.StringIP;
            return ip;
        }
    }
}
