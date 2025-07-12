using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy
{
    public class Leviathan99 : AudioBaseDetails
    {
        public Leviathan99()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.SciFiDrama;

            Title = "Leviathan 99";
            Year = 1968;
            DateAdded = "";

            Description = "A fantastical adaptation of Moby Dick, Ray Bradbury takes audiences past the moon and the stars in search of the greatest and brightest comet in the universe. Join a deranged captain, an eight-foot-tall telepathic spider, and our reluctant hero. You can call him Ishmael.";

            Casts.Add("Ishmael", "Denys Hawthorne");
            Casts.Add("As Ishmael The Warning Man", "Walter Fitzgerald");
            Casts.Add("Fr Ellery Colworth", "Denis McCarthy");
            Casts.Add("Quell", "Robert Eddison");
            Casts.Add("Redleigh first mate", "Alexander John");
            Casts.Add("Radio man", "Anthony Jackson");
            Casts.Add("Shore", "Nigel Clayton");
            Casts.Add("Rogers", "Christopher Bidmead");
            Casts.Add("Smith", "Ian Thompson");
            Casts.Add("Radarman", "Leroy Lingwood");
            Casts.Add("Metal worker", "Haydn Jones");
            Casts.Add("Captain of the Cetus 7", "Christopher Lee");
            Casts.Add("Ughtfall's captain", "Frank Henderson");
            Casts.Add("Rachel's Captain", "Ralph Truman");

            Production.Add("WRITER", "");
            Production.Add("WRITER", "");
            Production.Add("ADAPTED", "H. B. Fortuin");
            Production.Add("PRODUCER", "H. B. Fortuin");
            Production.Add("DIRECTOR", "");

            Shows.Add(string.Empty);
            Shows.Shows[0].AddLink("");
        }
    }
}