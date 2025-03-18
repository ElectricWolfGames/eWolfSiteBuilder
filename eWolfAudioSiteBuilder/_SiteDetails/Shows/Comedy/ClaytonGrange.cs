using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class ClaytonGrange : AudioBaseDetails
    {
        public ClaytonGrange()
        {
            Title = "Clayton Grange";
            Year = 2012;
            Description = "Comedy set around Clayton Grange, a top secret Scientific Institute with a government brief to solve the global fuel crisis, cheer people up and make war just a bit more gentle.\r\nUnfortunately the scientists tasked to work at Clayton Grange are a bit rubbish at life. And not much better at science.";

            Casts.Add("Professor Saunders", "Anthony Head");
            Casts.Add("Geoff Prowse", "Neil Warhurst");
            Casts.Add("Roger Bucks", "Paul Barnhill");
            Casts.Add("Alice Jameson", "Stephanie Racine");
            Casts.Add("Alan Dobson", "Paul Stonehouse");
            Casts.Add("Gwynnie", "Heather Craney");
            Casts.Add("Ensemble Actor", "Don Gilet");
            Casts.Add("Announcer", "Clive Hayward");

            Production.Add("WRITER", "Neil Warhurst");
            Production.Add("WRITER", "Paul Barnhill");
            Production.Add("PRODUCER", "Marion Nancarrow");
            Production.Add("DIRECTOR", "Marion Nancarrow");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("X3i-1ECz28w");
            Shows.Shows[0].AddEpisode(1, "Episodes 1", "The staff at Clayton Grange are trying to find a way of making the nation happy.");
            Shows.Shows[0].AddEpisode(2, "Episodes 2", "The team of brilliantly stupid scientists attempt to solve the global fuel crisis. With a hamster.");
            Shows.Shows[0].AddEpisode(3, "Episodes 3", "The team attempt to make war just a bit more gentle. Meet the scientists who are a bit rubbish at life. And not much better at science.");
            Shows.Shows[0].AddEpisode(4, "Episodes 4", "Meet the scientists who are a bit rubbish at life. And not much better at science.");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("ITQnEglySlk");
            Shows.Shows[1].AddEpisode(1, "Episodes 1", "The team launch their revolutionary spray-on clothes, a local MP comes to visit to boost his election campaign and an embarrassing virus escapes from genetics and threatens the very nature of democracy.");
            Shows.Shows[1].AddEpisode(2, "Episodes 2", "Professor Saunders hopes to persuade his elderly aunt to leave her fortune to science. Meanwhile, his team develop a gun powered simply by thought, but no-one succeeds in thinking very well.");
            Shows.Shows[1].AddEpisode(3, "Episodes 3", "Geoff cannot resist using a 'bring your child to work day' to do some controversial genetic manipulation, while Saunders trials a bionic suit that recycles your own urine.");
            Shows.Shows[1].AddEpisode(4, "Episodes 4", "Spurred on by Saunders, the weary scientific team tries to impress a visiting Nobel Prize judge with their self-replicating killer robo-ants.");
        }
    }
}