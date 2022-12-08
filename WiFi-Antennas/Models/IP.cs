using System.ComponentModel.DataAnnotations;
using WiFi_Antennas.ValidationAttributes;

namespace WiFi_Antennas.Models
{
    public class IP
    {
        public string? StringIP { get; set; }

        //[Required]
        //[IpValidation(ErrorMessage = "Значение полей IP адреса должны быть в пределах от 0 до 255")]
        public List<byte> Sections { get; set; } = new List<byte>(4);

    }
}
