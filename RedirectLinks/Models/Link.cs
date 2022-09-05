using System;

namespace RedirectLinks.Models
{
    public class Link
    {
        public long Id { get; set; }
        public long LinkGroupId { get; set; }
        public string Url { get; set; }
        public int LinkOrder { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
