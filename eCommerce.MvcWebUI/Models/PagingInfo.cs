namespace eCommerce.MvcWebUI.Models
{
    public class PagingInfo
    {
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int CurrentCategory { get; set; }
    }
}