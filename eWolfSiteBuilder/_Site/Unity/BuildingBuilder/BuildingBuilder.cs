using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.BuildingBuilder
{
    [PageTitle("BuildingBuilder.html")]
    public class BuildingBuilder : PageDetailsWolfSite, IHomePagePreview, IUnityList
    {
        /// <summary>
        /// The texture styles that ship with the package. Each one has a clean, an Unkept (dirty)
        /// and an Unused (run down) atlas in the images folder: Name.png, Name_Unkept.png, Name_Unused.png
        /// </summary>
        private static readonly (string File, string Title, string Description)[] TextureStyles =
        {
            ("HouseWillage", "Village House", "red brick, slate roof - the original village house"),
            ("HouseWillageB", "Village House B", "red brick with white doors and bay windows"),
            ("HouseStone", "Stone House", "coursed sandstone with a tiled roof"),
            ("HouseTudor", "Tudor House", "plaster and timber frame, stone tiled roof"),
            ("OfficeBlock", "Office Block", "flat roof tower block with glass shopfronts"),
            ("HouseYellowBrick", "Yellow Brick", "London stock brick, red clay roof, green door"),
            ("HouseRedBrickVictorian", "Victorian Red Brick", "deep red brick with cream stone dressings, grey slate"),
            ("HouseDarkBrick", "Dark Brick", "engineering brick with anthracite frames, black slate - modern town house"),
            ("HousePaintedBrick", "Painted Brick", "soft painted brick, grey slate, sage door"),
            ("HouseWhiteRender", "White Render", "white painted render, dark slate, navy door - coastal cottage"),
            ("HouseTerracotta", "Terracotta", "ochre stucco, barrel tiles and green shutters - Mediterranean"),
            ("HousePebbledash", "Pebbledash", "roughcast render with a brown clay roof - 1930s semi"),
            ("HouseModernGrey", "Modern Grey", "smooth render, wide windows, standing seam metal roof"),
            ("HouseSandstone", "Sandstone", "regular buff ashlar blocks, red clay roof"),
            ("HouseGraniteCottage", "Granite Cottage", "dark rubble stone, slate roof, red door"),
            ("HouseLimewashStone", "Limewash Stone", "whitewashed rubble stone, slate roof, blue door"),
            ("HouseClapboard", "Clapboard", "painted weatherboard, cedar shingle roof, white trim"),
            ("HouseNordicRed", "Nordic Red", "Falu red vertical boards, white trim, grey metal roof"),
            ("HouseLogCabin", "Log Cabin", "round logs with a green metal roof"),
            ("HouseTimberFrame", "Timber Frame", "cream plaster with a dark oak frame, mossy shingles"),
            ("HouseThatchedCottage", "Thatched Cottage", "cream cob walls with a thatched roof"),
        };

        public BuildingBuilder()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Building Builder";
            MenuTitle = "Building Builder";
            Keywords.Add(DisplayTitle);
            Keywords.Add("add building");
            Keywords.Add("unity3d building");
            Keywords.Add("background building");
            Keywords.Add("unity3d house");
            Keywords.Add("weathered building");
            Keywords.Add("abandoned house");
        }

        public int UnityListOrder { get; set; } = 15;

        public override void CreatePage()
        {
            WebPage.AddHeader(this, string.Empty);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");

            WebPage.Append(CreateHero());
            WebPage.Append(CreateVersionNote());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Overview", CreateOverview));
            items.Add(new HTMLIndexedItems("New in 2026", CreateWhatsNew));
            items.Add(new HTMLIndexedItems("Create First Building", CreateFirstBuilding));
            items.Add(new HTMLIndexedItems("House Style", CreateHouseStyle));
            items.Add(new HTMLIndexedItems("Randomization", CreateRandomization));
            items.Add(new HTMLIndexedItems("Setting Textures", CreateSettingTextures));
            items.Add(new HTMLIndexedItems("Weathering", CreateWeathering));
            items.Add(new HTMLIndexedItems("Materials", CreateMaterials));
            items.Add(new HTMLIndexedItems("Included Textures", CreateIncludedTextures));
            items.Add(new HTMLIndexedItems("Baked Light Map Support", CreateBakedLightMapSupport));
            items.Add(new HTMLIndexedItems("Textures Templates", CreateTexturesTemplates));
            items.Add(new HTMLIndexedItems("Custom Build example", CreateCustomBuildExample));
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
                ImagePath = @$"{WebPage.HtmlPath}\images\Builder_Creating_your_first_Buildin.gif",
                Description = "Building Builder lets you create a variety of Low-poly buildings from a defined list of settings. Each building is created by a collection of options that can easily be changed or set to use a random set of values"
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Unity3DLink(Unity3DSetting.BuildingBuilder);
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateBakedLightMapSupport(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.StartTextCenterLeft();
            left.StartTextMiddel(300);
            left.NewLine();
            left.NewLine();
            left.Text("With the release of Version 1.2 (June 2017) you can now use the building with Baked lighting. Just enable the new Baked Lighting option and adjust the unwrapping options.");
            left.NewLine();
            left.NewLine();
            left.Text("The Unwrapping options are the current default import options on normal mesh import.");
            left.EndTextMiddel();
            left.EndTextCenterLeft();
            right.ImageLeft("BakedLightingOptions.png", 55);

            outer.Text(options.Output());
            outer.NewLine();
            outer.ImageCenter("BakedLightsTest.png", 55);

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateFirstBuilding(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();
            outer.Text("To start creating random buildings you just need to add the prefab of your chosen building type from the selection in the Prefabs folder (use the ones in Prefabs/URP if your project uses the Universal Render Pipeline).");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Building builder is ideal for any low poly games that need a lot of buildings, or just as a background building for higher detail games.");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("Village house", "(basic)");
            outer.OtherDetails("Village house", "(variety) - picks from a list of materials");
            outer.OtherDetails("Village house B", "(basic)");
            outer.OtherDetails("Town house", "(basic)");
            outer.OtherDetails("Tower block", "(basic)");
            outer.OtherDetails("Tudor house", "(basic)");
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("And then just click on the ", "'Randomize Building'", " button.");
            outer.NewLine();
            outer.TextBoldText("That's your first house created. You can continue to click on the ", "'Randomize Building'", " button if you need something different.");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("sE88PriFNsc");
            outer.NewLine();
            outer.NewLine();
            outer.TextBold("After you have created your building you can still customize it, so maybe you like the building but you just need it a bit wider, or you need to add a garage - you can just modify the settings and click on ", "'Create Building'");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("NTOVUlW3S5Y");
            outer.NewLine();
            outer.NewLine();
            outer.TextBold("You can set the size of each building section by changing the", " Building Units.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("ShowScale.png", 65);
            outer.NewLine();
            outer.NewLine();
            outer.Text("This means you don't need to change the transform scale, so the buildings are more likely to get batched when rendering.");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateCustomBuildExample(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.Text("Here is an example of using a few buildings together to make one large building.");
            outer.NewLine();
            outer.YouTubeLinkBig("7fqrVVaMljw");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Building Builder lets you create a variety of Low-poly buildings from a defined list of settings. Each building is created by a collection of options that can easily be changed or set to use a random set of values. Every building comes in three conditions - clean, unkept and run down - with over twenty texture styles included.");
            return options.Output();
        }

        /// <summary>
        /// Tells the reader this is the 2026 version and links to the legacy (2017) page, which is kept for older releases
        /// </summary>
        private string CreateVersionNote()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.TextBoldText("This page covers the ", "2026 version", " of Building Builder. If you are using an older release, the");
            options.PageLink("", "Legacy version (2017)", "BuildingBuilder_v1.html");
            options.Text(" page is still available.");
            options.EndTextCenter();
            return options.Output();
        }

        private string CreateHouseStyle(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.NewLine();

            outer.Text("To help you quickly set-up different styles of building you have the House Style options.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Here you can select the kind of building you wish to create, like");
            outer.NewLine();
            outer.Text("Village House");
            outer.NewLine();
            outer.Text("Town House");
            outer.NewLine();
            outer.Text("Tower Block");
            outer.NewLine();
            outer.NewLine();
            outer.Text("This will set-up all the randomization details for that type of building. But it will not change the materials you have defined.");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateMaterials(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.Text("When a building is created / randomized it will pick one of the materials from this list. For most buildings you may only have one material, but for others you may wish to make the building look different. So just add as many variations as you need to this list and the randomiser will pick one for you. If you wanted 1 out of 10 buildings to look like they are made of stone and not brick, you would add 10 materials to this list, 9 of them red brick and 1 stone. See the 'VillageHouse(Variety)_pf' prefab for an example of this.");

            outer.NewLine();
            outer.NewLine();
            outer.Text("You can add / use materials, textures and shaders as you need. Because Building builder assigns the material from the list it lets you set-up any normal maps and specular maps as you would for a normal asset.");

            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("Below the main list there are two more lists, ", "Unkept Materials", " and ");
            outer.TextBoldText("", "Unused Materials", ". These hold the weathered version of each material, matched by position in the list. You do not normally need to fill these in: the first time you press a weathering button the builder finds them for you by name.");

            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("", "Universal Render Pipeline (URP)", " - the materials in Materials/Clean, Unkept and Unused use the built-in Standard shader. The same set is provided for URP in Materials/URP (named <Name>_URP, <Name>_URP_Unkept and <Name>_URP_Unused) on the Universal Render Pipeline/Lit shader. In a URP project use the prefabs in Prefabs/URP, which are the same six prefabs already set up with the _URP materials - or put the _URP materials in any Builder's material list yourself; the weathering buttons find the matching versions in the same way. The demo scene DemoScenes/V2/MoreTextures_URP is the URP version of MoreTextures - a street of buildings in all three conditions using the _URP materials, so you can see everything working straight away. In a built-in pipeline project the URP materials show a missing shader - ignore or delete the Materials/URP folder.");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateOverview(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();
            outer.Text("You just set the style of house to use and then let the randomiser create a building within the parameters of your chosen building style. After you have created your random building you can tweak the options to make it just as you need it.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Building builder is ideal for any low poly games that need a lot of buildings, or just as a background building for higher detail games.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Every building can be shown in three conditions - clean, unkept and run down - so the same street can have well kept homes next to boarded up, overgrown ones.");
            outer.NewLine();
            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateWhatsNew(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.Text("The 2026 release is a big update to the textures and the way buildings can look, while keeping the same simple workflow.");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("Three conditions", "every building can be Clean, Unkept (dirty) or Unused (run down) - switch with one click or let the randomiser decide.");
            outer.OtherDetails("16 new texture styles", "brick, stone, render, timber, log and more - 21 styles in all, each in all three conditions.");
            outer.OtherDetails("Random weather", "tick which conditions 'Randomize Building' may pick, plus a 'Randomize Weather' button.");
            outer.OtherDetails("Texture letters", "door styles B and C and the garage door X can now be set by hand and are kept when you rebuild.");
            outer.OtherDetails("URP support", "every material, each prefab and a demo scene are also provided for the Universal Render Pipeline (Materials/URP, Prefabs/URP and DemoScenes/V2/MoreTextures_URP).");
            outer.OtherDetails("Fixes", "garages now sit flush with the house on odd sized buildings, the terrain modifier covers the garage as well, and the package builds cleanly in player builds.");
            outer.NewLine();
            outer.Text("Existing scenes and prefabs carry on working: the materials you have set up are untouched and are simply used as the Clean condition.");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("v0FACqL0W4Y");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateRandomization(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("Randomization.png", 45);

            right.StartTextCenterLeft();
            right.StartTextMiddel(400);
            right.NewLine();
            right.NewLine();
            right.Text("When you have a building or group of buildings selected you should see all the randomization options in the inspector. This area can be used to help define the look of the house when you press the randomize building button.");
            right.NewLine();
            right.NewLine();
            right.Text("If you don't want an option to be randomized just un-tick the option.");
            right.NewLine();
            right.NewLine();
            right.TextBoldText("The three tick boxes under the ", "'Randomize Building'", " button (Clean, Unkept, Unused) choose which conditions the building may be given when it is randomized. Only Clean is ticked to start with, so buildings stay clean unless you say otherwise.");
            right.NewLine();
            right.EndTextMiddel();
            right.EndTextCenterLeft();

            outer.Text(options.Output());

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateSettingTextures(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.StartTextCenterLeft();
            left.StartTextMiddel(300);
            left.NewLine();
            left.NewLine();
            left.Text("You can re-randomise the arrangement of textures by using the \"Randomize Textures\" button. You can also edit them manually by changing the letters in the Textures Details section. Here each texture used is represented with a letter.");
            left.NewLine();
            left.NewLine();
            left.OtherDetails("W", "Wall");
            left.OtherDetails("G", "Window (Glass)");
            left.OtherDetails("D", "Door (style A)");
            left.OtherDetails("B", "Door (style B)");
            left.OtherDetails("C", "Door (style C)");
            left.OtherDetails("X", "Garage door (town house)");
            left.EndTextMiddel();
            left.EndTextCenterLeft();
            right.ImageLeft("TextureDetails.png", 65);

            outer.Text(options.Output());

            outer.Text("Letters are arranged by each wall and then by floor, so...");
            outer.NewLine();
            outer.Bold("GD,WW,GG,WW");
            outer.NewLine();
            outer.Text("is a single floor building with a width of 2 and a depth of 2.");
            outer.NewLine();

            outer.NewLine();
            outer.Text("The front of the building will have a window and a door [GD]");
            outer.NewLine();
            outer.Text("The side has just walls [WW]");
            outer.NewLine();
            outer.Text("The back has two windows [GG]");
            outer.NewLine();
            outer.Text("The other side has two walls [WW]");
            outer.NewLine();
            outer.NewLine();

            outer.YouTubeLinkBig("Z4SgXE8BxRU");
            outer.NewLine();
            outer.Text("Note : If you change the size of the house, the letters are only kept if you also edit them to match the new size (one line per floor, one letter per wall section). Otherwise a new random arrangement is created.");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateWeathering(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.Text("Every texture comes in three conditions, so a building can look brand new, a bit neglected, or abandoned - all from the same prefab and the same layout.");
            outer.NewLine();
            outer.NewLine();

            HTMLBuilder conditions = new HTMLBuilder();
            HTMLSection clean = new HTMLSection("col-md-4");
            HTMLSection unkept = new HTMLSection("col-md-4");
            HTMLSection unused = new HTMLSection("col-md-4");
            conditions.SetThreeSections(clean, unkept, unused);

            clean.Bold("Clean");
            clean.NewLine();
            clean.Text("As designed.");
            clean.NewLine();
            clean.ImageCenter("HouseWillage.png", 90);

            unkept.Bold("Unkept");
            unkept.NewLine();
            unkept.Text("Dirty: grime, rain streaks, damp, moss and dirty glass.");
            unkept.NewLine();
            unkept.ImageCenter("HouseWillage_Unkept.png", 90);

            unused.Bold("Unused");
            unused.NewLine();
            unused.Text("Run down: boarded up windows and door, broken glass, missing roof tiles, cracks and ivy.");
            unused.NewLine();
            unused.ImageCenter("HouseWillage_Unused.png", 90);

            outer.Text(conditions.Output());
            outer.NewLine();
            outer.NewLine();

            outer.TextBoldText("In the inspector the ", "Weathering", " row has a button for each condition - the current one is shown pressed. Clicking one swaps the material straight away without rebuilding the mesh, so your window and door layout is untouched.");
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("", "'Randomize Weather'", " picks one of the conditions ticked under the 'Randomize Building' button, and 'Randomize Building' itself does the same, so a whole street can be randomized in one click.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("The weathered materials live next to the clean ones, in Materials/Clean, Materials/Unkept and Materials/Unused (with the textures in the matching Textures folders). They are named after the clean material with _Unkept or _Unused added, which is how the builder finds them - so if you make your own texture, just follow the same naming and the buttons will pick it up.");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateIncludedTextures(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.Text($"The package includes {TextureStyles.Length} texture styles, each in all three conditions (clean, unkept, unused). Every one follows the same template, so any of them can be used with any of the prefabs.");
            outer.NewLine();
            outer.NewLine();

            foreach (var style in TextureStyles)
            {
                outer.Text(CreateTextureRow(style.File, style.Title, style.Description));
            }

            outer.EndTextCenter();
            return outer.Output();
        }

        /// <summary>
        /// One texture style: its name and the clean / unkept / unused atlases side by side
        /// </summary>
        private static string CreateTextureRow(string file, string title, string description)
        {
            HTMLBuilder row = new HTMLBuilder();
            row.TextBoldText("", title, $" - {description}");
            row.NewLine();
            row.Images(31, $"{file}.png", $"{file}_Unkept.png", $"{file}_Unused.png");
            row.NewLine();
            row.NewLine();
            return row.Output();
        }

        private string CreateTexturesTemplates(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.Text("Each building only needs one texture, and it uses different parts of that texture for the different features of the building.");
            outer.NewLine();
            outer.NewLine();

            outer.Text("So each texture is split-up into a 4 by 4 grid and each cell represents a different type of wall. When you have the Building style as 'Village House' or 'Town House' the texture map is as follows.");
            outer.NewLine();
            outer.NewLine();

            outer.ImageCenter("TableA.PNG", 65);

            outer.NewLine();

            outer.Text("When you have the Building style as 'Tower Block' the texture map is as follows. (Tower block uses a flat roof style.)");
            outer.NewLine();
            outer.ImageCenter("TableB.PNG", 65);
            outer.NewLine();
            outer.NewLine();

            outer.Text("A labelled template is included in the Textures folder as Template.png.");
            outer.NewLine();
            outer.ImageCenter("Template.png", 45);
            outer.NewLine();
            outer.NewLine();

            outer.Text("Note : You can create textures of any size, just as long as the texture follows the template above. All the empty sections have been left for future additions.");

            outer.EndTextCenter();
            return outer.Output();
        }
    }
}
