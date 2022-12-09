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
        public List<int> Sections { get; set; } = new List<int>(4);
    }
}
