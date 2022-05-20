using eWolfBootstrap.Enums;
using System.Collections.Generic;

namespace eWolfSiteBuilder.zOLD.Headers
{
    public class HeaderBase
    {
        public string Author { get; set; } = "Electric Wolf";
        public string Description { get; set; }
        public List<BootstrapOptions> ExtraIncludes { get; set; } = new List<BootstrapOptions>();
        public List<string> Keywords { get; set; }
        public string Title { get; set; }
    }
}