using eWolfBootstrap.Builders;
using System.Collections.Generic;

/// <summary>
///  https://www.w3schools.com/howto/howto_google_fonts.asp
/// </summary>

namespace eWolfSiteBuilder.zOLD.Headers
{
    public class MainHeader : HTMLBuilder
    {
        private readonly List<string> _pages = new List<string>();
        private string _makeActive = string.Empty;

        public MainHeader()
        {
            _pages.Add("Home");
            _pages.Add("Unity3D Tools");
            _pages.Add("Games");
            _pages.Add("Contact");
        }

        public void MakeUnity3DActive()
        {
            _makeActive = "Unity3D Tools";
        }

        public override string Output()
        {
            Text("<nav class='navbar sticky-top flex-md-nowrap p-0 wolf-topbar'>");
            Text("<a class='navbar-brand col-sm-3 col-md-2 mr-0' href='#'>Electric Wolf</a>");
            Text("<ul class='navbar-nav px-3'>");
            Text("<li class='nav wolf-topbaritem '>");

            foreach (var pageName in _pages)
            {
                if (pageName == _makeActive)
                {
                    Text($"<a class='nav-link px-2 active' href='#'>{pageName}</a>");
                }
                else
                {
                    Text($"<a class='nav-link px-2' href='#'>{pageName}</a>");
                }
            }

            /*Text("<a class='nav-link' href='#'>Home</a>");
            Text("<a class='nav-link' href='#'>Unity3D Tools</a>");
            Text("<a class='nav-link' href='#'>Games</a>");
            Text("<a class='nav-link' href='#'>Contact</a>");*/
            Text("</li>");
            Text("</ul>");
            Text("</nav>");

            return base.Output();
        }
    }
}