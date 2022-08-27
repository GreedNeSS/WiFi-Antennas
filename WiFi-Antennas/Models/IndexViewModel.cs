namespace WiFi_Antennas.Models
{
    public class IndexViewModel
    {
        public List<AntennaViewModel> Antennas { get; set; }

        public IndexViewModel(List<AntennaViewModel> antennas)
        {
            Antennas = antennas;
        }
    }
}
