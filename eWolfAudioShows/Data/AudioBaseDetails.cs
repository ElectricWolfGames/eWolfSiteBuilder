using eWolfAudioShows.Data.Enums;
using eWolfAudioShows.Interfaces;
using System.Text;

namespace eWolfAudioShows.Data
{
    public class AudioBaseDetails : IAudioShow
    {
        public CastHolder Casts { get; set; } = new CastHolder();
        public string Channel { get; set; }
        public string DateAdded { get; set; } = string.Empty;
        public string Description { get; set; }
        public string OutputPath { get; set; }
        public CastHolder Production { get; set; } = new CastHolder();
        public ShowHolder Shows { get; set; } = new ShowHolder();
        public ShowTypes ShowTypes { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        protected void CreateShow()
        {
            string path = $"{OutputPath}\\ShowProcessList.txt";
            StringBuilder sb = new StringBuilder();

            CreateShows(sb, 1, "Series 1\r\n1. Episode One\r\nTuesday 22nd October 2013\r\n\r\nFeaturing commentary from the World Ham Shouting Championships and a couple who are being harassed by a former England football hero.\r\n\r\n2. Episode Two\r\nTuesday 29th October 2013\r\n\r\nFeaturing a pair of long-lost brothers meeting for the first time, a moth that runs amok on a submarine and the world's most literal voiceover artist.\r\n\r\n3. Episode Three\r\nTuesday 5th November 2013\r\n\r\nIn this episode we hear about the cosmetic benefits of old men's legs and the Witness Protection Conference 2013.\r\n\r\n4. Episode Four\r\nTuesday 12th November 2013\r\n\r\nComedy sketch series with Daniel Rigby, Henry Paker, Mike Wozniak and Sara Pascoe.\r\n");
            CreateShows(sb, 2, "Series 2\r\n1. Episode One\r\nTuesday 14th October 2014\r\n\r\nA man uncovers a great Australian conspiracy, and a financial advisor starts a sideline as an assassin's assistant.\r\n\r\n2. Episode Two\r\nTuesday 21st October 2014\r\n\r\nOxford Zoo is annexed by its own monkey kingdom, and a young woman falls under the romantic spell of the Great Dimbleby.\r\n\r\n3. Episode Three\r\nTuesday 28th October 2014\r\n\r\nA man gets lost in a breakfast buffet, and a stag party goes very wrong.\r\n\r\n4. Episode Four\r\nTuesday 4th November 2014\r\n\r\nA visit to The Golden Woofers, Grimsby's number one dog show, and a farmer genetically engineers some living sausages.\r\n");
            CreateShows(sb, 3, "Series 3\r\n1. Episode One\r\nThursday 3rd March 2016\r\n\r\nA woman uncovers the conspiracy behind cryptic crosswords, and a saxophonist is tortured by his inability to play the solo from Baker Street.\r\n\r\n2. Episode Two\r\nThursday 10th March 2016\r\n\r\nA smooth radio station continues broadcasting during civil unrest, we meet a man who can't stop offering people lifts, and drop in on the Depressing Foreign Zoo.\r\n\r\n3. Episode Three\r\nThursday 17th March 2016\r\n\r\nA visit to a magic warehouse, plus a couple who buy the house Chris de Burgh used to own, and a man whose complaints are easily settled on receipt of something free.\r\n\r\n4. Episode Four\r\nThursday 24th March 2016\r\n\r\nA man can't stop accidentally discovering dead bodies, a hotel guest keeps asking for more towels, someone gets too close to the bats he's supposed to studying, and the show goes on board a luxury Seasun cruise.\r\n");
            CreateShows(sb, 4, "Series 4\r\n1. Episode One\r\nTuesday 12th February 2019\r\n\r\nFeaturing more overblown, melodramatic scenes from modern life, including a visit to the first ever Crufts for Cats and a terrifying reminder as to why you should never try and cancel your membership of The National Trust.\r\n\r\n2. Episode Two\r\nTuesday 19th February 2019\r\n\r\nA woman discovers why there are so many Cornish pasty shops in British train stations and a man tries to return a sleeping bag to John Lewis with dramatic consequences.\r\n\r\n3. Episode Three\r\nTuesday 26th February 2019\r\n\r\nFeaturing the World Small Talk Championships, and a look at a nationwide drug network that operates along the rambling paths of Great Britain.\r\n\r\n4. Episode Four\r\nTuesday 5th March 2019\r\n\r\nA man's his life starts to spiral into chaos.");

            sb.AppendLine();
            File.WriteAllText(path, sb.ToString());
        }

        private void CreateShows(StringBuilder sb, int show, string all)
        {
            string[] lines = all.Split("\r\n");

            int lineType = 1;
            string epTitle = string.Empty;
            int epCount = 1;
            foreach (var line in lines)
            {
                if (line.StartsWith("Series"))
                {
                    sb.AppendLine(string.Empty);
                    sb.AppendLine(string.Empty);
                    sb.AppendLine($"Shows.Add(\"Series {show}\");");
                    lineType = 1;
                    continue;
                }
                if (lineType == 1)
                {
                    epTitle = line;
                    lineType = 2;
                    continue;
                }
                if (lineType == 2)
                {
                    lineType = 3;
                    continue;
                }
                if (lineType == 3)
                {
                    lineType = 4;
                    continue;
                }
                if (lineType == 4)
                {
                    lineType = 5;
                    sb.AppendLine($"Shows.Shows[{show - 1}].AddEpisode({epCount}, \"{epTitle.Substring(2)}\", \"{line}\");");
                    epCount++;
                    continue;
                }
                if (lineType == 5)
                {
                    lineType = 1;
                    continue;
                }
            }
        }
    }
}