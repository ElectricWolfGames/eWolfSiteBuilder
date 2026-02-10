using eWolfAudioShows.Data;
using eWolfAudioShows.Data.Enums;
using System.Text;

namespace eWolfAudioShows.Shows_OLD;

public class AudioBaseDetailsOLD : IAudioShowOLD
{
    public CastHolder Casts { get; set; } = new CastHolder();
    public string Channel { get; set; }
    public string DateAdded { get; set; } = string.Empty;
    public string Description { get; set; }
    public string FullDescription { get; set; }
    public string OutputPath { get; set; }
    public CastHolder Production { get; set; } = new CastHolder();
    public ShowHolder Shows { get; set; } = new ShowHolder();
    public ShowTypes ShowTypes { get; set; }
    public string Title { get; set; }
    public string TitleLine2 { get; set; }
    public int Year { get; set; }

    protected void CreateShow()
    {
        string path = $"{OutputPath}\\ShowProcessList.txt";
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Shows.Shows[0].AddLink(\"\");\r\n");

        CreateShows(sb, 1, "Series 1\r\n1. The Workplace\r\nWednesday 2nd November 2005\r\n\r\nProfessor Joy Klamp thinks everyone deserves to feel the fulfilling empowerment of spoiling someone else's fun. This week Joy focuses on the most fertile environment for the manipulation of relationships through non-enjoyment techniques - the workplace.\r\n\r\n2. The Joy Of Sulks\r\nWednesday 9th November 2005\r\n\r\nThis week Professor Joy Klamp looks at the role of the sulk in modern relationships.\r\n\r\n3. Party On Down\r\nWednesday 16th November 2005\r\n\r\nIn this week's guide, Joy Klamp is looking at the joy of parties, and how to take control of these social situations... and spoil them.\r\n\r\n4. Holidays\r\nWednesday 23rd November 2005\r\n\r\nThis week's Mastering The Universe looks at how to extract the maximum emotional leverage from the most precious two weeks of the year, the annual holiday.\r\n\r\n5. Food And Drink\r\nWednesday 30th November 2005\r\n\r\nFor the dedicated passive-aggressive wanting to create tension, induce guilt and exercise control, there's nowhere quite like the dinner table.\r\n\r\n6. Christmas\r\nWednesday 7th December 2005\r\n\r\nIn the final episode of the series, Professor Joy Klamp explains how to overcome the difficult challenge of ruining the season of goodwill.");
        CreateShows(sb, 2, "Series 2\r\n1. DIY\r\nTuesday 24th February 2009\r\n\r\nInvestigating the fun that can be had, at other people's expense, through DIY.\r\n\r\n2. Travel\r\nTuesday 3rd March 2009\r\n\r\nInvestigating the fun that can be had, at other people's expense, through travel.\r\n\r\n3. Children\r\nTuesday 10th March 2009\r\n\r\nInvestigating the fun that can be had, at other people's expense, through the gift of children.\r\n\r\n4. Weekends\r\nTuesday 17th March 2009\r\n\r\nInvestigating the fun that can be had by spoiling other peoples' weekend.");

        //CreateShows(sb, 1, "Series 1\r\n1. Privinvasionacy\r\nMonday 19th November 2007\r\n\r\nIan tries to get people to fill out a survey about people's bodily habits. In particular, their lower body habits.\r\n\r\n2. Eligibilliant\r\nMonday 26th November 2007\r\n\r\nIan attempts to ask children about their views on yogurt, on a rough council estate in the middle of Halloween. He only manages to ask an old woman, who thinks he his Death.\r\n\r\n3. Obselejectivitysence\r\nMonday 3rd December 2007\r\n\r\nIan tries to test out a new electronic system for entering his data on a street where all of the houses are being demolished.\r\n\r\n4. Confidentialitydence\r\nMonday 10th December 2007\r\n\r\nIan tries some product placement around a block of flats, and finds himself embroiled with a love-starved woman.\r\n\r\n5. Incentativity\r\nMonday 17th December 2007\r\n\r\nIan carries out a poll concerning racial tolerance, and is given an added incentive. If he interviews people successfully, he earns food.\r\n\r\n6. Profitch\r\nMonday 24th December 2007\r\n\r\nA trip down a dual carriageway and a meeting with a man who claims to be a prophet lead to Ian making an important decision.");
        //CreateShows(sb, 2, "Series 2\r\n1. Episode One\r\nTuesday 14th October 2014\r\n\r\nA man uncovers a great Australian conspiracy, and a financial advisor starts a sideline as an assassin's assistant.\r\n\r\n2. Episode Two\r\nTuesday 21st October 2014\r\n\r\nOxford Zoo is annexed by its own monkey kingdom, and a young woman falls under the romantic spell of the Great Dimbleby.\r\n\r\n3. Episode Three\r\nTuesday 28th October 2014\r\n\r\nA man gets lost in a breakfast buffet, and a stag party goes very wrong.\r\n\r\n4. Episode Four\r\nTuesday 4th November 2014\r\n\r\nA visit to The Golden Woofers, Grimsby's number one dog show, and a farmer genetically engineers some living sausages.\r\n");
        //CreateShows(sb, 3, "Series 3\r\n1. Episode One\r\nThursday 3rd March 2016\r\n\r\nA woman uncovers the conspiracy behind cryptic crosswords, and a saxophonist is tortured by his inability to play the solo from Baker Street.\r\n\r\n2. Episode Two\r\nThursday 10th March 2016\r\n\r\nA smooth radio station continues broadcasting during civil unrest, we meet a man who can't stop offering people lifts, and drop in on the Depressing Foreign Zoo.\r\n\r\n3. Episode Three\r\nThursday 17th March 2016\r\n\r\nA visit to a magic warehouse, plus a couple who buy the house Chris de Burgh used to own, and a man whose complaints are easily settled on receipt of something free.\r\n\r\n4. Episode Four\r\nThursday 24th March 2016\r\n\r\nA man can't stop accidentally discovering dead bodies, a hotel guest keeps asking for more towels, someone gets too close to the bats he's supposed to studying, and the show goes on board a luxury Seasun cruise.\r\n");
        //CreateShows(sb, 4, "Series 4\r\n1. Episode One\r\nTuesday 12th February 2019\r\n\r\nFeaturing more overblown, melodramatic scenes from modern life, including a visit to the first ever Crufts for Cats and a terrifying reminder as to why you should never try and cancel your membership of The National Trust.\r\n\r\n2. Episode Two\r\nTuesday 19th February 2019\r\n\r\nA woman discovers why there are so many Cornish pasty shops in British train stations and a man tries to return a sleeping bag to John Lewis with dramatic consequences.\r\n\r\n3. Episode Three\r\nTuesday 26th February 2019\r\n\r\nFeaturing the World Small Talk Championships, and a look at a nationwide drug network that operates along the rambling paths of Great Britain.\r\n\r\n4. Episode Four\r\nTuesday 5th March 2019\r\n\r\nA man's his life starts to spiral into chaos.");

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