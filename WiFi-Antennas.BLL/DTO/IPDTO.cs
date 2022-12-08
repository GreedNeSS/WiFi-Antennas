using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiFi_Antennas.BLL.DTO
{
    public class IPDTO
    {
        public string? StringIP { get; set; }
        public List<byte> Sections { get; set; } = new List<byte>(4);
    }
}
