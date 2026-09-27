using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;

namespace eWolfSiteBuilder._Site.Apps.SlideshowVideoCreator
{
    /// <summary>
    /// The privacy policy given to the Microsoft Store (Microsoft requires one for every desktop
    /// app, even one that sends nothing anywhere) and linked from the app's About window.
    /// The address is fixed in the app (CreateSlideShow AppInfo.PrivacyPolicy) and in Partner
    /// Center, so keep the file name. What it says was checked against the app's code: change
    /// it here if the app ever starts collecting anything, before that version ships.
    /// </summary>
    [PageTitle(Page)]
    public class PrivacyPolicy : PageDetailsWolfSite
    {
        public const string Page = "privacy-policy.html";
        private const string LastUpdated = "27 September 2026";

        public PrivacyPolicy()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Slideshow Video Creator - Privacy policy";
            MenuTitle = "Privacy policy";
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this, string.Empty);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");
            WebPage.Append(CreatePolicy());

            WebPage.CloseAllsDiv();
            WebPage.EndBody();
            WebPage.Output();
        }

        private static void Section(HTMLBuilder builder, string title, params string[] paragraphs)
        {
            builder.Text($"<h4>{title}</h4>");
            foreach (var paragraph in paragraphs)
                builder.Text(paragraph.StartsWith("<ul>") ? paragraph : $"<p>{paragraph}</p>");
        }

        private string CreatePolicy()
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.Jumbotron("Privacy policy", $"Slideshow Video Creator, by Electric Wolf. Last updated {LastUpdated}.");

            Section(outer, "In short",
                "Slideshow Video Creator works entirely on your PC. It doesn't collect, store or send any personal data. There are no accounts, no adverts, no analytics and no tracking, and your photos are never uploaded anywhere.");

            Section(outer, "Your photos, music and videos",
                "The app reads the photos and music in the folders you choose, and writes the videos you make to the folder you choose. All of this happens on your PC. Nothing is sent to us or to anyone else.");

            Section(outer, "What the app keeps on your PC",
                "<ul>" +
                "<li><strong>Your settings</strong> (such as the time per photo, series title and music folder), in Documents\\Slideshow Video Creator\\settings.json.</li>" +
                "<li><strong>Your choices for each photo folder</strong> (photos left out, crops and rotations, the photo order and the title card), in Documents\\Slideshow Video Creator\\Folders. Nothing is written into your photo folders.</li>" +
                "<li><strong>Temporary files</strong> made while a video is created, in the Windows temporary folder. They're deleted when they're no longer needed.</li>" +
                "<li><strong>An error log</strong>, if something goes wrong, in the app's own local data folder. It holds technical details: the app and Windows versions, and what failed (which can include file and folder names). It stays on your PC and is limited in size.</li>" +
                "</ul>",
                "You can delete any of these at any time. Uninstalling the app removes its local data folder. The Documents folder above is kept, so your choices aren't lost if you reinstall; you can delete it yourself.");

            Section(outer, "Error reports",
                "If something goes wrong, the app shows what happened and offers to open your own email app with a message to us already written, including the technical details above. Nothing is sent unless you choose to send that email yourself, and you can read and change it first. If you do email us, we use your email only to help with the problem, and we don't share it.");

            Section(outer, "Internet",
                "The app doesn't connect to the internet itself. A few links open in your web browser or the Microsoft Store when you click them: Microsoft's pages about the Media Feature Pack and the HEIC add-ons, this website, and the FFmpeg source code (see About in the app). If your photos are in OneDrive and some are stored online only, Windows and OneDrive download them to your PC when you make a video, under Microsoft's own terms.");

            Section(outer, "The Microsoft Store",
                "If you get the app from the Microsoft Store, Microsoft handles the purchase and download under the <a href='https://privacy.microsoft.com/privacystatement' target='_blank'>Microsoft Privacy Statement</a>. Microsoft gives us summary sales figures and, if the app crashes and your Windows settings allow it, crash reports that don't identify you. We don't receive your name, email or payment details from the Store.");

            Section(outer, "Children",
                "The app doesn't collect any information from anyone, including children.");

            Section(outer, "This website",
                "This policy covers the app. Pages on electricwolf.co.uk use Google Analytics, which sets cookies, to count visitors.");

            Section(outer, "Changes",
                "If this policy changes (for example, if the app ever adds optional crash reporting), we'll update this page and the date at the top before the change reaches the app.");

            Section(outer, "Contact",
                "Electric Wolf, Contact@electricWolf.co.uk");

            outer.NewLine();
            return outer.Output();
        }
    }
}
