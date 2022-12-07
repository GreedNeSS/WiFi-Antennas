using System.ComponentModel.DataAnnotations;

namespace WiFi_Antennas.Models
{
    public class IP
    {
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
    }
}
