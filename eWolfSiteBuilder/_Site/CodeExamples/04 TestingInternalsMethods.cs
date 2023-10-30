using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.CodeExamples
{
    [PageTitle("TestingInternalsMethods.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class TestingInternalsMethods : PageDetailsWolfSite
    {
        public TestingInternalsMethods()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Testing Internals Methods";
            MenuTitle = "Testing Internals Methods";
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

        private string CreateDownloadFiles(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("You can download the the files..");
            options.NewLine();

            options.Text("<a href=\"04 TestingInternalsMethods/Data/Calculator.cs\" download>Calculator.cs</a>");
            options.NewLine();
            options.NewLine();
            options.Text("<a href=\"04 TestingInternalsMethods/Data/CalculatorTests.cs\" download>CalculatorTests.cs</a>");
            options.NewLine();
            options.NewLine();

            options.EndTextCenter();
            return options.Output();
        }

        private string CreateExmapleFiles(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("Calculator.cs");
            options.NewLine();
            options.CodeText("using System.Runtime.CompilerServices;\r\n\r\n[assembly: InternalsVisibleTo(\"Code.UnitTest\")]\r\n\r\nnamespace Code\r\n{\r\n    public class Calculator\r\n    {\r\n        public string ProcessCalculation(string line)\r\n        {\r\n            string[] parts = line.Split(new[] { '+', '-' });\r\n\r\n            float valueA = float.Parse(parts[0]);\r\n            float valueB = float.Parse(parts[1]);\r\n\r\n            if (line.Contains('+'))\r\n                return Add(valueA, valueB).ToString();\r\n\r\n            if (line.Contains('-'))\r\n                return Sub(valueA, valueB).ToString();\r\n\r\n            return \"ERROR:\";\r\n        }\r\n\r\n        internal float Add(float a, float b)\r\n        {\r\n            return a + b;\r\n        }\r\n\r\n        internal float Sub(float a, float b)\r\n        {\r\n            return a - b;\r\n        }\r\n    }\r\n}");
            options.NewLine();
            options.NewLine();

            options.Text("CalculatorTests.cs");
            options.NewLine();
            options.CodeText("namespace Code.UnitTest\r\n{\r\n    public class Tests\r\n    {\r\n        [TestCase(\"1+2\", \"3\")]\r\n        [TestCase(\"123-23\", \"100\")]\r\n        [TestCase(\"1-2\", \"-1\")]\r\n        public void ShouldAddNumbers(string process, string expectedResult)\r\n        {\r\n            var code = new Calculator();\r\n            var result = code.ProcessCalculation(process);\r\n\r\n            Assert.That(result, Is.EqualTo(expectedResult));\r\n        }\r\n\r\n        [Test]\r\n        public void ShouldAddReturnAddedValues()\r\n        {\r\n            var code = new Calculator();\r\n            var result = code.Add(1, 1);\r\n\r\n            Assert.That(result, Is.EqualTo(2));\r\n        }\r\n\r\n        [Test]\r\n        public void ShouldSubReturnSubValues()\r\n        {\r\n            var code = new Calculator();\r\n            var result = code.Sub(1, 1);\r\n\r\n            Assert.That(result, Is.EqualTo(0));\r\n        }\r\n    }\r\n}");
            options.NewLine();
            options.NewLine();

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

        private string CreateOverview(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("How to Unit test Internals Methods");
            options.NewLine();
            options.NewLine();

            options.YouTubeLinkBig("IgTyOo473zw");

            options.EndTextCenter();
            return options.Output();
        }
    }
}