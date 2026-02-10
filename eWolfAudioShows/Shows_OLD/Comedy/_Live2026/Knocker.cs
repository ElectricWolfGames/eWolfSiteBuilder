using System.Drawing;

namespace eWolfAudioShows.Shows_OLD.Comedy._Live2026;

public class Knocker : AudioBaseDetailsOLD
{
    public Knocker()
    {
        ShowTypes = Data.Enums.ShowTypes.Comedy;

        Title = "Knocker";
        Year = 2007;
        DateAdded = "2026/01/09";
        OutputPath = "E:\\_AudioTemp\\Comedy\\2026- Uploading\\031 Knocker\\";

        Description = "Knocker is a BBC 7 sitcom that revolves around the unfortunate exploits of market researcher Ian Dunn, played by Neil Edmond.\r\n";
        FullDescription = "Knocker is a BBC 7 sitcom that revolves around the unfortunate exploits of market researcher Ian Dunn, played by Neil Edmond.\r\n\r\nIan works as the soul surviving member of the International Query Board UK. The fact Ian is the only employee left is not surprising, considering that his work involves going out in revolting weather, approaching people in the street or at their own homes, and asking these total strangers very personal questions. All this, and he is only armed with a series of stupid questions, a broken clipboard and the Market Research Code of Conduct.\r\n\r\nAlmost every episode features Ian being humiliated by the people he has to try and canvas. He suffers constant humiliation by those who refuse to answer him, and those who do answer his polls... because they tend to be deranged.\r\n\r\nApart from that, Ian's other source of woe is his own boss Mary (Paula Wilcox). Mary, while seeming to be kind to Ian, actually just wants him to get the figures at any cost. She even suggests to him that it is acceptable for him to bend the rules - something Ian finds abhorrent.\r\n\r\nOther than Ian, Mary's other problems come from Andre, a character who never appears, but it is clear from Mary's description of him that he tends to be accident prone.\r\n\r\n";

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
        Shows.ShowItems[0].AddLink("vv33LADiixY");
        Shows.ShowItems[0].AddEpisode(1, " Privinvasionacy", "Ian tries to get people to fill out a survey about people's bodily habits. In particular, their lower body habits.");
        Shows.ShowItems[0].AddEpisode(2, " Eligibilliant", "Ian attempts to ask children about their views on yogurt, on a rough council estate in the middle of Halloween. He only manages to ask an old woman, who thinks he his Death.");
        Shows.ShowItems[0].AddEpisode(3, " Obselejectivitysence", "Ian tries to test out a new electronic system for entering his data on a street where all of the houses are being demolished.");
        Shows.ShowItems[0].AddEpisode(4, " Confidentialitydence", "Ian tries some product placement around a block of flats, and finds himself embroiled with a love-starved woman.");
        Shows.ShowItems[0].AddEpisode(5, " Incentativity", "Ian carries out a poll concerning racial tolerance, and is given an added incentive. If he interviews people successfully, he earns food.");
        Shows.ShowItems[0].AddEpisode(6, " Profitch", "A trip down a dual carriageway and a meeting with a man who claims to be a prophet lead to Ian making an important decision.");
    }
}
