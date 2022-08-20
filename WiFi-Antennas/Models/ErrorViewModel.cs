namespace WiFi_Antennas.Models
{
    public class ErrorViewModel
    {
        public string? ErrorMessage { get; protected set; }
        public string? InvalidProp { get; protected set; }

        public ErrorViewModel(string errorMessage, string? invalidProp = null)
        {
            ErrorMessage = errorMessage;
            InvalidProp = invalidProp;
        }
    }
}
