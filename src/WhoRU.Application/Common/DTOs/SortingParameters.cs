namespace WhoRU.Application.Common.DTOs
{
    public class SortingParameters
    {
        public string? SortBy { get; set; }
        public bool IsDescending { get; set; } = false;

        public SortingParameters() { }

        public SortingParameters(string? sortBy, bool isDescending)
        {
            SortBy = sortBy;
            IsDescending = isDescending;
        }
    }
}
