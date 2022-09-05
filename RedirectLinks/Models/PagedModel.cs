
namespace RedirectLinks.Models
{
    public class PagedModel
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalRecord { get; set; }
        public int TotalPage { get; set; }
        public dynamic Data { get; set; }
    }
}
