using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace eWolfSiteBuilder._Site.Games.SpaceSalvager
{
    [PageTitle("SpaceSalvagerItems.html")]
    public class SpaceSalvagerItems : PageDetails
    {
        public SpaceSalvagerItems()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Space Salvager Items";
            MenuTitle = "Space Salvager Items";
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-4'>");

            WebPage.Append(CreateHero());
            WebPage.Append(SpaceSalvagerEmails.CreateLinks());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Items", AddSectionItems));
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

        private string AddSectionItems(string data)
        {
            string unity3dDllPath = "C:\\Unity3d\\SpaceSalvager\\SpaceSalvager_UD\\Library\\ScriptAssemblies\\Assembly-CSharp.dll";

            Assembly unityAssembly = Assembly.LoadFrom(unity3dDllPath);
            Type pickupEnum = unityAssembly.GetType("eWolf.SpaceSalvager.Enums.PickupItems");

            MemberInfo[] pickupObjects = pickupEnum.GetMembers(BindingFlags.Public | BindingFlags.Static);

            List<Pickup> pickups = new List<Pickup>();

            foreach (var pickupObject in pickupObjects)
            {
                var customAttributes = pickupObject.GetCustomAttributesData();

                Pickup pickup = new Pickup();

                pickup.Name = pickupObject.Name;
                foreach (var at in customAttributes)
                {
                    if (at.AttributeType.Name == typeof(DescriptionAttribute).Name)
                    {
                        pickup.Description = at.ConstructorArguments[0].ToString();
                    }
                    if (at.AttributeType.Name == typeof(TitleAttribute).Name)
                    {
                        pickup.Title = at.ConstructorArguments[0].ToString();
                    }
                }
                if (pickup.Title != null)
                {
                    pickups.Add(pickup);
                }
            }

            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            foreach (var p in pickups)
            {
                outer.InspectorDetails(p.Title, p.Description);
                outer.ImageCenter($"{p.Name}.PNG", 16);
            }

            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Space Salvager Items");
            return options.Output();
        }

        public class Pickup
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
        }
    }
}