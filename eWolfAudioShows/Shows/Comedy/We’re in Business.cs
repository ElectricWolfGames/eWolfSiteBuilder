using eWolfAudioShows.Data;
using eWolfAudioShows.Shows.Comedy._Live;
using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Printing;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace eWolfAudioShows.Shows.Comedy
{
    public class WereinBusiness : AudioBaseDetails
    {
        public WereinBusiness()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.None;

            Title = "We’re in Business";
            Year = 1959;
            DateAdded = "";
            OutputPath = "E:\\_AudioTemp\\Comedy\\_Uploading_B\\29 We’re in Business";

            Description = "Dudley Grosvenor a dodgy small-time businessman Dudley Grosvenor, who’s always looking to make a fast buck with his crooked schemes - usually at the expense of his hapless sidekick, Harry. Dudley spends his life lurching from one crisis to another, secure in the belief that “it might never happen\" - but when it inevitably does, both men end up in a fix…";

            Casts.Add("Dudley Grosvenor ", "Peter Jones");
            Casts.Add("Harry", "Harry Worth");
            Casts.Add("Granny / Miss Jubilee Boot ", "Irene Handl");
            Casts.Add("Lady Crabbe", "Beryl Reid");
            Casts.Add("Sid / Mr Trumpet", "Dick Emery");
            Casts.Add("Parrot", "Peter Hawkins");
            Casts.Add("Various", "Hugh Paddick");
            Casts.Add("Various", " Doris Hare");
            Casts.Add("Various", "Vivienne Martin, ");
            Casts.Add("Various", "Paddy Edwards");
            Casts.Add("Various", "Wallas Eaton");
            Casts.Add("Various", "John Graham ");
            Casts.Add("Various", "Frederick Treves");

            Production.Add("WRITER", "Peter Jones");
            Production.Add("WRITER", "George Wadmore");
            Production.Add("WRITER", "George Evans,");
            Production.Add("WRITER", "Marty Feldman");
            Production.Add("WRITER", "Barry Took");
            Production.Add("PRODUCER", "Charles Maxwell\r\n");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "Episodes 1", "");
            Shows.Shows[0].AddEpisode(2, "Episodes 2", "");
            Shows.Shows[0].AddEpisode(3, "Episodes 3", "");
            Shows.Shows[0].AddEpisode(4, "Episodes 4", "");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("");
            Shows.Shows[1].AddEpisode(1, "Episodes 1", "");
            Shows.Shows[1].AddEpisode(2, "Episodes 2", "");
            Shows.Shows[1].AddEpisode(3, "Episodes 3", "");
            Shows.Shows[1].AddEpisode(4, "Episodes 4", "");
        }
    }
}