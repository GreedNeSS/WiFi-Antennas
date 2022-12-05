using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiFi_Antennas.BLL.DTO
{
    public class AddressDTO
    {
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? House { get; set; }
        public string? Building { get; set; }
        public string? Entrance { get; set; }
        public string? ShortAddress { get; set; }
    }
}
