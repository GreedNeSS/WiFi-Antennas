using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiFi_Antennas.DAL.Entities
{

    [Index("Address", IsUnique = true)]
    public class Antenna
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string? Address { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4)]
        public string? SSID { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 7)]
        public string? Ip { get; set; }
        public bool IsServer { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string? Login { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 8)]
        public string? Password { get; set; }
        public int ChannelWidth { get; set; } = 40;
        public int Channel { get; set; } = 1;
    }
}
