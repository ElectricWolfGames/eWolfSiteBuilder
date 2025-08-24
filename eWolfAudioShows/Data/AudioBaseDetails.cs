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

            CreateShows(sb, 1, "Series 1\r\n1. A Childhood Cruelly Kippered\r\nWednesday 15th August 2007\r\n\r\nThe idyllic life of young Pip Bin is ruined by the scheming of his exceedingly evil guardian, Mr Gently Benevolent, and his incarceration in Britain's most violent school, St Bastards.\r\n\r\n2. An Adolescence Utterly Trashed\r\nWednesday 22nd August 2007\r\n\r\nPip meets a mysterious aged crone who can help him escape from Britain's most terrifying school and the clutches of his evil guardian.\r\n\r\n3. A Youth Utterly Crocked\r\nWednesday 29th August 2007\r\n\r\nPip must thwart the plans of his evil guardian Mr Gently Benevolent. Can underwater squirrels, oddly placed church bells and a stint in the workhouse foil him in his noble quest? Or will Aunt Lily and her Gloucestershire racing cows save the day?\r\n\r\n4. A Young Adulthood Bitterly Dismantled\r\nWednesday 5th September 2007\r\n\r\nPip finds himself saved from the workhouse with the arrival of a vast sum of money from a mysterious stranger.\r\n\r\n5. A Young Love Mercilessly Dismembered\r\nWednesday 12th September 2007\r\n\r\nPip falls in love with the beautiful but terminally feeble Flora Dies Early. Meanwhile Pippa and Mr Parsimonious flee to the continent. Will the evil Mr Benevolent catch them, or will Aunt Lily save the day again?\r\n\r\n6. A Life Sadly Smashed...Then Happily Restored A Bit\r\nWednesday 19th September 2007\r\n\r\nThings look grim for Pip as he faces a lengthy and highly prejudicial court case. Is he to be hanged, or will there be a last-minute escape followed by a thrilling chase, several duels, a jar of exotic jam and at least two weddings?\r\n");
            CreateShows(sb, 2, "Series 2\r\n1. A Happy Life, Cruelly Re-Kippered\r\nThursday 7th August 2008\r\n\r\nPip Bin struggles against the cruel plotting of his evil guardian Mr Gently Benevolent, recently returned from the dead. A plot is afoot to steal Britain's loveliest school, St Lovely's.\r\n\r\n2. A Re-Kippered Life Smashed Some More\r\nThursday 14th August 2008\r\n\r\nPip and Harry find themselves building an entire railway network in their bid to catch the evil Mr Gently Benevolent.\r\n\r\n3. A Recovery All Made Miserable\r\nThursday 21st August 2008\r\n\r\nYoung Pip is nursed back to health by the Reverend Fecund and his hideously ugly daughter Ripley.\r\n\r\n4. A Restoration Re-Ruined Only Even Worse\r\nThursday 28th August 2008\r\n\r\nPip is heavily in debt when he has to bribe the whole of the House of Commons not to hang him.\r\n\r\n5. Already Bad Life Made Worse But Sort Of On Purpose\r\nThursday 4th September 2008\r\n\r\nFull of self-loathing, Pip drinks some very strong gin, finds he is really quite keen on opium, and falls in with a gang of thieves. But is their leader Abraham Bagel, all he seems?\r\n\r\n6. Happy Life Broken And Then Mended A Bit\r\nThursday 11th September 2008\r\n\r\nThe planet is in deadly peril when Gently Benevolent summons a massive Martian invasion. Is this the end for Pip, Harry and the rest of the human race, not to mention Pippa's goose sanctuary?\r\n");
            CreateShows(sb, 3, "Series 3\r\n1. A Lovely Life Re-Kippered Again Once More\r\nThursday 29th October 2009\r\n\r\nPip Bin's happiness is shattered once again. Fog-filled streets, murders, and ghastly apparitions from beyond the grave abound, and through it all echoes the terrible menacing coo of a possessed and evil pigeon.\r\n\r\n2. A Now Grim Life Yet More Grimified\r\nThursday 5th November 2009\r\n\r\nPip Bin faces his most gruelling fate yet at the hands of his evil undead ex-guardian and an enormous quantity of cheese. But can the spirits of Harvest Festival past, present and future show him a way to redemption?\r\n\r\n3. A Sort Of Fine Life De-Niced Completely\r\nThursday 12th November 2009\r\n\r\nPip Bin strives to improve working conditions in his Bin factory, and to end poverty once and for all using Harry Biscuit's anti-poverty cannon. But will his quest distract him from a dastardly plan to steal London and sell it to the French?\r\n\r\n4. A Horrible Life Un-Ruined And Then Re-Ruined A Lot\r\nThursday 19th November 2009\r\n\r\nPip, Harry, Pippa and Ripely are reduced to abject poverty on the banks of the Thames. Will Pip and Harry be able to find work, or will they have to end their days eating mud and listening to the gloating of Mr Benevolent?\r\n\r\n5. An Evil Life Sort Of Explained\r\nThursday 26th November 2009\r\n\r\nPip Bin, Harry Biscuit and Gently Benevolent find themselves trapped in the vast emptiness of space. As their doom looks increasingly inevitable, Mr Benevolent finally explains just why it is that he is so very very evil.\r\n\r\n6. Lives Lost, Ruined, Wrecked And Redeemed\r\nThursday 3rd December 2009\r\n\r\nPip and Ripely find themselves facing a vast and evil undead army. England has only one hope - that Miss Sweetly Delightful can melt Mr Benevolent's cruel, undead heart.\r\n");
            CreateShows(sb, 4, "Series 4\r\n1. A Tolerable Life De-Happified\r\nThursday 11th November 2010\r\n\r\nPip must enlist the help of his former nemesis to fight a new evil spreading terror and cake-crumbs through the streets of London.\r\n\r\n2. A Now Spoilt Life Smashed Some More\r\nThursday 18th November 2010\r\n\r\nPip and Harry journey to the Underworld to rescue Ripely, only to find the evil Mister Benevolent has got there first.\r\n\r\n3. A Wretched Life Made Much Much Sadder\r\nThursday 25th November 2010\r\n\r\nAfter an embarrassing disaster involving a bridge and a train full of puppies and orphans, Pip and Harry travel to America on the SS Massive Britain.\r\n\r\n4. A Painful Life Further Re-Miserabled\r\nThursday 2nd December 2010\r\n\r\nPip and Harry put to sea with Captain Beehab until they are shipwrecked. What secrets does the mysterious volcanic island hold?\r\n\r\n5. A Now Tricky Life Woefully Miseried Up\r\nThursday 9th December 2010\r\n\r\nPip and Harry pursue the evil Mister Benevolent to France, to a dark and pungent fate awaits them. Guest starring David Mitchell.\r\n\r\n6. A Life Destroyed, And Then Repaired And Re-Happied\r\nThursday 16th December 2010\r\n\r\nOur hero Pip faces his nemesis Mister Benevolent for an epic Russian battle.");
            CreateShows(sb, 5, "Series 5\r\n1. A Pleasant Yet Dull Life Re-Evilled\r\nTuesday 20th November 2012\r\n\r\nPip Bin is beginning to miss the conflict with his absent evil nemesis Mr Gently Benevolent, when he receives an intriguing invitation to a house party with Britain's poshest man.\r\n\r\n2. A Re-Excited Life Made Distinctly Dangerous\r\nTuesday 27th November 2012\r\n\r\nPip and his friends travel to India, in their quest to thwart the evil machinations of smooth but sinister genius Mr Gently Benevolent. Gasp as our heroes struggle with super-intelligent tigers, giant snakes, and secret gin!\r\n\r\n3. An Alrightish Life Savagely Frozen To Bits\r\nTuesday 4th December 2012\r\n\r\nPip races to Antarctica to thwart another fiendish plot by his evil ex-guardian, Mr Gently Benevolent.\r\n\r\n4. A Writerly Life Made Dreadfully Different\r\nTuesday 11th December 2012\r\n\r\nPip and Charles Dickens engage in a novel-writing showdown to find out who is the greatest writer in Britain.\r\n\r\n5. A Terrifying Life Made Even Scarier A Bit Some More\r\nTuesday 18th December 2012\r\n\r\nA new and terrible danger threatens Victorian Britain, as Harry Biscuit becomes possessed by the evil Pen of Penrith, which turns his heart to inky black.\r\n\r\n6. A Loved-Up Life Potentially Totally Annihilated\r\nTuesday 25th December 2012\r\n\r\nMister Gently Benevolent unveils an advent calendar of evil that will culminate on Christmas day with the total destruction of the universe.");

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