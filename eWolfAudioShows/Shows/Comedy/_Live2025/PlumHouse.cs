using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy._Live
{
    public class PlumHouse : AudioBaseDetails
    {
        public PlumHouse()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Plum House";
            Year = 2016;
            DateAdded = "2025/11/07";

            Description = "Tom Collyer, sent from the Trust to do just that, seems to be the most likely candidate but the challenge is huge as he confronts the reality of winning round Peter Knight's handpicked team - the hopelessly out of touch deputy Julian (Miles Jupp), the corner-cutting gift shop manager Maureen (Jane Horrocks) who's intent on making profit from extremely cheap plum-themed merchandise, and maintenance man Alan (Pearce Quigley) who has heard the words \"health\" and \"safety\" but never in the same sentence.";

            Casts.Add("Peter", "Simon Callow");
            Casts.Add("Maureen", "Jane Horrocks");
            Casts.Add("Julian", "Miles Jupp");
            Casts.Add("Tom", "Tom Bell");
            Casts.Add("Alan", "Pearce Quigley");
            Casts.Add("Emma", "Louise Ford");
            Casts.Add("Mary", "Kate Anthony");
            Casts.Add("Jean", "Sandra Maitland");

            Production.Add("WRITER", "Ben Cottam");
            Production.Add("WRITER", "Paul McKenna");
            Production.Add("PRODUCER", "Paul Schlesinger");
            Production.Add("DIRECTOR", "Paul Schlesinger");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("V-MtCbXbt4k");
            Shows.Shows[0].AddEpisode(1, "Why Why Wi?", "The museum's preparations for the annual WI visit include hiding away valuable artefacts, as - according to Peter - some members are prone to stealing them. And Julian gives a disastrous lecture on the life and work of George Pudding.");
            Shows.Shows[0].AddEpisode(2, "Perilously Poorly Peter", "Peter is forced to visit town. He leaves his hopelessly out-of-touch deputy Julian in charge, who sees it as a perfect opportunity for him to finally make his mark on the place.");
            Shows.Shows[0].AddEpisode(3, "Trust The Trust", "A mysterious visitor arrives. When he shows genuine interest in how the place is run, the team immediately suspect he has been sent by the Trust to spy on them.");
            Shows.Shows[0].AddEpisode(4, "Peter v Prynne", "Tom has organised a special summer event and invited the great and good from the world of George Pudding scholarship. But with Peter encountering his arch nemesis - the unbearably pompous Mungo Prynne, Julian upsetting a neighbouring farmer and Emma rather enjoying the plum punch, will it be remembered for the right reasons?");
            Shows.Shows[0].AddEpisode(5, "The Rather Risky Ramble", "Tom returns from a team building course in London to find the Plum House team have been bickering in his absence.");
            Shows.Shows[0].AddEpisode(6, "Lights, Camera, Pudding", "The team at the museum are startled to hear that Peter has agreed to Plum House being used as a location in a period drama.");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("sgOmvtZrn3k");
            Shows.Shows[1].AddEpisode(1, "A Sound Investment", "The team are making an audio tour they hope will bring visitors flocking in. But they can't agree on who will star in the recording, and Tom has a bigger problem when he accidentally breaks the most valuable artefact in the museum.");
            Shows.Shows[1].AddEpisode(2, "Thief Encounter", "Peter and Julian are determined to retrieve a valuable pudding artefact and they've enlisted the help of a crooked connection to do so. Emma and Tom try to keep everyone on the straight and narrow - but Maureen finds herself mysteriously drawn to the shady visitor.");
            Shows.Shows[1].AddEpisode(3, "Black Pudding", "The offer of an honorary degree at a less than prestigious ex-polytechnic sends Peter into a depressive spiral, as he questions whether he has wasted his life. The team call on the chief psychiatrist to the academic profession, the radical Doctor Bloch.");
            Shows.Shows[1].AddEpisode(4, "Death Comes To Plum House", "Tom has organised a Murder Mystery event at Plum House. But when a storm prevents the visitors from reaching the museum, the team decide to try the game themselves. Maureen is determined to prove the murderer is Julian, while Peter is carried away with his new person - but a bloodcurdling scream from Alan means the team have a real mystery to solve.");
            Shows.Shows[1].AddEpisode(5, "Hot Quiz", "A local pub quiz becomes the arena to decide who is best and smartest at Plum House after Tom decides that Peter and Julian should no longer be in charge of the finances.");
            Shows.Shows[1].AddEpisode(6, "Wedding Bells", "The team are preparing to host their first wedding at the museum. With a journalist coming to cover the event, it's a publicity coup for Plum House. But the groom has cold feet. Can they carry on regardless with a fake wedding? Tom is dubious - until Julian suggests he might pretend to marry Emma.");

            Shows.Add("Series  3");
            Shows.Shows[2].AddLink("S1TmgBEsp9o");
            Shows.Shows[2].AddEpisode(1, "Better The Devil", "With manager Tom off on leave, the arrival of Roger from Head Office - sent to reform the operation, is a shock to them all. How will they get rid of him and entice Tom back?");
            Shows.Shows[2].AddEpisode(2, "#SO BRITISH", "The curator Peter Knight finds unlikely TV fame when he is featured on an ancestry show helping Derren Brown trace his roots to the museum.");
            Shows.Shows[2].AddEpisode(3, "A Knight to Remember", "The Plum House team are once again invited to the Museum of the Year awards in London, leaving Julian in charge in Tom and Peter's absence.");
            Shows.Shows[2].AddEpisode(4, "Grace and Favour", "Tom hopes to earn some funds for the museum by renting out Peter's apartment. Meanwhile there's love in the air for Tom and Julian, but not in the way either expects...");
            Shows.Shows[2].AddEpisode(5, "All in Good Faith", "The team welcome a new vicar to their parish, and Maureen and Alan try in their own way to help with church repairs and maintenance, to disastrous effect. Meanwhile, Tom tries to patch things up with Emma.");
            Shows.Shows[2].AddEpisode(6, "Fete and Fortune", "Plum House is hosting the annual Summer Fete for the area. Meanwhile Maureen's old nemesis Sue is out to get her...");
        }
    }
}