namespace WiFi_Antennas.Models
{
    public class IndexViewModel
    {
        public List<AntennaViewModel> Antennas { get; set; }
        public FilterViewModel Filter { get; set; }
        public SortViewModel Sort { get; set; }
        public PageViewModel Pagination { get; set; }

        public IndexViewModel(List<AntennaViewModel> antennas, FilterViewModel filter, SortViewModel sort, PageViewModel pagination)
        {
            Antennas = antennas;
            Filter = filter;
            Sort = sort;
            Pagination = pagination;
        }
    }
}
