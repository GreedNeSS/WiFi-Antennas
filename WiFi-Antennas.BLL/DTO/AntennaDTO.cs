using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiFi_Antennas.BLL.DTO
{
    public class AntennaDTO
    {
        public int Id { get; set; }
        public AddressDTO Address { get; set; } = new AddressDTO();
        public string? SSID { get; set; }
        public string? Ip { get; set; }
        public bool IsServer { get; set; }
        public string? Login { get; set; }
        public string? AccessPointPassword { get; set; }
        public string? HardwarePassword { get; set; }
        public int ChannelWidth { get; set; }
        public int Channel { get; set; }
        public string? Producer { get; set; }
        public string? Commentary { get; set; }
    }
}
