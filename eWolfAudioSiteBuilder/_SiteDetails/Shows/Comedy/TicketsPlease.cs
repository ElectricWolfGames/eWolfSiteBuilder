using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class TicketsPlease : AudioBaseDetails
    {
        public TicketsPlease()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Tickets Please!";
            Year = 2009;
            DateAdded = "2024/12/13";

            Description = "Why does an intercity train journey turn into an emotional roller-coaster? Because the train staff have to battle with their thwarted infatuations - for each other! And those toughies in the wedding carriage aren't helping matters...";

            Casts.Add("Robin", "Jeremy Swift");
            Casts.Add("Nadine", "Alex Kelly");
            Casts.Add("Peter", "Malcolm Tierney");
            Casts.Add("Diana", "Melissa Advani");
            Casts.Add("Linda / Lady", "Kate Layden");
            Casts.Add("Keith", "Stephen Hogan");
            Casts.Add("Carol", "Tessa Nicholson");
            Casts.Add("Man One", "Philip Fox");
            Casts.Add("Man Two/ William", "Joseph Cohen-Cole");

            Production.Add("WRITER", "Mark Maier");
            Production.Add("PRODUCER", "Peter Kavanagh");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("UVjcugMCaxM");
            Shows.Shows[0].AddEpisode(1, "Episodes 1", "Why does an intercity journey turn into an emotional rollercoaster? Because the train staff have to battle with their thwarted infatuations for each other. And those toughies in the wedding carriage aren't helping matters.");
            Shows.Shows[0].AddEpisode(2, "Episodes 2", "The 9.27 London to Exeter emotional rollercoaster continues as the train staff's personal embroilments deepen. Now one of the wedding party is joining in the melee. And why are there finger-holes in the muffins?");
            Shows.Shows[0].AddEpisode(3, "Episodes 3", "Love among the train-staff on the 9.27 London to Exeter flourishes. But with the unwelcome addition of Diana's amorous mum. And why is her Dad squashing Carol's muffins?");
            Shows.Shows[0].AddEpisode(4, "Episodes 4", "After delays caused by lightning, a 20-piece orchestra in coach G practices. This offers Robin a plangent background for his declaration of love. But can he seize his chance before the train arrives at Exeter St David's?");
        }
    }
}