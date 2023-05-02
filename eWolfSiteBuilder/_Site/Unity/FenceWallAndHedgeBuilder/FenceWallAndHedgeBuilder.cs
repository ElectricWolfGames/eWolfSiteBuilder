using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.FenceWallAndHedgeBuilder
{
    [PageTitle("FenceWallAndHedgeBuilder.html")]
    internal class FenceWallAndHedgeBuilder : PageDetails, IHomePagePreview, IUnityList
    {
        public FenceWallAndHedgeBuilder()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Fence, Wall and Hedge Builder";
            MenuTitle = "Fence, Wall and Hedge Builder";
        }

        public int UnityListOrder { get; set; } = 5;

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

            items.Add(new HTMLIndexedItems("Overview", CreateOverview));
            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Quick Walls", CreateQuickWalls));
            items.Add(new HTMLIndexedItems("Wall Types", CreateWallTypes));
            items.Add(new HTMLIndexedItems("Randomization Seeding", CreateRandomizationSeeding));
            items.Add(new HTMLIndexedItems("Adding you own Materials/Textures", CreateAddingYouOwnMaterialsTextures));
            items.Add(new HTMLIndexedItems("Changing scale", CreateChangingscale));
            items.Add(new HTMLIndexedItems("Baking light", CreateBakingLight));
            items.Add(new HTMLIndexedItems("Drop to ground", CreateDropToGround));
            items.Add(new HTMLIndexedItems("New gap feature types and new wall Type", CreateNewGapFeatureTypesAndNewWallType));
            items.Add(new HTMLIndexedItems("Fix UV projection and Extra thin wall types", CreateFixUVProjectionAndExtraThinWallTypes));
            items.Add(new HTMLIndexedItems("Update Corner joins on the walls", CreateUpdateCornerJoinsOnTheWalls));
            items.Add(new HTMLIndexedItems("Different Materials pre side", CreateDifferentMaterialsPreSide));
            //items.Add(new HTMLIndexedItems("Updated UV for the walls", CreateUpdatedUVForTheWalls));
            items.Add(new HTMLIndexedItems("Added Castle walls and Mounds", CreateAddedCastleWallsAndMounds));
            items.Add(new HTMLIndexedItems("Example Walls", CreateExampleWalls));
            items.Add(new HTMLIndexedItems("Support", PageDetailsHelper.AddSectionSupport));

            AddIndexItemsWithSideBar(items);

            WebPage.EndBody();
            WebPage.Output();
        }

        public PreviewItem GetHomePagePreview()
        {
            PreviewItem pi = new PreviewItem()
            {
                HRef = $"{WebPage.HtmlPath}\\{WebPage.HtmlTitle}",
                Name = DisplayTitle,
                PreviewItemType = PreviewItemType.Builders,
                ImagePath = @$"{WebPage.HtmlPath}\images\FenceWallAndHedgeBuilder.gif",
                Description = "Fence Wall And Hedge Builder Lets you quickly place walls in your game, using a user-friendly UI from within the scene editor or the inspector, Select from a list defined wall types and then select the style of that type"
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Unity3DLink(Unity3DSetting.FenceWallAndHedgeBuilder);
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateAddedCastleWallsAndMounds(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("V3.3 (September 2018) Added Two different castle wall ramparts.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("CastleWalls.png", 45);
            outer.NewLine();
            outer.Text("And some ground effects like mounds");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("Mounds.png", 45);
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateAddingYouOwnMaterialsTextures(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("MaterialLists.png", 45);
            right.NewLine();
            right.NewLine();
            right.Text("When you need to add or replace the materials for the walls.");
            right.NewLine();
            right.Text("Just select the Wall_Builder_pf object to see the current material lists.");
            right.NewLine();
            right.NewLine();
            right.Text("Each wall type will use a different list of materials.");
            right.NewLine();
            right.Text("Just add you own material to the list for the type of wall you wish to update.");
            right.NewLine();
            right.NewLine();
            right.Text("Any new materials will appear in the material dropdown list for that wall type.");
            right.NewLine();
            right.Text("Just remember to re-apply your changes to update the prefab.");

            outer.Text(options.Output());

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateBakingLight(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            right.ImageLeft("BakedLighting.png", 45);

            left.NewLine();
            left.TextBoldText("If you are using baked light in your project you will also need enable by ticking the Baked Lighting option on the ", "WallBuilder_pf", " object.");
            left.NewLine();
            left.NewLine();
            left.Text("The other options here are the standard import option for applying baked lighting on import meshes. Default are the same as the import meshes.");

            outer.Text(options.Output());
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateChangingscale(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("When you need to change the scale of the walls to match your environment.");
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("just change the Building Units on the ", "Wall_Builder_pf", " object");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("ShowScale.png", 65);

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateDifferentMaterialsPreSide(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("From V3.1 (April 2018) Added some new textures to the wall options.");
            outer.NewLine();
            outer.NewLine();

            var options = new HTMLBuilder();
            HTMLSection a = new HTMLSection("col-md-4");
            HTMLSection b = new HTMLSection("col-md-4");
            HTMLSection c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("PlasterWall_v1.jpg", 65);
            b.ImageCenter("PlasterWall_v2.jpg", 65);
            c.ImageCenter("PlasterWall_v3.jpg", 65);

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();

            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("PlasterWall_v4.jpg", 65);
            b.ImageCenter("RedBrick_v2.JPG", 65);
            c.ImageCenter("RedBrick_v3.JPG", 65);

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();

            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("RedBrick_v4.jpg", 65);
            b.ImageCenter("ReinforcedConcrete.jpg", 65);
            c.ImageCenter("StoneWall_v3.jpg", 65);

            outer.Text(options.Output());
            outer.NewLine();

            outer.Text("Added an option to allow you to set different material/textures for each face of the wall.");
            outer.NewLine();
            outer.Text("Just tick the 'Materials Per Side' options and select the material from the drop-down lists.");
            outer.NewLine();
            outer.ImageCenter("FenceBuilder MaterialPreFaceOptions.png", 35);
            outer.NewLine();
            outer.Text("The original material is still used as the outside of the wall.");
            outer.NewLine();
            outer.ImageCenter("FenceBuilder MaterialPreFace.png", 65);

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateDropToGround(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.OtherDetails("Drop all corners to the ground", "option from the main Wall_Builder_pf object. This will drop all the wall corners down to any object with collision and has the 'Ground' layer set.");
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateExampleWalls(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            var options = new HTMLBuilder();
            HTMLSection a = new HTMLSection("col-md-4");
            HTMLSection b = new HTMLSection("col-md-4");
            HTMLSection c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("BrickWall_Brick.png", 85);
            b.ImageCenter("BrickWall_Stone.png", 85);
            c.ImageCenter("Hedge.png", 85);

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();

            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("KneeHeighFence.png", 85);
            b.ImageCenter("FarmFence.png", 85);
            c.ImageCenter("MetalRailingA.png", 85);

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();

            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("PicketFenceA.png", 85);
            b.ImageCenter("PicketFenceB.png", 85);
            c.ImageCenter("PicketFenceC.png", 85);

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();

            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("WoodenPannelA.png", 85);
            b.ImageCenter("WoodenPannelB.png", 85);
            c.ImageCenter("WoodenPannelC.png", 85);

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();

            outer.ImageCenter("BrickWallTowers.png", 45);

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateFixUVProjectionAndExtraThinWallTypes(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("Temporary Fences have been added.");
            outer.NewLine();
            outer.Text("Each temporary fence has extra feet under the fence to look like it's only a temporary structure");
            outer.NewLine();
            outer.NewLine();
            outer.Text("4 new version of the temporary fence are available");
            outer.NewLine();
            outer.Bold("TemporaryWireFence");
            outer.NewLine();
            outer.Bold("TemporaryWireFenceB");
            outer.NewLine();
            outer.Bold("TemporaryBluePannelFence");
            outer.NewLine();
            outer.Bold("TemporaryWhitePannelFence");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("TemporaryFences.png", 65);
            outer.NewLine();
            outer.Text("Temporary Fences in game..");
            outer.NewLine();
            outer.ImageCenter("FenceBuilder_TemporaryFenceInGame.png", 65);
            outer.NewLine();
            outer.NewLine();
            outer.Text("New Thin walls The thin wall are just one brick wide");
            outer.NewLine();
            outer.ImageCenter("FenceBuilder_ThinBrickWalls.png", 65);
            outer.NewLine();
            outer.Text("Improved UV mapping for walls and Hedges");
            outer.NewLine();
            outer.YouTubeLinkBig("RpnxKxzuEKU");

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Fence, Wall and Hedge Builder Lets you quickly place walls in you game, using a user friendly UI from within the scene editor or the inspector, Select from a list of defined wall types and then select the style for that type.");
            return options.Output();
        }

        private void CreateIndexedItems(List<HTMLIndexedItems> items)
        {
            HTMLBuilder options = new HTMLBuilder();

            options.CreateIndex(items);
            WebPage.Append(options.Output());

            options = new HTMLBuilder();
            options.CreateIndexItems(items);
            WebPage.Append(options.Output());
            WebPage.Append("</div>");

            WebPage.CloseAllsDiv();
        }

        private string CreateNewGapFeatureTypesAndNewWallType(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("With V2.0 (March 2018) You can now add as many feature gaps to any wall.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Added 4 new gap types to Wall and hedges.");
            outer.NewLine();
            outer.OtherDetails("Hole Round", "");
            outer.OtherDetails("Hole Square", "");
            outer.OtherDetails("Hole Rectangle", "");
            outer.OtherDetails("Hole Arch", "");
            outer.NewLine();
            outer.Text("With all the new feature types we now have extra options.");
            outer.NewLine();
            outer.ImageCenter("FenceBuilder -FeatureInspector.png", 35);
            outer.NewLine();
            outer.NewLine();

            outer.InspectorDetails("Style", "The type of gap (Arch, Hole Round, Hole Square, etc..)");
            outer.InspectorDetails("Width", "The width of the gap, With any of the Hole style selected the width is the percentage of the height of the wall");
            outer.InspectorDetails("Height", "Only used for Hole Rectangle, it's the height of the rectangle");
            outer.InspectorDetails("Details", "Only used for Hole Round and Hole Arch, it's the number of polygons to use. Higher numbers will create smoother circles");
            outer.InspectorDetails("Off Set Y", "The off set of the feature vertical (Percentage of the height)");
            outer.NewLine();

            outer.Text("Example of the new features styles");
            outer.ImageCenter("Fence Builder Gap Features Styles.png", 65);
            outer.NewLine();
            outer.NewLine();
            outer.Text("Example of the Hole Round with different Off Set Y and Widths");
            outer.ImageCenter("Fence Builder Off Set Y Holes.png", 65);
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("lHCONd1qkWg");

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateOverview(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.TextBoldText("Just place the wall prefab into your scene and then click", " Add Wall ", "button");
            outer.NewLine();
            outer.Text("Then use the dropdown list to select the type of wall (BrickWall, Hedge, Panel wall, etc.)");
            outer.NewLine();
            outer.Text("And then pick the style of the wall (Large, Medium, small and unkept or aged).");
            outer.NewLine();
            outer.NewLine();
            outer.Text("You can also add extra features to the wall, like gaps, gates, arches.");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("y4nlj4Q-Ljo");

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateQuickWalls(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("Just place the wall prefab into your scene.");
            outer.NewLine();
            outer.Text(" Then using the two circular handles you can set the start and end point of the wall.");
            outer.NewLine();
            outer.Text(" With the AutoBuild Options ticked you will see the wall update in real-time.");
            outer.NewLine();
            outer.Text(" And you can add extra features to the wall like gap or arches.");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("WSYg_BXvLdg");
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateRandomizationSeeding(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("Some wall types use the random seed to make the wall look aged or unkept.");
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("Just keep pressing the ", "Randomize Seed", " button to get the look you need.");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("fqZe7uT3ycM");

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateUpdateCornerJoinsOnTheWalls(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("Connected corners are shaped to make each section of the wall join.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("Fence Builder-Corner Walls.png", 35);
            outer.NewLine();
            outer.Text("Work even when walls have different thinness");
            outer.NewLine();
            outer.ImageCenter("Fence Builder-Corner Walls Thin.png", 35);

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateUpdatedUVForTheWalls(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateWallTypes(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("WallBaseTypes.png", 45);
            right.NewLine();
            right.NewLine();
            right.Text("The look of each wall type is defined by the Wall Base Type.");
            right.NewLine();
            right.Text("Just select the type of wall you wish to use.");

            outer.Text(options.Output());

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.NewLine();
            left.NewLine();
            left.Text("When you have picked your wall type. You can now select the style of that wall.");
            left.NewLine();
            left.Text("Each wall type will have a different style selection.");
            right.ImageLeft("WallStyle.png", 45);

            outer.Text(options.Output());

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("WallMaterial.png", 45);
            right.NewLine();
            right.NewLine();
            right.Text("Other textures variation are also available.");
            right.NewLine();
            right.Text("Just use the material dropdown options or press the Randomize texture button.");

            outer.Text(options.Output());

            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }
    }
}