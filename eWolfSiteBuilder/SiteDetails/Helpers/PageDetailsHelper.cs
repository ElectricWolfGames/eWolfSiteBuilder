using eWolfBootstrap.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace eWolfSiteBuilder.SiteDetails.Helpers
{
    public static class PageDetailsHelper
    {
        public static string AddSectionSupport(string data)
        {
            // DONE: Contact@electricWolf.co.uk and Wolf@electricwolf.co.uk are both working (2022/06/04)
            HTMLBuilder options = new HTMLBuilder();
            options.NewLine();
            options.TextBoldText("If you need any more help please email us at ", "Contact@electricWolf.co.uk", "");
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