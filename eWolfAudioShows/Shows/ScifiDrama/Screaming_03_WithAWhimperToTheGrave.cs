using eWolfAudioShows.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace eWolfAudioShows.Shows.ScifiDrama
{
    public class Screaming_03_WithAWhimperToTheGrave : AudioBaseDetails
    {
        public Screaming_03_WithAWhimperToTheGrave()
        {
            ShowTypes = Data.Enums.ShowTypes.SciFiDrama;

            Title = "With a Whimper to the Grave";
            Year = 1984;
            DateAdded = "";
            OutputPath = null;

            Description = "The nations of Earth form a World Council with a cunning plan. The aliens reveal their true intentions. To combat the threat of an alien invasion, the nations of the Earth have formed a World Council. The aliens have given certain humans extraordinary 'sixth-sense' powers. But when these powers are abused the aliens prepare to leave and abandon the Earth to its fate. But are they really going? And what is the fate awaiting the peoples of the Earth?";

            Casts.Add("Tom Harris", "John Shrapnel");
            Casts.Add("Sally Harris", "Maureen O'brien");
            Casts.Add("A P Smith", "Donald Hewlett");
            Casts.Add("George", "Patrick Troughton");
            Casts.Add("Prime Minister", "Angela Thorne");
            Casts.Add("642", "Timothy West");

            Production.Add("WRITER", "Wally K Daly");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "With a Whimper to the Grave", "");
        }
    }
}