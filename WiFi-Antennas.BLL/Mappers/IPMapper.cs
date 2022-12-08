using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiFi_Antennas.BLL.DTO;
using WiFi_Antennas.DAL.Entities;

namespace WiFi_Antennas.BLL.Mappers
{
    public static class IPMapper
    {
        public static IPDTO ToIpDTO(this Antenna antenna)
        {
            string ip = antenna.Ip;
            IPDTO dto = new IPDTO();
            dto.StringIP = ip;

            string[] strings = ip.Split(".");

            for (int i = 0; i < strings.Length; i++)
            {
                try
                {
                    byte b = byte.Parse(strings[i]);
                    dto.Ip.Add(b);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return dto;
        }

        public static string IpToString(this IPDTO iPDTO)
        {
            string ip = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                if (iPDTO.Ip[i] > 99)
                {
                    ip += iPDTO.Ip[i].ToString();
                }
                else if (iPDTO.Ip[i] > 9)
                {
                    ip += "0" + iPDTO.Ip[i].ToString();
                }
                else
                {
                    ip += "00" + iPDTO.Ip[i].ToString();
                }

                if (i != 3)
                {
                    ip += ".";
                }
            }

            return ip;
        }
    }
}
