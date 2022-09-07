namespace WiFi_Antennas.Models
{
    public class PageViewModel
    {
        public int PageNumber { get; }
        public int TotalPages { get; }
        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;
        public bool HasFirstPage => PageNumber > 2;
        public bool HasFinalPage => (PageNumber + 1) < TotalPages;
        public bool HasStartSpace => PageNumber > 3;
        public bool HasLastSpace => (PageNumber + 2) < TotalPages;

        public PageViewModel(int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (decimal)pageSize);
        }
    }
}
