using eWolfAudioSiteBuilder.Data;
using System.Windows;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class TheTrainatPlatform4 : AudioBaseDetails
    {
        public TheTrainatPlatform4()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "The Train at Platform 4";
            Year = 2022;
            DateAdded = "2025/02/21";

            Description = "Our heroes are the long-suffering train crew who manage to scrape through every shift like a dysfunctional family – Train Manager Sam, First Class Stewards Noel and Gilbert, Catering Manager Dev and Trolley Operator Tasha. The passengers are made up of a rolling roster of guest stars.";

            Casts.Add("Sam", "Rosie Cavaliero");
            Casts.Add("Noel", "Hugh Dennis");
            Casts.Add("Gilbert", "Kenneth Collard");
            Casts.Add("Dev", ". Ali Shahalom");
            Casts.Add("Tasha", ". Amy Gledhill");
            Casts.Add("Jocasta", "Anna Crilly");
            Casts.Add("Colleague", "Justice Ritchie");
            Casts.Add("Mr Bagnall", "Steve Brody");
            Casts.Add("Teacher", "Katy Wix");
            Casts.Add("Cat Lady", "Freya Parker");
            Casts.Add("Student", "Justice Ritchie");
            Casts.Add("Pia", "Katie Norris");
            Casts.Add("CEO", "Joz Norris");
            Casts.Add("Difficult Man", "Martin Trenaman");
            Casts.Add("Tom", "Milo Robinson");
            Casts.Add("Cameo 1", "Hugh Dennis");
            Casts.Add("Cameo 2", "Steve Punt");
            Casts.Add("Cameo 3", "Gemma Arrowsmith");


            Production.Add("WRITER", "Steve Punt");
            Production.Add("WRITER", "Hugh Dennis");
            Production.Add("PRODUCER", "James Robinson");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("XbIOzPjFgUo");
            Shows.Shows[0].AddEpisode(1, "Coffee", "It's day one of a new franchise and train manager Sam has high hopes for their maiden voyage, even if the new bosses insist her role is to 'enhance the onboard travel experience'. But the marketing team's offer of free coffee for ALL customers soon threatens to derail the smooth running of the service. Meanwhile passengers struggle to escape the clutches of the automatic toilets...");
            Shows.Shows[0].AddEpisode(2, "Cat", "It's Friday night and everyone's looking forward to their weekend plans. But the journey home is struck with disaster when a celebrity cat goes missing on the train - Artemis Montmorency Wolfhandle the Third is potentially the new face of Kitty Krunch Cat Food but is set to miss a crucial audition if the train crew can't track her down. Meanwhile, Dev's plans for a hot date are thrown into turmoil when he learns the bitter truth about his receding hairline.");
            Shows.Shows[0].AddEpisode(3, "Bag", "Sam and the rest of the crew struggle to contain an anarchic party of seditious school children. But Dev sees a golden business opportunity in profiting from the kids' snack money. Meanwhile a bag falls from the luggage rack, injuring a passenger, who turns out to work for the rail regulator. Sam struggles to appease him, in order to avoid a damning report.");
            Shows.Shows[0].AddEpisode(4, "Gilbert", "When First Class Steward Gilbert discovers his step-sister is a passenger on the train, he's forced to spend the journey hiding from her. It seems that his whole life Gilbert has been living a lie. Meanwhile, Sam must contend with a carriage full of Roundheads on their way to a re-enactment of the Battle of Naseby, armed with a collection of very realistic pikes.");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("OKsfb_y4J6Q");
            Shows.Shows[1].AddEpisode(1, "See It, Say It, Sorted", "Sam is tired of having to ‘sort it’ when passengers ‘see it’ and ‘say it’, but when an actual suspect package is found, the team leap into action.");
            Shows.Shows[1].AddEpisode(2, "Get a Room", "Sam befriends a couple who extol the virtues of early retirement, while a younger couple get a little too friendly with each other in first class.");
            Shows.Shows[1].AddEpisode(3, "Is This Your Seat?", "A man refuses to move seat, causing a moral crisis on board.   When two American tourists attempt to celebrate their 50th wedding anniversary with a Great British railway journey to York, Sam must negotiate with the bloke in their reserved seat who’s refusing to move.");
            Shows.Shows[1].AddEpisode(4, "Smart Train", "Dodgy air conditioning, indecipherable announcements, toilet doors that open randomly – it sounds like your average train journey. But when an update goes wrong, the train’s automated systems cause chaos and things are even worse than normal.  Sam and the team attempt to wrestle back control of a train gone haywire.");
        }
    }
}