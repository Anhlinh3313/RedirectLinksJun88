using System;

namespace RedirectLinks.Models
{
    public class Background
    {
        public long Id { get; set; }
        public long LinkGroupId { get; set; }
        public string BackgroundImage { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public bool? IsShow { get; set; }
    }
}
