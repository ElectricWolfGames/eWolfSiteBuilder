using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.DynamicVDUs
{
    [PageTitle("DynamicVDUs.html")]
    public class DynamicVDUs : PageDetails, IHomePagePreview, IUnityList
    {
        public DynamicVDUs()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Animated Dynamic VUD";
            MenuTitle = "Dynamic VUD";
        }

        public int UnityListOrder { get; set; } = 15;

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");

            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Example", CreateExample));
            items.Add(new HTMLIndexedItems("Download", CreateDownload));

            items.Add(new HTMLIndexedItems("Options", CreateOptions));
            items.Add(new HTMLIndexedItems("Set-up", CreateSetUp));
            items.Add(new HTMLIndexedItems("Update Effects In Game", CreateUsingInGame));

            items.Add(new HTMLIndexedItems("Using Sprites", CreateSprite));
            items.Add(new HTMLIndexedItems("More Examples", CreateMoreExample));
            items.Add(new HTMLIndexedItems("Support", PageDetailsHelper.AddSectionSupport));
            HTMLBuilder options = new HTMLBuilder();

            options.CreateIndex(items);
            WebPage.Append(options.Output());

            options = new HTMLBuilder();
            options.CreateIndexItems(items);
            WebPage.Append(options.Output());
            WebPage.Append("</div>");

            WebPage.CloseAllsDiv();

            WebPage.EndBody();
            WebPage.Output();
        }

        public PreviewItem GetHomePagePreview()
        {
            PreviewItem pi = new PreviewItem()
            {
                HRef = $"{WebPage.HtmlPath}\\{WebPage.HtmlTitle}",
                Name = DisplayTitle,
                PreviewItemType = PreviewItemType.Models,
                ImagePath = @$"{WebPage.HtmlPath}\images\DynamicVDU_Logo.png",
                Description = "Dynamic VDU is a collection of animated dynamic monitors, That will show a range of alertness form no alert - all is green to full alert - were most is red"
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Unity3DLink(Unity3DSetting.DynamicVDU);
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateExample(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.YouTubeLinkBig("0eZLgcZVWQY");

            return options.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Dynamic VDU is a collection of animated dynamic monitors, That will show a range of alertness form no alert - all is green to full alert - were most is red");
            return options.Output();
        }

        private string CreateMoreExample(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();

            options.ImageCenter("Effect_Part1.png", 45);

            options.NewLine();
            options.ImageCenter("Effect_Part2.png", 45);

            options.NewLine();

            options.YouTubeLinkBig("tUED5Jngmow");

            return options.Output();
        }

        private string CreateOptions(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text(@"Any number of effects can be placed on to one texture.");
            options.NewLine();
            options.NewLine();
            options.Image("CombinedEffects.png", 45);

            options.NewLine();
            options.NewLine();
            options.Text(@"The Colours for the effects are also custom definable");
            options.NewLine();
            options.NewLine();
            options.Image("Inspector.png", 35);

            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateSetUp(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text("Follow the steps below to use in any game.");
            options.NewLine();
            options.NewLine();
            options.Text(@"Select the base prefab: From the folder Assets\eWolf\eWolfDynamicVDU\Prefabs\ Select the size of the texture you wish to use (this can be changed any time later) Drag it in to the scene and place it where you need it.");
            options.NewLine();
            options.NewLine();
            options.Text("Define the effect: In the Inspector, use the Effect drop download list to select the effect from the list.");
            options.NewLine();
            options.NewLine();
            options.Text("Define the size: Use the Rect setting to define the size as a percentage of the image. a width of 1 is the full width of the texture, 0.5 is half the width. And you can tick Apply Border if you want to have a border around the effect.");
            options.NewLine();
            options.NewLine();
            options.Text("Extra Effects: If you wish to have more then one effect per texture, Increase the Size and repeat the previous two steps. However many time you like.");
            options.NewLine();
            options.NewLine();
            options.Text("Colour and speed: You can update the colours used for the textures. You can change the speed of the effect by updating Interval");
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateSprite(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenterLeft();
            outer.NewLine();

            outer.Text(@"With the latest version, Dynamic VDU now allows you to use this effect on a sprite");
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText(@"Demo scene has been added as ", " 'ShowSprites'", "");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenterLeft();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            right.ImageLeft("InspectorSprite.png", 75);
            left.Text(@"The Sprite render need to use the Sprite that matches the Monitor Sprite Textures Setting");
            left.NewLine();
            left.NewLine();
            left.Text(@"As the Monitor Sprite will be updating the texture set.");

            outer.Text(options.Output());

            return outer.Output();
        }

        private string CreateUsingInGame(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text(@"Updating the effect at runtime");
            options.NewLine();
            options.NewLine();

            options.Text(@"You can change the Alert value at run time by using the"); options.NewLine();
            options.Text(@"go.SendMessage(MonitorDefines.UpdateAlertMessage, newAlert);"); options.NewLine();
            options.Text(@"Where go is the monitor object.");

            options.NewLine();
            options.NewLine();
            options.Text("You can pause an un-pause the effect with"); options.NewLine();
            options.Text("go.SendMessage(MonitorDefines.SetPauseMessage, true);"); options.NewLine();
            options.Text("And"); options.NewLine();
            options.Text("go.SendMessage(MonitorDefines.SetPauseMessage, false);"); options.NewLine();
            options.Text("Where go is the monitor object.");
            options.NewLine();
            options.NewLine();

            options.TextBoldText("You can find ", "UpdateAlerts.cs", " as an example of the above code.");

            options.EndTextCenter();

            return options.Output();
        }
    }
}