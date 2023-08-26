using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
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

        internal static string CreateAddLinkedPackages(PageDetails pageDetails)
        {
            if (pageDetails.LinkedPackages.Length == 0)
                return string.Empty;

            HTMLBuilder builder = new HTMLBuilder();
            builder.Text("</br>");
            builder.Text("<div class='row'>");
            List<PreviewItem> items = PageDetailsHelper.GetPreviewItem();
            foreach (var item in items)
            {
                if (item.Name == pageDetails.DisplayTitle)
                    continue;

                if (pageDetails.LinkedPackages.Contains(item.Name))
                {
                    builder.Text("<div class='col-lg-4 col-md-6' >");
                    builder.Text($"<img src='../../{item.ImagePath}' class='img-fluid' alt=''>");
                    builder.Text($"<h4><a href='../../{item.HRef}'>{item.Name}</a></h4>");
                    builder.Text($"<p>{item.Description}</p>");
                    builder.Text("</div>");
                }
            }

            builder.Text("</div>");
            return builder.Output();

        }
    }
}