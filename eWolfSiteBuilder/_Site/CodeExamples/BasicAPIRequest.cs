using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.CodeExamples
{
    [PageTitle("BasicAPIRequest.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class BasicAPIRequest : PageDetailsWolfSite
    {
        public BasicAPIRequest()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "API: Basic API request";
            MenuTitle = "API: Basic API request";
            DontShowNavigation = true;
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");
            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();
            items.Add(new HTMLIndexedItems("Overview", CreateOverview));
            items.Add(new HTMLIndexedItems("Downloads", CreateDownloadFiles));
            items.Add(new HTMLIndexedItems("Files", CreateExmapleFiles));

            AddIndexItemsWithSideBar(items);

            WebPage.EndBody();
            WebPage.Output();
        }

        private string CreateOverview(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("Here is a Basic API (application programming interface) requst");
            options.NewLine();
            options.NewLine();
            options.Text("In this example I used the Exchange Rate API");
            options.NewLine();
            options.Text("<a href='https://www.exchangerate-api.com/docs/c-sharp-currency-api'>here</a>");

            options.NewLine();
            options.NewLine();
            options.YouTubeLinkBig("oDzBU4_tG-k");

            options.EndTextCenter();
            return options.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            string heroText = $"";
            options.Jumbotron(DisplayTitle, heroText);
            return options.Output();
        }

        private string CreateDownloadFiles(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("You can download the the files..");
            options.NewLine();

            options.Text("<a href=\"03 BasicAPIRequest/Data/ExchangerateAPIS.cs\" download>ExchangerateAPIS.cs</a>");
            options.NewLine();
            options.NewLine();
            options.Text("<a href=\"03 BasicAPIRequest/Data/ExchangerateRateResponse.cs\" download>ExchangerateRateResponse.cs</a>");
            options.NewLine();
            options.NewLine();

            options.EndTextCenter();
            return options.Output();
        }
        private string CreateExmapleFiles(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("ExchangerateAPIS.cs");
            options.NewLine();
            options.CodeText("using APITests;\r\nusing APITests.Model;\r\nusing Newtonsoft.Json;\r\n\r\n// Demo API request\r\n// https://www.exchangerate-api.com/docs/c-sharp-currency-api\r\n\r\nnamespace APIs\r\n{\r\n    public class ExchangeEateAPIS\r\n    {\r\n        public void MakeRequest()\r\n        {\r\n            string urlString = $\"https://v6.exchangerate-api.com/v6/{Consts.APIKey}/latest/USD\";\r\n            using (var webClient = new System.Net.WebClient())\r\n            {\r\n                var json = webClient.DownloadString(urlString);\r\n                var exchangerateRates = JsonConvert.DeserializeObject<ExchangerateRateResponse>(json);\r\n\r\n                Console.WriteLine($\"BaseCode: {exchangerateRates.base_code}\");\r\n                Console.WriteLine($\"GBP: {exchangerateRates.conversion_rates.GBP}\");\r\n                Console.WriteLine($\"EUR: {exchangerateRates.conversion_rates.EUR}\");\r\n            }\r\n        }\r\n    }\r\n}");
            options.NewLine();
            options.NewLine();
            

            options.EndTextCenter();
            return options.Output();
        }
    }
}