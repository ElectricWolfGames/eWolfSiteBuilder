using eWolfBootstrap.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace eWolfSiteBuilder.SiteDetails.Helpers
{
    public static class PageDetailsHelper
    {
        public static string CreateSupport(string data)
        {
            // TODO: Do we use Contact@electricWolf.co.uk or Wolf@electricwolf.co.uk
            HTMLBuilder options = new HTMLBuilder();
            options.NewLine();
            options.TextBoldText("If you need any more help please email me at ", "Wolf@electricwolf.co.uk", "");
            options.NewLine();
            options.NewLine();
            return options.Output();
        }

        public static List<PreviewItem> GetPreviewItem()
        {
            IEnumerable<IUnityList> updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                                              where t.GetInterfaces().Contains(typeof(IUnityList))
                                                    && t.GetConstructor(Type.EmptyTypes) != null
                                              select Activator.CreateInstance(t) as IUnityList;

            updates = updates.OrderBy(x => x.UnityListOrder);

            return updates.Select(x => x.GetHomePagePreview()).ToList();
        }

        public static string TwoImages(string imageA, string imageB)
        {
            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight(imageA, 75);
            right.ImageLeft(imageB, 75);

            return options.Output();
        }
    }
}