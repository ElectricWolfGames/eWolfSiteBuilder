using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Drama;

public class Haunted : AudioBaseEpisodesShowDetails
{
    public Haunted()
    {
        ShowTypes = Data.Enums.ShowTypes.Drama;

        Title = "HAUNTED:";
        TitleLine2 = "Tales Of The Supernatural";
        OutputPath = "E:\\Aduio_Uploads\\Drama\\2026\\01 Haunted (BBC)\\";

        YTPlayList = "https://www.youtube.com/playlist?list=PL5uFllPR3aCfYvj0shjRZaNAhfFZ0S-EU";

        Year = 1980;
        DateAdded = "2025/02/16";
        OutputPath = "E:\\Aduio_Uploads\\Drama\\2026\\01 Haunted (BBC)\\";

        Description = "A BBC WORLD SERVICE, series of twenty-six episodes, broadcast from 1980-84. It included both classic and original ghost stories in a 30 minute format. They were dramatized by Derek Hoddinott and directed by him, unless otherwise noted.";

        var ep = Episodes.Add("Little Girl Lost");
        ep.Description = "With the recent death of her second husband, Mrs. Grove now stays with her son from her first marriage, Herbert, and his wife, Sally. Sally and Herbert think she has gone mad as she continually talks to her late second husband, John, so they've called in a doctor to take a look at her. But Janet, Herbert and Sally's daughter, believes that Mrs. Grove can talk to her late husband and wants to be able to hear his voice, too. Sally feels she is losing control over her daughter as she gets closer with Mrs. Grove and begs her husband to stop it.";
        ep.Casts.Add("Sally Lake", "Jenny Lyndon");
        ep.Casts.Add("Herbert Lake", "John Carson");
        ep.Casts.Add("Mrs. Grove", "Ruth Dunning");
        ep.Casts.Add("Janet Lake", "Bernadette Windsor");
        ep.Casts.Add("Doctor Raven / John Grove", "Adrian Eagan");

        ep.Production.Add("WRITER", "Rosemary Timperley");
        ep.OutputPath = "01 Little Girl Lost\\";

        // 02
        ep = Episodes.Add("What Was It");
        ep.Description = "July 1854: Harry arrives at No. 28 Twenty-sixth Street in New York City. The house was built years earlier by a prominent merchant who later caused a massive bank fraud scandal, fled to Europe, and died soon after. Once news of his death reached America, rumours quickly spread that the house was haunted.";
        ep.FullDescription = "It is July 1854. Harry has just arrived No.28 Twenty-sixth Street, in New York City. It was built some fifteen or twenty years earlier by a well-known New York merchant, who five years earlier threw the commercial world into convulsions by a stupendous bank fraud. He escaped to Europe, and died not long after of a broken heart. Almost immediately after the news of his decease reached America, and was verified, the report spread in Twenty-sixth Street that No. 28 was haunted.";
        ep.Casts.Add("Harry Crown", "Peter Marinker");
        ep.Casts.Add("Doctor Stephen Hammond", "Blane Fairman");
        ep.Casts.Add("Mrs. Moffatt", "Helen Horton ");

        ep.Production.Add("WRITER", "Fitz-James O'Brien");
        ep.OutputPath = "02 What Was It\\";

        // 03
        ep = Episodes.Add("The Family");
        ep.Description = "As solicitor David Eccleston arrives at his client's (Mr. Watson) lodgings, he is met by a Detective Sergeant who gives him a letter from Watson that he feels he should read before he sees him. The letter is about something peculiar that has happened to him. It concerns a young women by the name of Carol Temple that he met late one night around 1:00 a.m. in front of the boarding house where he lived.";
        ep.Casts.Add("Mr.Watson", "George Cole");
        ep.Casts.Add("Carol Temple", "Janet Maw");
        ep.Casts.Add("Detective Sergeant Forester", "Peter Baldwin");
        ep.Casts.Add("David Eccleston", "John Church");
        ep.Casts.Add("The Nurse", "Elizabeth Ryder");
        ep.Casts.Add("The Reception", "Jane Thompson");
        ep.Casts.Add("Graham Faulkner", "The Policeman");

        ep.Production.Add("WRITER", "John Elliot");
        ep.OutputPath = "03 The Family\\";

        // 04
        ep = Episodes.Add("Walk on Water");
        ep.Description = "Young Rachel finds her whole life blighted by one encounter. A salutary lesson about talking to strangers, as a young girl finds her whole life blighted by one encounter. Stars Anna Cooper as Rachel, Ursula Howells as Mother, Jack May as Father, David Ashford as Peter and Brian Hewlett as the Man. With Brian Haines, Trevor Cooper and Leonard Fenton.";

        ep.Production.Add("WRITER", "Rosemary Timperley");
        ep.OutputPath = "04 Walk on Water\\";

        // 05
        ep = Episodes.Add("The Dream Woman");
        ep.Description = "Isaac lives in constant fear of a knife-wielding female. But is she of this Earth, or from beyond the grave? Stars Charles Kay.";

        ep.Production.Add("WRITER", "Rosemary Timperley");
        ep.OutputPath = "05 The Dream Woman\\";

        // 06
        ep = Episodes.Add("The Decoy");
        ep.Description = "Adapted by Derek Hoddinott from Algernon Blackwood's short story. 'The Decoy' was first published in an anthology entitled: The Wolves of God, and Other Fey Stories, 1921.";
        ep.Casts.Add("", "");

        ep.Production.Add("WRITER", "Rosemary Timperley");
        ep.OutputPath = "06 The Decoy\\";

        // 07
        ep = Episodes.Add("Listen to the Silence");
        ep.Description = "Mary must face her fears. Can she refuse the offer made by a strange voice claiming to be her grandfather? Stars Gwen Watford.";
        ep.Casts.Add("", "");

        ep.Production.Add("WRITER", "Rosemary Timperley");
        ep.OutputPath = "07 Listen to the Silence\\";

        // 08
        ep = Episodes.Add("The Inexperienced Ghost");
        ep.Description = "A man encounters a troubled spirit. But could this meeting lead to tragedy? Adapted by Patricia Mays from H. G. Wells' story.";
        ep.Casts.Add("", "Donald Houston ");
        ep.Casts.Add("", "Christopher Guard");

        ep.Production.Add("WRITER", "H. G. Wells");
        ep.OutputPath = "08 The Inexperienced Ghost\\";

        // 09
        ep = Episodes.Add("Christina");
        ep.Description = "Miss Chaucer tells Dr. Richard she’s deeply depressed after a friend’s death, financial losses, and feeling completely alone. Writing no longer brings her joy. He advises her to leave London and start fresh somewhere new. She moves to a village, meets Mrs. Crozier, and encounters Christina—the ghost of a child connected to the house—but the reason for the haunting remains a mystery.";
        ep.FullDescription = "Miss Chaucer tells Dr. Richard that she is so depressed - in part due to the recent death of a friend - she have tried to shake it off but with no luck. Since Mary's death she has can't seem to take the same pleasure in writing, especially children stories. Also, before Mary died she had lost a lot of money - mostly to oversea investments. She has no family to turn to for hope or advise.\r\n\r\nMary would have helped her had she been well enough. To an extent, Mary was her family. She's is alone now. It is that fact that depresses and frightens her. Dr. Richard tells her that she has to get away. A fresh environment; a new locality; to get out of London; to find a new village somewhere and make new friends - find a new rhythm for her life and then rethink her future. That is what she did and that is how she came to meet Mrs. Crozier, the housekeeper, and Christina, the ghost of a child who has come back to the house where she once lived. But why?";
        ep.Casts.Add("", "");

        ep.Production.Add("WRITER", "Daphne Castell");
        ep.OutputPath = "09 Christina\\";

        // 10
        ep = Episodes.Add("The Late Departure");
        ep.Description = "Peter Harrington is a 43-year-old workaholic who is overweight, a smoker, and has high blood pressure. His business associates and wife keep telling him that he will drop dead one day if he doesn't completely change his lifestyle. One day, after another hectic day at work, he runs to the station to catch the 11:00 p.m. train home. As he sits in one of the compartments, time starts to drift past 11:00 p.m. with no train departure. Slowly, he starts to see that all those around him, railway emloyees and passengers, act strangely towards him as none are concerned about the late departure. Where is this train going and will he ever get home?";
        ep.FullDescription = "";
        ep.Casts.Add("", "");

        ep.Production.Add("WRITER", "Glen Chandler");
        ep.OutputPath = "10 The Late Departure\\";

        // 11
        ep = Episodes.Add("Esmeralda");
        ep.Description = "Felix might finally be free of his wife, but who is the mysterious woman claiming to be his daughter? Starring George Baker";
        ep.FullDescription = "";
        ep.Casts.Add("", "George Baker");

        ep.Production.Add("WRITER", "Glen Chandler");
        ep.OutputPath = "11 Esmeralda\\";

        // 12
        ep = Episodes.Add("A Pair of Hands");
        ep.Description = "A gentle ghost story about Margaret, a seven-year-old girl who died of diphtheria. Her small hands quietly appear in Miss Poulton’s rented house, cleaning and caring for everything to keep it safe from illness. Far from frightening, she is a kind and comforting presence who softly looks after the home and its occupant.";
        ep.FullDescription = "More than causing goose pimples, this tender tale tugs at the heartstrings with its touching description of the antics of the \"most harmless ghost in the world.\" The pair of hands that show up in the house rented by Miss Poulton belong to a girl Margaret, who had died of diptheria at the tender age of seven. Ever since, her little hands appear every now and then to dust and clean the house with an almost obsessive desire to keep it free of infection. So unobtrusive and gentle is the dead girl’s presence that hers is the friendliest ghost. As Miss Poulton says of this sweet spirit: she \"smoothed my pillow, touched and made my table comely, in summers lifted the heads of the flowers as I passed\" The short story 'A Pair of Hands' by Arthur Quiller-Couch (1863 - 1944) was first published in 1898.";
        ep.Casts.Add("", "");

        ep.Production.Add("WRITER", "Arthur Quiller-Couch");
        ep.OutputPath = "12 A Pair of Hands\\";

        // 13
        ep = Episodes.Add("Keeping His Promise");
        ep.Description = "While studying late, Jack Marriott—a fourth-year student at Edinburgh University—feels a sudden chill before an old friend, Ambrose Field, appears in a desperate state. After helping him, Marriott realises something is deeply wrong, and a long-forgotten promise returns to haunt him in a very literal way.";
        ep.FullDescription = "A sudden queer sensation of fear passed over him—a faintness and a shiver down the back. It went, however, almost as soon as it came, and he was just debating whether he would call aloud.to his invisible visitor, or slam the door and return to his books, when the cause of the disturbance turned the corner very slowly and came into view…\r\n\r\nThis tale concerns a young man by the name of Jack Marriott who is a fourth year student at Edinburgh University. One night he is cramming for his finals when his friend, Ambrose Field, from a long time ago knocks on the door in a terrible state. His friend is close to starvation, and so Marriot feeds him and sets him to sleep. As his friend sleeps,\r\n\r\nMarriott discovers that nothing is quite as it seems with the situation. A promise that was made a long time ago seems to have come back to haunt him – literally.\r\n";
        ep.Casts.Add("", "");

        ep.Production.Add("WRITER", "Algernon Blackwood");
        ep.OutputPath = "13 Keeping His Promise\\";

        // 14
        ep = Episodes.Add("Which One");
        ep.Description = "A fire warden team are put to the toughest test during a 1940 bombing raid. Will they all survive? Stars Reginald Marsh.";
        ep.Casts.Add("", "");

        ep.Production.Add("WRITER", "Ronald Chetwynd-Hayes");
        ep.OutputPath = "14 Which One";

        // 15
        ep = Episodes.Add("The Judge's House");
        ep.Description = "Malcolm Malcolmson discovers the truth of the 'absurd prejudices' which have accrued around an empty property.";

        ep.Casts.Add("Malcolmson", "Nigel Havers ");
        ep.Casts.Add("Mrs Dempster", "Nancy Nevinson");
        ep.Casts.Add("Mrs Witham", "Jane Thompson");
        ep.Casts.Add("", "David Timson");
        ep.Casts.Add("", "Alexander John");

        ep.Production.Add("WRITER", "Bram Stoker");
        ep.OutputPath = "15 The Judge's House";

        // 16
        ep = Episodes.Add("The Emissary");
        ep.Description = "Young Marion is unwell, but her pet dog keeps her in touch with the outside world. And beyond. Stars Jennie Linden";
        ep.Casts.Add("", "Jennie Linden");

        ep.Production.Add("WRITER", "Ray Bradbury");
        ep.OutputPath = "16 The Emissary";

        // 17
        ep = Episodes.Add("Legal Rites");
        ep.Description = "Adapted by Patricia Mays from Isaac Asimov & James Maccreag's short story. Starring Ed Bishop and directed by Derek Hoddinott";
        ep.Casts.Add("", "");

        ep.Production.Add("WRITER", "Isaac Asimov");
        ep.Production.Add("WRITER", "James Maccreag");
        ep.OutputPath = "17 Legal Rites";

        // 18
        ep = Episodes.Add("Mists of Memory");
        ep.Description = "Young cellist Janet meets a confused old man. He wonders if 'music is where I live'. And he seems familiar. Stars Helen Worth.";
        ep.Casts.Add("", "Helen Worth");

        ep.Production.Add("WRITER", "Rosemary Timperley");
        ep.OutputPath = "18 Mists of Memory";

        // 19
        ep = Episodes.Add("The Lamp");
        ep.Description = "A sickly young boy settles into a new address, but his ghostly playmate has other ideas. Stars Judy Cornwell and Timothy Bateson.";
        ep.Casts.Add("", "Judy Cornwell");
        ep.Casts.Add("", "Timothy Bateson");

        ep.Production.Add("WRITER", "Agatha Christie");
        ep.OutputPath = "19 The Lamp";

        // 20
        ep = Episodes.Add("Channel Crossing");
        ep.Description = "Can a family holiday overcome all the issues that divide a bickering family? Stars Peter Sallis and Nicholas Lyndhurst.";
        ep.Casts.Add("", "Peter Sallis");
        ep.Casts.Add("", "Nicholas Lyndhurst");

        ep.Production.Add("WRITER", "Rosemary Timperley");
        ep.OutputPath = "20 Channel Crossing\\";

        // 21
        ep = Episodes.Add("The Liberated Tiger");
        ep.Description = "Roland is dying. But could he possibly be haunting his wife while he is still alive? Stars Rosemary Leach and Leslie Sands.";
        ep.Casts.Add("", "Rosemary Leach");
        ep.Casts.Add("", "Leslie Sands");

        ep.Production.Add("WRITER", "Ronald Chetwynd-Hayes");
        ep.OutputPath = "21 The Liberated Tiger\\";

        // 22
        ep = Episodes.Add("The Dead Man of Varley Grange ");
        ep.Description = "Jack is set for a good time at a friend's new property, but why do strange rumors persist about the house? Stars George Baker.";
        ep.Casts.Add("", "George Baker");

        ep.Production.Add("ADAPTED", "Patricia Mays");
        ep.Production.Add("DIRECTED", "Martin Williamson");
        ep.OutputPath = "22 The Dead Man of Varley Grange\\";

        // 23
        ep = Episodes.Add("To Kill A Ghost");
        ep.Description = "";
        ep.Casts.Add("", "");

        ep.Production.Add("WRITER", "Elizabeth S. Holding");
        ep.Production.Add("ADAPTED", "Patricia Mays");
        ep.OutputPath = "23 To Kill A Ghost\\";

        // 24
        ep = Episodes.Add("The Grey Ones");
        ep.Description = "A patient fears evil is at work in the shape of a sinister conspiracy. Will his psychiatrist be able to help? Stars Tony Britton.";
        ep.Casts.Add("", "Tony Britton");

        ep.Production.Add("WRITER", "J.B. Priestley");
        ep.OutputPath = "24 The Grey Ones\\";

        // 25
        ep = Episodes.Add("Only Child");
        ep.Description = "";
        ep.Casts.Add("", "");

        ep.Production.Add("WRITER", "Francis Stephens");
        ep.OutputPath = "25 Only Child\\";

        // 26
        ep = Episodes.Add("The Firmin Child");
        ep.Description = "Keeping His Promise by Algernon Blackwood, Two schoolfriends take a blood oath. Will they keep to it?";
        ep.Casts.Add("", "");

        ep.Production.Add("WRITER", "Richard Blum");
        ep.OutputPath = "26 The Firmin Child\\";
    }
}