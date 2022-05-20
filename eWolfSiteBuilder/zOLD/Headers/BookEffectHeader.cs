using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace eWolfSiteBuilder.zOLD.Headers
{
    public class BookEffectHeader : HeaderBase, IPageHeader
    {
        public BookEffectHeader()
        {
            Title = "BookEffect";
            Keywords = new List<string>
            {
            };
            Description = "BookEffect";
        }
    }
}