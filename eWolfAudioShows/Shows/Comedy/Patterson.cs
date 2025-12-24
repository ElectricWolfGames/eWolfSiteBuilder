using eWolfAudioShows.Data;
using System;
using System.Collections.Generic;

namespace eWolfAudioShows.Shows.Comedy;

public class Patterson : AudioBaseDetails
{
    public Patterson()
    {
        ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

        Title = "Patterson";
        Year = 1981;
        DateAdded = "";
        OutputPath = "E:\\_AudioTemp\\Comedy\\2026- Uploading\\036 Patterson\\";

        Description = "Patterson is a BBC Radio sitcom about a hapless university lecturer. It was billed as a comedy series in eight parts, written by Malcolm Bradbury and Christopher Bigsby[1] but strictly speaking, it is a serial. The show was produced by Geoffrey Perkins and tells the tale of Doctor Andrew Patterson (Lewis Fiander) who is cajoled by his wife Jane (Judy Parfitt) into accepting a job in the dysfunctional English department of a provincial red-brick university. This is the catalyst for a catalogue of unfortunate events, which sees his life rapidly crumble around him, bit by bit.";

        Casts.Add("Dr Andrew Patterson", "Lewis Fiander");
        Casts.Add("Jane Patterson", "Judy Parfitt");
        Casts.Add("Professor Misty", "Richard Vernon");
        Casts.Add("Vice-Chancellor", "John Barron");
        Casts.Add("Hugh Thomas", "Victor");
        Casts.Add("Amy Spade", "Maggie Steed");
        Casts.Add("Maureen Lipman ", "Melissa");
        Casts.Add("Mary", "Frances Jeater");
        Casts.Add("Cuthbertson", "Richard O'Callaghan");
        Casts.Add("Probity", "Jack May");
        Casts.Add("Mrs Vice - Chancellor", "Irene Prador");
        Casts.Add("Bannerji", "Tariq Yunus");
        Casts.Add("Valerie Candle", "Leueen Willoughby");

        Production.Add("WRITER", "Malcolm Bradbury");
        Production.Add("WRITER", "Christopher Bigsby");
        Production.Add("PRODUCER", "Geoffrey Perkins");
        Production.Add("DIRECTOR", "");

        Shows.Add("Series  1");
        Shows.Shows[0].AddLink("");
        Shows.Shows[0].AddEpisode(1, "Welcome to the Department", "A reluctant academic takes a teaching post at a deeply eccentric university, where colleagues are stranger than fiction and temptation lurks in the corridors. As his wife begins to thrive in their bleak new town, he finds himself increasingly trapped by academia, desire, and domestic chaos.");
        Shows.Shows[0].AddEpisode(2, "First Day, Worst Impressions", "Andrew Patterson’s hopes for a successful first lecture collapse into confusion, academic despair, and moral lectures on faculty misconduct. An evening of temptation and social obligation ends in farce when a minor faux pas turns into public humiliation and a fiery plunge into the lake.");
        Shows.Shows[0].AddEpisode(3, "Borrowed Lawnmowers and Broken Vows", "A sleepless household and workplace absurdities push Andrew Patterson into a frantic quest to retrieve a mysteriously borrowed lawnmower or lose his job. An ill-judged dinner meant to solve the problem ends in betrayal, leaving his marriage in ruins and Andrew out on the street.");
        Shows.Shows[0].AddEpisode(4, "The Inaugural Lecture That Wasn’t", "Reeling from his marital collapse and workplace chaos, Andrew Patterson scrambles to save his job by plagiarising a lecture he never has time to deliver. A humiliating climax ensues when he sleeps through the event and his deception is publicly exposed before the university elite.");
        Shows.Shows[0].AddEpisode(5, "Naked Ambitions", "Seeking refuge from Melissa’s relentless appetites, Patterson channels his energies into writing—only to be exposed as the author of thinly veiled erotic fiction. A disastrous dinner party of misunderstandings, academic paranoia, and drunken accusations ends with his domestic truce collapsing and temptation striking once again.");
        Shows.Shows[0].AddEpisode(6, "Disguises, Desires, and Disaster", "Patterson’s precarious life spirals further as suspicion, infidelity, and departmental intrigue collide, leaving him locked out both professionally and personally. A drunken break-in, a mistaken shooting, and a cascade of arrests bring the farce to a chaotic and humiliating climax.");
        Shows.Shows[0].AddEpisode(7, "Much Ado About Everything", "Living out of his office, Patterson risks his career on a disastrous weekend away with Valerie that entangles him with senior academics, false identities, and Shakespearean excess. A farcical night of banquets, misunderstandings, and narrow escapes ends with his romantic hopes dashed and his humiliation deepened.");
        Shows.Shows[0].AddEpisode(8, "A Fool Takes the Chair", "On the last day of term, personal farewells and political chaos collide as Patterson is improbably handed leadership of a department in total collapse. After revolutions fizzle and romances implode, he finally confronts his own failures—and, on the eve of his 35th birthday, wins a hard-fought reconciliation with his wife.");
    }
}