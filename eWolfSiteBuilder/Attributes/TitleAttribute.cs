using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWolfSiteBuilder.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class TitleAttribute : Attribute
    {
        public TitleAttribute(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
    }
}