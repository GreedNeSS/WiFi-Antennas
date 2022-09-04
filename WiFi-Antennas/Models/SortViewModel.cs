namespace WiFi_Antennas.Models
{
    public class SortViewModel
    {
        public SortStateViewModel IpSort { get; set; }
        public SortStateViewModel SSIDSort { get; set; }
        public SortStateViewModel AddressSort { get; set; }
        public SortStateViewModel Current { get; set; }
        public bool Up { get; set; }

        public SortViewModel(SortStateViewModel sortOrder)
        {
            IpSort = SortStateViewModel.IpAsc;
            SSIDSort = SortStateViewModel.SSIDAsc;
            AddressSort = SortStateViewModel.AddressAsc;
            Up = sortOrder != SortStateViewModel.IpDesc &&
                sortOrder != SortStateViewModel.SSIDDesc &&
                sortOrder != SortStateViewModel.AddressDesc;
            Current = sortOrder;

            switch (sortOrder)
            {
                case SortStateViewModel.IpDesc:
                    IpSort = SortStateViewModel.IpAsc;
                    break;
                case SortStateViewModel.AddressAsc:
                    AddressSort = SortStateViewModel.AddressDesc;
                    break;
                case SortStateViewModel.AddressDesc:
                    AddressSort = SortStateViewModel.AddressAsc;
                    break;
                case SortStateViewModel.SSIDAsc:
                    SSIDSort = SortStateViewModel.SSIDDesc;
                    break;
                case SortStateViewModel.SSIDDesc:
                    SSIDSort = SortStateViewModel.SSIDAsc;
                    break;
                default:
                    IpSort = SortStateViewModel.IpDesc;
                    break;
            }
        }
    }
}
