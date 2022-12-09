using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WiFi_Antennas.Models
{
    public class IPViewModel
    {
        public string? StringIP { get; set; }

        [Required(ErrorMessage = "Поле IP 1 обязательно к заполнению!")]
        [Range(0, 255, ErrorMessage = "Число в поле IP 1 должно быть в пределах от 0 до 255!")]
        public int Section1 { get; set; }

        [Required(ErrorMessage = "Поле IP 2 обязательно к заполнению!")]
        [Range(0, 255, ErrorMessage = "Число в поле IP 2 должно быть в пределах от 0 до 255!")]
        public int Section2 { get; set; }

        [Required(ErrorMessage = "Поле IP 3 обязательно к заполнению!")]
        [Range(0, 255, ErrorMessage = "Число в поле IP 3 должно быть в пределах от 0 до 255!")]
        public int Section3 { get; set; }

        [Required(ErrorMessage = "Поле IP 4 обязательно к заполнению!")]
        [Range(0, 255, ErrorMessage = "Число в поле IP 4 должно быть в пределах от 0 до 255!")]
        public int Section4 { get; set; }
    }
}
