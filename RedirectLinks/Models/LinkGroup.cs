using System;

namespace RedirectLinks.Models
{
    public class LinkGroup
    {
        public long Id { get; set; }
        public string LinkGroupName { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
