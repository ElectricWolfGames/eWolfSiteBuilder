using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.ScifiDrama._Live2025
{
    public class DeepStationEmerald : AudioBaseDetails
    {
        public DeepStationEmerald()
        {
            ShowTypes = Data.Enums.ShowTypes.SciFiDrama;

            Title = "Deep Station Emerald";
            Year = 1996;
            DateAdded = "2025/07/06";

            Description = "Joe Turner’s drama is a futuristic undersea thriller. The crew of a research base on the ocean floor discovers a source of cold fusion, the solution to all the world’s energy problems. Elation turns to terror, however, when a series of ‘accidents’ causes several deaths, and a strange virus which mutates DNA is loosed… obviously, someone on board is a killer…";

            Casts.Add("Rossi", "Maureen Beattie");
            Casts.Add("Kettle", "Tom Georgeson");
            Casts.Add("Captain Harris", "Danny Webb");
            Casts.Add("O'Connor", "Ricky Tomlinson");

            Production.Add("WRITER", "Joe Turner");
            Production.Add("DIRECTOR", "Martin Jameson");

            Shows.Add(string.Empty);
            Shows.ShowItems[0].AddLink("6gICUwY5K1E");
        }
    }
}