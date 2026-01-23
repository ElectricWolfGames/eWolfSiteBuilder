using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy;

public class AllGasAndGaiters : AudioBaseDetails
{
    public AllGasAndGaiters()
    {
        ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

        Title = "All Gas And Gaiters";
        Year = 2099;
        DateAdded = "";
        OutputPath = "E:\\_AudioTemp\\Comedy\\2026- Uploading\\039 All Gas And Gaiters\\";

        Description = "The Anglican Bishop of St Ogg's attempts to run his parochial affairs, aided by The Archdeacon, but hindered by his Secretary/Chaplain, in the face of hostile opposition from The Dean.";

        Casts.Add("The Bishop", "William Mervyn  ");
        Casts.Add("The Dean", "John Barron");
        Casts.Add("The Archdeacon", "Robertson Hare");
        Casts.Add("The Chaplain(Series 1)", "Derek Nimmo");
        Casts.Add("The Chaplain(Series 2)", "Jonathan Cecil ");

        Production.Add("WRITER", "Pauline Devaney");
        Production.Add("WRITER", "Edwin Apps");
        Production.Add("PRODUCER", "David Hatch");
        Production.Add("PRODUCER", "John Dyas (Series 2)");
        Production.Add("DIRECTOR", "");

        Shows.Add("Series  1 - Part A");
        Shows.ShowItems[0].AddLink("");
        var show = Shows.ShowItems[0];
        show.PartName = "A";
        show.AddEpisode(1, "Episodes 1", "The Bishop Rides Again (5 January 1971)");
        show.AddEpisode(2, "Episodes 2", "The Bishop Writes a Sermon ( 12 January 1971)");
        show.AddEpisode(3, "Episodes 3", "The Bishop Meets a Bird (19 January 1971)");
        show.AddEpisode(4, "Episodes 4", "The Bishop Turns to Crime (26 January 1971)");
        show.AddEpisode(5, "Episodes 5", "The Bishop Sees a Ghost (2 February 1971)");
        show.AddEpisode(6, "Episodes 6", "Only Three Can Play (9 February 1971)");

        Shows.Add("Series  1 - Part B");
        Shows.ShowItems[1].AddLink("");
        show = Shows.ShowItems[1];
        show.PartName = "B";
        show.AddEpisode(1, "Episodes 7", "The Dean Goes Primitive (16 February 1971)");
        show.AddEpisode(2, "Episodes 8", "The Bishop Gets a Letter (23 February 1971)");
        show.AddEpisode(3, "Episodes 9", "The Bishop Gives a Party (2 March 1971)");
        show.AddEpisode(4, "Episodes 10", "The Bishop Goes to Town (9 March 1971)");
        show.AddEpisode(5, "Episodes 11", "Give a Dog a Bad Name (16 March 1971)");
        show.AddEpisode(6, "Episodes 12", "The Bishop Gives a Shove (23 March 1971)");
        show.AddEpisode(7, "Episodes 13", "The Bishop Pays a Visit (30 March 1971)");

        Shows.Add("Series  2 - Part A");
        Shows.ShowItems[2].AddLink("");
        show = Shows.ShowItems[2];
        show.PartName = "A";
        show.AddEpisode(1, "Episodes 1", "The Bishop Learns the Facts (24 July 1972)");
        show.AddEpisode(2, "Episodes 2", "The Bishop Takes a Holiday (31 July 1972)");
        show.AddEpisode(3, "Episodes 3", "The Bishop Buys a Car (7 August 1972)");
        show.AddEpisode(4, "Episodes 4", "The Bishop Gets the Sack (14 August 1972)");
        show.AddEpisode(5, "Episodes 5", "The Bishop Has a Flutter (21 August 1972)");
        show.AddEpisode(6, "Episodes 6", "The Affair at Cookham Lock (28 August 1972)");
        show.AddEpisode(7, "Episodes 7", "The Bishop Loves His Neighbour (4 September 1972)");
        show.AddEpisode(8, "Episodes 8", "The Bishop Beats the System (11 September 1972)");
        show.AddEpisode(9, "Episodes 9", "The Bishop Entertains (18 September 1972)");
        show.AddEpisode(10, "Episodes 10", "The Bishop Gains a Reputation (25 September 1972)");

        Shows.Add("Series  2 - Part B");
        Shows.ShowItems[3].AddLink("");
        show = Shows.ShowItems[3];
        show.PartName = "B";
        show.AddEpisode(1, "Episodes 1", "The Bishop Buys a Mug (2 October 1972)");
        show.AddEpisode(2, "Episodes 2", "The Bishop Loses His Chaplain (9 October 1972)");
        show.AddEpisode(3, "Episodes 3", "When In Rome (16 October 1972)");
        show.AddEpisode(4, "Episodes 4", "The Bishop Is Hospitable (23 October 1972)");
        show.AddEpisode(5, "Episodes 5", "The Bishop Gives a Present (30 October 1972)");
        show.AddEpisode(6, "Episodes 6", "The Bishop Takes Up Business (6 November 1972)");
        show.AddEpisode(7, "Episodes 7", "The Bishop Keeps His Diary (13 November 1972)");
        show.AddEpisode(8, "Episodes 8", "The Bishop Warms Up (20 November 1972)");
        show.AddEpisode(9, "Episodes 9", "The Bishop Shows His Loyalty (27 November 1972)");
        show.AddEpisode(10, "Episodes 10", "The Bishop Has a Rest (4 December 1920)");
    }
}