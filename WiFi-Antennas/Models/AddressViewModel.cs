using System.ComponentModel.DataAnnotations;

namespace WiFi_Antennas.Models
{
    public class AddressViewModel
    {
        public string? City { get; set; }
        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Длинна названия улицы должны составлять 4-30 символов")]
        public string? Street { get; set; }
        [Required(ErrorMessage = "Поле обязательно к заполнению!")]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "Поле должно составлять 1-5 символов")]
        public string? House { get; set; }
        public string? Building { get; set; }
        public string? Entrance { get; set; }
        public string? ShortAddress { get; set; }
    }
}
