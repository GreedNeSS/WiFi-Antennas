using System;
using System.ComponentModel.DataAnnotations;

namespace WiFi_Antennas.Models
{
    public class AntennaViewModel

    {
        public int Id { get; set; }
        public AddressViewModel Address { get; set; } = new AddressViewModel();

        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Длинна SSID должны составлять 4-10 символов")]
        public string? SSID { get; set; }

        public IPViewModel IP { get; set; } = new IPViewModel();
        public bool IsServer { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Длинна Login должны составлять 3-10 символов")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Длинна пароля должны составлять 8-15 символов")]
        public string? AccessPointPassword { get; set; }

        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Длинна пароля должны составлять 8-15 символов")]
        public string? HardwarePassword { get; set; }
        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        public int ChannelWidth { get; set; }
        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        public int Channel { get; set; }
        public string? Producer { get; set; }
        public string? Commentary { get; set; }
    }
}
