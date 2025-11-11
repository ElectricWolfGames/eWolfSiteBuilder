using eWolfAudioShows.Data;
using System.Drawing;

namespace eWolfAudioShows.Shows.Comedy
{
    public class Knocker : AudioBaseDetails
    {
        public Knocker()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

            Title = "Knocker";
            Year = 2007;
            DateAdded = "";
            OutputPath = "E:\\_AudioTemp\\Comedy\\_Uploading_B\\31 Knocker\\";

            Description = "Knocker is a BBC 7 sitcom that revolves around the unfortunate exploits of market researcher Ian Dunn, played by Neil Edmond.\r\n";

            Casts.Add("Ian Dunn", "Neil Edmond");
            Casts.Add("Paula Wilcox", "Mary");
            Casts.Add("Julia Deakin", "Ensemble Actor");
            Casts.Add("Tina Gray", "Ensemble Actor");
            Casts.Add("Simon Treves", "Ensemble Actor");
            Casts.Add("", "");

            Production.Add("WRITER", "Neil Edmond ");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "Tilusha Ghelani");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series 1");
            Shows.Shows[0].AddEpisode(1, " Privinvasionacy", "Ian tries to get people to fill out a survey about people's bodily habits. In particular, their lower body habits.");
            Shows.Shows[0].AddEpisode(2, " Eligibilliant", "Ian attempts to ask children about their views on yogurt, on a rough council estate in the middle of Halloween. He only manages to ask an old woman, who thinks he his Death.");
            Shows.Shows[0].AddEpisode(3, " Obselejectivitysence", "Ian tries to test out a new electronic system for entering his data on a street where all of the houses are being demolished.");
            Shows.Shows[0].AddEpisode(4, " Confidentialitydence", "Ian tries some product placement around a block of flats, and finds himself embroiled with a love-starved woman.");
            Shows.Shows[0].AddEpisode(5, " Incentativity", "Ian carries out a poll concerning racial tolerance, and is given an added incentive. If he interviews people successfully, he earns food.");
            Shows.Shows[0].AddEpisode(6, " Profitch", "A trip down a dual carriageway and a meeting with a man who claims to be a prophet lead to Ian making an important decision.");
        }
    }
}