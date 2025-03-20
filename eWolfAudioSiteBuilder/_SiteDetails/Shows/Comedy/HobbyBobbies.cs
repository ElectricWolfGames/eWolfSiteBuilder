using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class HobbyBobbies : AudioBaseDetails
    {
        public HobbyBobbies()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Hobby Bobbies";
            Year = 2013;
            DateAdded = "2024/12/20";

            Description = "Radio 4 sitcom about community policing. Written by Dave Lamb and starring Richie Webb and Nick Walker. Stars Richie Webb, Nick Walker, Sinead Keenan, Chris Emmett, Noddy Holder and Leon Herbert";

            Casts.Add("Geoff", "Richie Webb");
            Casts.Add("Nigel", "Nick Walker");
            Casts.Add("The Guv", "Sinead Keenan");
            Casts.Add("Bernie", "Chris Emmett");
            Casts.Add("Geoff's Dad", "Noddy Holder");
            Casts.Add("Jermain", "Leon Herbert");

            Production.Add("WRITER", "Dave Lamb");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "Steve Doherty");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("fbZKl6ldqCA");
            Shows.Shows[0].AddEpisode(1, "Dangerous Minds", "Geoff's decision to finally rebel against his domineering Dad doesn't go quite as he'd have liked.");
            Shows.Shows[0].AddEpisode(2, "Dangerous Driving", "Our heroes decide to act on dangerous driving in the town, starting with colleague Jermain.");
            Shows.Shows[0].AddEpisode(3, "Dangerous Posters", "The useless officers' crackdown on fly-posting leads to the disappearance of 'Daddy Warbucks' and the sight of Bernie in a bright red wig.");
            Shows.Shows[0].AddEpisode(4, "Dangerous Dogs", "Our heroes are dispatched to investigate a nuisance caller and her dangerous dog -but stumble into the local drugs racket.");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("ThzC2YoK53A");
            Shows.Shows[1].AddEpisode(1, "Sinkhole", "When an enormous sinkhole opens up, the police need to do a little more than 'look into it'.");
            Shows.Shows[1].AddEpisode(2, "Vice", "The tiny Haling police force is thrown into confusion when the Guv orders a crackdown on vice in their patch. Can social media help unveil the mysterious Big Brenda ?");
            Shows.Shows[1].AddEpisode(3, "Blackmail", "A little bit of murky police history comes back to haunt the Haling squad.Will the stench of corruption overpower the whiff of lager at the inter - force darts tournament?");
            Shows.Shows[1].AddEpisode(4, "Burglaries", "Nigel takes up free running in the hope that physical fitness can improve his performance at work.But what, if anything, will identify the mysterious hand cream thief ?");
        }
    }
}