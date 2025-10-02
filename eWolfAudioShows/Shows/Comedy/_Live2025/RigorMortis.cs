using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy
{
    public class RigorMortis : AudioBaseDetails
    {
        public RigorMortis()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

            Title = "Rigor Mortis";
            Year = 2003;
            DateAdded = "2025/05/23";
            OutputPath = "E:\\_AudioTemp\\Comedy\\_Uploading_B\\18 Rigor Mortis\\";

            Description = "Meet Dr Anthony Webster and Dr Ruth Anderson, two pathologists attempting to live normal lives in an atmosphere of death, decay and seriously unpleasant smells. Anthony loves his chosen profession, finding every cadaver exciting and surprising: 'they're like Kinder eggs that have died'. Ruth, however, longs for a juicy murder mystery, instead of one routine autopsy after another.";

            Casts.Add("Dr Anthony Webster", "Peter Davison");
            Casts.Add("Dr Ruth Anderson", "Tracy - Ann Oberman / Matilda Ziegler");
            Casts.Add("Professor Donaldson", "Geoffrey Whitehead");
            Casts.Add("Gordon", "Tom Price");
            Casts.Add("Chloe", "Marianne Levy");
            Casts.Add("Simon", "Gus Brown");
            Casts.Add("David / Patient", "Stephen Critchlow");
            Casts.Add("Elaine / Mrs.Fitzherbert / Alison / Mrs.Wealands / Mrs.Dance", "Beth Chalmers");
            Casts.Add("Mrs.Renfield", "Rachel Atkins");
            Casts.Add("Daniel Kasper", "Laurence Howarth");
            Casts.Add("Margaret", "Lauren Bird");
            Casts.Add("Prof.Van den Hoogenband", "Chris Pavlo");
            Casts.Add("Mr.Reeve", "Nicholas Boulton");
            Casts.Add("Mrs.Anderson", "Paula Wilcox");
            Casts.Add("Norman", "Lewis Aaltonen");
            Casts.Add("Dr Betzatzoglu", "Alex Lowe");
            Casts.Add("Matthew", "Steven Kynman");
            Casts.Add("Mrs.Wantage", "Felicity Montagu");
            Casts.Add("Mr.Wantage", "Kim Wall");
            Casts.Add("Dorothy", "Joanna Brookes");
            Casts.Add("Interviewer / Mr.Dance", "Gerard McDermott");

            Production.Add("WRITER", "Laurence Howarth");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            var show = Shows.Add("Series  1");
            show.AddLink("SjJTapxfFkk");
            show.AddEpisode(1, "Episode 1");
            show.AddEpisode(2, "Episode 2");
            show.AddEpisode(3, "Episode 3");
            show.AddEpisode(4, "Episode 4");
            show.AddEpisode(5, "Episode 5");
            show.AddEpisode(6, "Episode 6");

            show = Shows.Add("Series  2");
            show.AddLink("el9Owax_C1c");
            show.AddEpisode(1, "Episode 1");
            show.AddEpisode(2, "Episode 2");
            show.AddEpisode(3, "Episode 3");
            show.AddEpisode(4, "Episode 4");
            show.AddEpisode(5, "Episode 5");
            show.AddEpisode(6, "Episode 6");

            show = Shows.Add("Series  3");
            show.AddLink("8wLiNW-2ueI");
            show.AddEpisode(1, "Episode 1");
            show.AddEpisode(2, "Episode 2");
            show.AddEpisode(3, "Episode 3");
            show.AddEpisode(4, "Episode 4");
            show.AddEpisode(5, "Episode 5");
            show.AddEpisode(6, "Episode 6");
        }
    }
}