namespace WiFi_Antennas.Models
{
    public class PageViewModel
    {
        public int PageNumber { get; }
        public int TotalPages { get; }
        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;
        public bool HasFinalPage => (PageNumber + 1) < TotalPages;
        public bool HasSpace => (PageNumber + 2) < TotalPages;

        public PageViewModel(int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (decimal)pageSize);
        }
    }
}
