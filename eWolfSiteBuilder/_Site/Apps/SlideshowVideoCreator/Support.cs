using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;

namespace eWolfSiteBuilder._Site.Apps.SlideshowVideoCreator
{
    /// <summary>
    /// Help and common questions, linked from the app's About window (CreateSlideShow
    /// AppInfo.Help) and the Store listing's support details, so keep the file name.
    /// The answers describe what the app really does; check them when the app changes.
    /// </summary>
    [PageTitle(Page)]
    public class Support : PageDetailsWolfSite
    {
        public const string Page = "support.html";

        public Support()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Slideshow Video Creator - Help and support";
            MenuTitle = "Help and support";
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this, string.Empty);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");
            WebPage.Append(CreateHelp());

            WebPage.CloseAllsDiv();
            WebPage.EndBody();
            WebPage.Output();
        }

        private static void Question(HTMLBuilder builder, string question, string answer)
        {
            builder.Text($"<p><strong>{question}</strong><br />{answer}</p>");
        }

        private string CreateHelp()
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.Jumbotron("Help &amp; support",
                "Answers to common questions about Slideshow Video Creator. If yours isn't here, email Contact@electricWolf.co.uk and we'll help.");

            outer.Text("<h4>Getting started</h4>");
            Question(outer, "How do I make a video?",
                "Click <em>Choose a folder…</em> and pick a folder of photos. Untick any you don't want, then click <em>Create video</em>. The video is saved next to your photos, or in the folder you choose in Settings.");
            Question(outer, "Can I see what it will look like first?",
                "Yes. Click <em>Preview</em> to see the title card and the first few photos in a few seconds. <em>Create video</em> in the preview makes the whole thing.");
            Question(outer, "How do I change the order of the photos?",
                "Use the order list above the photos: by name, by date taken, or your own order. For your own order, drag photos around, or select one and press Alt with the arrow keys. You can also right-click a photo.");
            Question(outer, "What's the title card?",
                "An animated opening card with the name, the place and the date. It's filled in from the folder name (for example \"2026-04-11 Bletchley Park\"). Click <em>Title card…</em> to change it, or to turn it off.");
            Question(outer, "How are portrait photos shown?",
                "Videos are wide, so a portrait photo can't fit whole. The first time you make a video with portrait photos, the app asks which part of each to show, and the video pans gently across it. To change it later, right-click the photo and choose <em>Adjust crop…</em>. To turn a photo the right way up, hover over it and click <em>Edit</em>; you can adjust its crop there too.");

            outer.Text("<h4>Photos and music</h4>");
            Question(outer, "My iPhone (HEIC) photos can't be read.",
                "Windows needs two Microsoft add-ons to read HEIC photos: <em>HEVC Video Extensions</em> (a small paid add-on) and <em>HEIF Image Extension</em> (free), both from the Microsoft Store. The app shows a link when it finds HEIC photos it can't read. You can also untick those photos.");
            Question(outer, "Which music files can I use?",
                "Common audio files such as MP3, M4A, WAV and FLAC. Choose a music folder in Settings; tracks are picked at random to fill the video, and fade in and out.");
            Question(outer, "My photos are in OneDrive.",
                "That's fine. Photos that are only stored online are downloaded when you make the video, so you'll need to be online and have room on your PC for them.");

            outer.Text("<h4>Problems</h4>");
            Question(outer, "It says the video features are missing.",
                "This happens on Windows \"N\" editions, which leave out Windows' media features. Open Settings &rarr; Apps &rarr; Optional features, add <em>Media Feature Pack</em>, then restart your PC. The app offers to open the right page for you.");
            Question(outer, "It says there isn't enough space.",
                "Videos, especially at 4K, need free disk space while they're made. The app checks first and tells you how much it needs. Free up some space, choose a smaller video size in Settings, or save videos to another drive.");
            Question(outer, "Something went wrong.",
                "The app shows what happened and offers to open your email app with the details already filled in. Please send it: it helps us fix the problem. Nothing is sent unless you send that email.");

            outer.Text("<h4>Your privacy</h4>");
            outer.Text($"<p>Everything happens on your PC. Nothing is uploaded, and the app collects no personal data. See the <a href='{PrivacyPolicy.Page}'>privacy policy</a>.</p>");

            outer.Text("<h4>Contact</h4>");
            outer.Text("<p>Email Contact@electricWolf.co.uk. Please say which version you have (click the &#9432; button in the app) and what you were doing.</p>");

            outer.NewLine();
            return outer.Output();
        }
    }
}
