using System;
using System.ComponentModel.DataAnnotations;

namespace WiFi_Antennas.Models
{
    public class AntennaViewModel

    {
        public int Id { get; set; }
        public Address Address { get; set; } = new Address();

        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Длинна SSID должны составлять 4-10 символов")]
        public string? SSID { get; set; }

        public string? StringIP { get; set; }
        [Required(ErrorMessage = "Поле 1 обязательно к заполнению!")]
        [Range(0, 255, ErrorMessage = "Значение первого поля IP адреса должно быть в пределах от 0 до 255")]
        public byte Ip1 { get; set; }
        [Required(ErrorMessage = "Поле 2 обязательно к заполнению!")]
        [Range(0, 255, ErrorMessage = "Значение второго поля IP адреса должно быть в пределах от 0 до 255")]
        public byte Ip2 { get; set; }
        [Required(ErrorMessage = "Поле 3 обязательно к заполнению!")]
        [Range(0, 255, ErrorMessage = "Значение третьего поля IP адреса должно быть в пределах от 0 до 255")]
        public byte Ip3 { get; set; }
        [Required(ErrorMessage = "Поле 4 обязательно к заполнению!")]
        [Range(0, 255, ErrorMessage = "Значение четвертого поля IP адреса должно быть в пределах от 0 до 255")]
        public byte Ip4 { get; set; }
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
