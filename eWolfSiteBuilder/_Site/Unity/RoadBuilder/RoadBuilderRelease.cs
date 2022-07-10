using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.RoadBuilder
{
    [PageTitle("RoadBuilderRelease.html")]
    public class RoadBuilderRelease : PageDetails
    {
        public RoadBuilderRelease()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Road Builder Release";
            MenuTitle = "Road Builder Release";
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-4'>");

            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            HTMLBuilder options = new HTMLBuilder();
            options.PageLink("You can find the full documentation for Road Builder", "here", "RoadBuilder.html");
            options.NewLine();
            WebPage.Append(options.Output());

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Release Details", CreateReleaseDetails));
            items.Add(new HTMLIndexedItems("Support", PageDetailsHelper.AddSectionSupport));

            options = new HTMLBuilder();

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

        private static string CreateDownload(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"This package has all you need to create 7 different road types from normal (with and with-out pavement), grass, sandy, race track and even a rail track. And you can add more road textures/materials as you need. You don't need any programming skills to create amazing looking roads.");
            outer.NewLine();
            outer.NewLine();
            outer.PageLink("To see the full documentation", "Road builder", "RoadBuilder.html");
            outer.NewLine();
            outer.NewLine();

            outer.Unity3DLink(Unity3DSetting.RoadBuilder);
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.JumbotronImage(DisplayTitle,
                    "Road Builder Lets you create non-linear roads easily by using a network of nodes. With easy to use buttons to extrude, join, insert nodes and create mesh. Building new roads has never been so easy.",
                    "RoadBuilderLogo.png", 35);
            return outer.Output();
        }

        private string CreateReleaseDetails(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Bold("Version: 1.0 (Oct 18, 2016)");
            outer.NewLine();
            outer.Text("All main features (Initial release)");
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 1.1 (Jan 25, 2017)");
            outer.NewLine();
            outer.Text("Add the option to Override Cross section details per node");
            outer.NewLine();
            outer.Text("When you create a 'Start a new road' it will automatic selects the newly created road.");
            outer.NewLine();
            outer.Text("[Bug Fixed] Added Unity 5.5 compatible code for mesh optimization");
            outer.NewLine();
            outer.Text("[Bug Fixed] Extrude Road would something lock-up unity. This has been fixed");
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 1.2 (Feb 6, 2017)");
            outer.NewLine();
            outer.Text("Add the option to Override material details per node");
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 1.3 (Mar 9 2017)");
            outer.NewLine();
            outer.Text("Fix curves where the nodes are close together.");
            outer.NewLine();
            outer.Text("Fixed a bug in the RoadJunctionOrder where it's added the same angle more then once");
            outer.NewLine();
            outer.Text("Changed the name of the 'Insert new node' to 'Insert node between selected nodes'");
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 1.4 (May 18th 2017)");
            outer.NewLine();
            outer.PageLink("Full release notes for 1.4 can be", "found Here", "RoadBuilderCurves.html");
            outer.NewLine();
            outer.Text("Added Rounded inner corner for CrossRoads and Junctions");
            outer.NewLine();
            outer.Text("Extended the texture used for the roads to allow more details for CrossRoads and Junctions");
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 1.5 (June 13th 2017)");
            outer.NewLine();
            outer.Text("Update the mesh creation to work with baking lights on the road");
            outer.NewLine();
            outer.Text("Updated pre node option to work better with random textures options");
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 2.0 (July 24th 2017)");
            outer.NewLine();
            outer.PageLink("Full release notes for 1.4 can be", "found Here", "RoadBuilderTerrain.html");
            outer.NewLine();
            outer.Text("Added Terrain modify");
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 2.1 (August 30th 2017)");
            outer.NewLine();
            outer.Text("Update how the junctions and cross roads are made so that other nodes can be placed much closer than before");
            outer.NewLine();
            outer.Text("Junctions can now have 5 or 6 connecting roads");
            outer.NewLine();
            outer.Text("Added the option to delete all selected nodes");
            outer.NewLine();
            outer.Text("Added a safety check, to remove any roads node that are the same as the parent");
            outer.NewLine();
            outer.Text("Added repair layout button on the base layout object to clean up nodes with missing or broken links");
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 2.2 (September 09 2017)");
            outer.NewLine();
            outer.Text("Only create mesh when the nodes have changed");
            outer.NewLine();
            outer.Text("A large speed increase when calculating the network of nodes. Thanks to the help of a road builder user 'Kalin' who supplied some code.");
            outer.NewLine();
            outer.Text("AutoBuild mesh option for real time editing");
            outer.NewLine();
            outer.Text("Added tool tips for some options in the inspector");
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 2.2");
            outer.NewLine();
            outer.Text("Updated meta tags and category");
            outer.NewLine();
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 2.4 (March 2018)");
            outer.NewLine();
            outer.Text("Fixed a bug where the Terrain modify would fail if the road was outside the terrain");
            outer.NewLine();
            outer.Text("Added options to 'Drop Node to ground'");
            outer.NewLine();
            outer.Text("Added options to 'Drop all selected Nodes' to ground");
            outer.NewLine();
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 2.5 (4th May 2018)");
            outer.NewLine();
            outer.Text("Update the UV mapping near junctions and crossroads to stop texture squishing");
            outer.NewLine();
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 2.6 (9th May 2018)");
            outer.NewLine();
            outer.Text("Added the option to render the under side of the road");
            outer.NewLine();
            outer.Text("Added two new texture to use as the under side of the road");
            outer.NewLine();
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 2.7 (20 July 2018)");
            outer.NewLine();
            outer.Text("Update the meta data on the Unity Site");
            outer.NewLine();
            outer.NewLine();
            outer.NewLine();

            outer.Bold("Version: 2.8 (12 Dec 2018)");
            outer.NewLine();
            outer.Text("Fixed the option to render under the road when used in the override cross section details. So you can just add the mesh under the road just when you need it. Like bridges");
            outer.NewLine();
            outer.NewLine();
            outer.NewLine();

            outer.Bold("");
            outer.NewLine();
            outer.Text("");
            outer.NewLine();

            outer.EndTextCenter();

            return outer.Output();
        }
    }
}