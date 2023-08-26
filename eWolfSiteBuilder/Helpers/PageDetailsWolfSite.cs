using eWolfBootstrap.SiteBuilder;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWolfSiteBuilder.Helpers
{
    public abstract class PageDetailsWolfSite : PageDetails
    {
        public string CreateAddLinkedPackages(string data)
        {
            return PageDetailsHelper.CreateAddLinkedPackages(this);
        }
    }
}
