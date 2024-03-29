#region Copyright Notice and source url
//
// This content contains copyright material. The material
// format has been change to support the needs of the
// Application.  In particular the table entries and
// values have the following copyright notice.
//
// The content is from the url:
// https://www.d20pfsrd.com/basics-ability-scores/more-character-options/character-backgrounds/background-generator
//
// Pathfinder Roleplaying Game: Ultimate Campaign.
// ©2013, Paizo Publishing, LLC;
// Authors: Jesse Benner, Benjamin Bruck, Jason Bulmahn,
// Ryan Costello, Adam Daigle, Matt Goetz, Tim Hitchcock,
// James Jacobs, Ryan Macklin, Colin McComb,
// Jason Nelson, Richard Pett, Stephen Radney-MacFarland,
// Patrick Renie, Sean K Reynolds, F. Wesley Schneider,
// James L.Sutter, Russ Taylor, and Stephen Townshend.
//
#endregion

using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
///Influential associates are people who had 
///(or continue to have) a strong influence upon 
///your development. They are archetypes and 
///templates for NPCs that you can customize 
///to fit your background. Roll on Table: 
///Influential Associates to determine an 
///associate or ally who had a major influence 
///on your life. Then flesh out the details to 
///show how this person fits within your story. 
///You might also wish to use other tables in 
///this chapter to randomly fill in this 
///person’s details
/// </summary>
public partial class BackgroundTables
{
    //Table: Influential Associates
    //d%	Result
    //01–05	The Hunter  This person was a lone wolf who nonetheless cautiously allowed you to become a member of her solitary pack.She taught you how to thrive on your own in spite of the many perils and natural dangers of your native environment.You gain access to the Child of Nature religion trait.
    //06–10	The Pariah  You met a disgraced exile, and found in his words and attitudes something that spoke to you.What once seemed true in your religion, society, or family began to appear false the more time you spent with this person, and you quickly learned not to trust everyone you meet—especially among those who would claim to be most deserving of it. You gain access to the Suspicious social trait.
    //11–15	The Confidante  There was a person in your life to whom you could tell anything. She knows your deepest secrets and your emotional weaknesses and vulnerabilities just as you know hers.This person could be a valuable friend and a frightening enemy, so you make sure to never divulge her secrets or give her a reason to do so with yours.You gain access to the Trustworthy social trait.
    //16–20	The Mentor  You had a mentor who taught you everything worth knowing about life. This could have been the person who taught you the heroic abilities you possess, or simply a kindred spirit who helped form your worldview. You gain access to the Mentored social trait.
    //21–25	The Mercenary   With this person, there was always a cost.No deed was done making a trade for something of equal or greater value. Whether this individual’s actions tended toward good, evil, or pure balance, he was always fair in his dealings. You respected this trait and it influenced your own philosophy.You gain access to the Mercenary social trait.
    //26–30	The Lover   You had a romantic connection in your adolescent years, and this person deeply influenced your personality.Perhaps this was a first love, a casual partner you grew close to, or the one who got away. The experience bolstered your confidence in romantic interactions even though you often find your thoughts still straying toward that special someone from so long ago. You gain access to the Charming social trait and the True Love story feat. Roll a d12 instead of a d20 on Table: Romantic Relationships.
    //31–35	The Fool    One of your close associates was a clown who mocked propriety and custom, instead engaging in wild and somewhat random actions from time to time.After a while, you learned that there was simple wisdom to this foolery—a careless worldview that taught you how to cast off concern.You gain access to the Unpredictable social trait.
    //36–40	The Liege Lord You became close with someone you were bound to serve, be it a minor lord or lady, master (in the case of a slave), prince or princess, king or queen.Though this person held power over you, she held you closer than a subject or servant.As a result, you’re used to dealing with and being close to power, and your name is known among the ranks of the privileged.You gain access to the Influence social trait.
    //41–45	The Relative    There is a relative you were especially close to.To you, this person was the meaning of family. He helped shepherd you into adulthood, teaching you everything you know about the world. You are bound to this person or his memory, and you strive to keep a promise, vow, or oath that you made to him.You gain access to the Oathbound faith trait.
    //46–50	The Boss    You once gained employment under an organized and powerful individual with far-reaching influence. When the boss was present, everyone listened. This could have been a military commander, tribal chieftain, guild leader, or gang leader.From the boss, you learned how to make people listen, make them see reason, and keep them in line.You gain access to the Natural-Born Leader social trait.
    //51–55	The Academic    One of your associates had such a lust for knowledge that she could never be satisfied with simple answers or obvious solutions.This desire for knowledge frequently exceeded her need for companionship, but you were the single exception. Through this association you developed a keen appreciation for numbers, geometry, logic, hard study, and problem solving.You gain access to the Mathematical Prodigy magic trait.
    //56–60	The Criminal    One of your associates committed crimes regularly.He regaled you with many stories of daring robberies and break-ins—and perhaps even murders. You learned most of what you know of the criminal element from him, and he trusted you as a friend. You gain access to the Canter social trait.
    //61–65	The Seer    You were close to a person who claimed to see the future—perhaps an oracle, seer, prophet, or merely some festival charlatan.Whether they’re true or a trick, you’ve seen visions of distant places and of times that may come to pass. The seer’s influence either made you into an optimist with a drive to change the future or a fatalist resigned to accept it. You gain access to the Scholar of the Great Beyond faith trait.
    //66–70	The Mystic  You were especially close to a holy person in your community who fundamentally changed your life by opening your eyes to the incredible powers that exist beyond the natural world.Regardless of whether you follow a faith, certain religious artifacts, rituals, and texts played a large part in making you the person you are. You gain access to the Child of the Temple faith trait.
    //71–75	The Dead One One of your greatest influences was a sentient undead creature, such as a ghost, lich, grave knight, wraith, or vampire. You encountered it on several occasions and survived…mostly unscathed. Through this strange relationship you learned of its mortal life, giving you perspective on your own life.You gain access to the Deathtouched bloodline race trait and the Glimpse Beyond story feat.
    //76–80	The Fiend   In your adolescent years, you dealt with or were possessed by a fiend who lent you raw power at a time of great need. This experience tainted your body and mind and changed your life.Some part of the demon remains inside you like an old friend, influencing you toward destructive ends.You gain access to the Possessed magic trait and the Damned story feat.
    //81–85	The Wanderer    You knew someone who traveled from place to place with the changing of the wind, such as a minstrel, convict, merchant, outcast, soldier, or sailor. This person brought you wondrous mementos and told you of all the places he had traveled and the people who lived there, inspiring a wanderlust within you.You gain access to the Worldly social trait.
    //86–90	The Champion    You were close to someone who excelled at athletic endeavors and tests of strength or skill. Through your friendship or rivalry, you developed the competitive spirit that continues to drive you in everything you do. You gain access to the Ambitious social trait.
    //91–95	The Craftsperson    One of your major influences cherished perfection in every form of art. This person might have followed any path in life, from craftsperson to artist to assassin. From this person you developed a disciplined mind, a solitary focus, and the ability to create something useful and beautiful.You gain access to the Artisan social trait.
    //96–100	Well-Connected Friend   In your circle of disparate associates, there was someone everyone knew.This person collected friends like trophies, and she had contacts in every social or professional circle.Through this connection, you continue to meet and associate with a wide variety of people in every walk of life. You gain access to the Well-Informed halfling race trait (which you may take regardless of your race).
    /// <summary>
    /// Influential Associates
    /// </summary>
    public static RandomTable InfluentialAssociatesTable { get; } = new()
    {
        Name = "Influential Associates Table",
        DiceSides = 100,
        Table =
        [
            #region "The Hunter"
            //01–05	The Hunter  This person was a lone wolf who nonetheless cautiously allowed you to become a member of her solitary pack.She taught you how to thrive on your own in spite of the many perils and natural dangers of your native environment.You gain access to the Child of Nature religion trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 05,
                Name = nameof(InfluentialAssociatesEnum.TheHunter),
                ProperName = "The Hunter",
                Description =
                    "This person was a lone wolf who " +
                    "nonetheless cautiously allowed " +
                    "you to become a member of her " +
                    "solitary pack. She taught you " +
                    "how to thrive on your own in " +
                    "spite of the many perils and " +
                    "natural dangers of your native " +
                    "environment. You gain access " +
                    "to the Child of Nature religion " +
                    "trait.",
                Traits =
                {
                    TraitEnum.ChildofNature,
                },
            },
            #endregion

            #region "The Pariah"
            //06–10	The Pariah  You met a disgraced exile, and found in his words and attitudes something that spoke to you.What once seemed true in your religion, society, or family began to appear false the more time you spent with this person, and you quickly learned not to trust everyone you meet—especially among those who would claim to be most deserving of it. You gain access to the Suspicious social trait.
            new RandomTableEntry
            {
                LowerRange = 06,
                UpperRange = 10,
                Name = nameof(InfluentialAssociatesEnum.ThePariah),
                ProperName = "The Pariah",
                Description =
                    "You met a disgraced exile, and " +
                    "found in his words and attitudes " +
                    "something that spoke to you. What " +
                    "once seemed true in your religion, " +
                    "society, or family began to appear " +
                    "false the more time you spent " +
                    "with this person, and you quickly " +
                    "learned not to trust everyone you " +
                    "meet—especially among those who " +
                    "would claim to be most deserving " +
                    "of it. You gain access to the " +
                    "Suspicious social trait.",
                Traits =
                {
                    TraitEnum.Suspicious,
                },
            },
            #endregion

            #region "The Confidante"
            //11–15	The Confidante  There was a person in your life to whom you could tell anything. She knows your deepest secrets and your emotional weaknesses and vulnerabilities just as you know hers.This person could be a valuable friend and a frightening enemy, so you make sure to never divulge her secrets or give her a reason to do so with yours.You gain access to the Trustworthy social trait.
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 15,
                Name = nameof(InfluentialAssociatesEnum.TheConfidante),
                ProperName = "The Confidante",
                Description =
                    "There was a person in your life " +
                    "to whom you could tell anything. " +
                    "She knows your deepest secrets " +
                    "and your emotional weaknesses and " +
                    "vulnerabilities just as you know " +
                    "hers. This person could be a " +
                    "valuable friend and a frightening " +
                    "enemy, so you make sure to never " +
                    "divulge her secrets or give her " +
                    "a reason to do so with yours.You " +
                    "gain access to the Trustworthy " +
                    "social trait.",
                Traits =
                {
                    TraitEnum.Trustworthy,
                },
            },
            #endregion

            #region "The Mentor"
            //16–20	The Mentor  You had a mentor who taught you everything worth knowing about life. This could have been the person who taught you the heroic abilities you possess, or simply a kindred spirit who helped form your worldview. You gain access to the Mentored social trait.
            new RandomTableEntry
            {
                LowerRange = 16,
                UpperRange = 20,
                Name = nameof(InfluentialAssociatesEnum.TheMentor),
                ProperName = "The Mentor",
                Description =
                    "You had a mentor who taught you " +
                    "everything worth knowing about " +
                    "life. This could have been the " +
                    "person who taught you the heroic " +
                    "abilities you possess, or simply " +
                    "a kindred spirit who helped form " +
                    "your worldview. You gain access " +
                    "to the Mentored social trait.",
                Traits =
                {
                    TraitEnum.Mentored,
                },
            },
            #endregion

            #region "The Mercenary"
            //21–25	The Mercenary   With this person, there was always a cost.No deed was done making a trade for something of equal or greater value. Whether this individual’s actions tended toward good, evil, or pure balance, he was always fair in his dealings. You respected this trait and it influenced your own philosophy.You gain access to the Mercenary social trait.
            new RandomTableEntry
            {
                LowerRange = 21,
                UpperRange = 25,
                Name = nameof(InfluentialAssociatesEnum.TheMercenary),
                ProperName = "The Mercenary",
                Description =
                    "With this person, there was " +
                    "always a cost.No deed was done " +
                    "making a trade for something of " +
                    "equal or greater value. Whether " +
                    "this individual’s actions tended " +
                    "toward good, evil, or pure balance, " +
                    "he was always fair in his dealings. " +
                    "You respected this trait and it " +
                    "influenced your own philosophy.You " +
                    "gain access to the Mercenary social " +
                    "trait.",
                Traits =
                {
                    TraitEnum.Mercenary,
                },
            },
            #endregion

            #region "The Lover"
            //26–30	The Lover   You had a romantic connection in your adolescent years, and this person deeply influenced your personality.Perhaps this was a first love, a casual partner you grew close to, or the one who got away. The experience bolstered your confidence in romantic interactions even though you often find your thoughts still straying toward that special someone from so long ago. You gain access to the Charming social trait and the True Love story feat. Roll a d12 instead of a d20 on Table: Romantic Relationships.
            new RandomTableEntry
            {
                LowerRange = 26,
                UpperRange = 30,
                Name = nameof(InfluentialAssociatesEnum.TheLover),
                ProperName = "The Lover",
                Description =
                    "You had a romantic connection " +
                    "in your adolescent years, and " +
                    "this person deeply influenced " +
                    "your personality.Perhaps this " +
                    "was a first love, a casual " +
                    "partner you grew close to, " +
                    "or the one who got away. The " +
                    "experience bolstered your " +
                    "confidence in romantic " +
                    "interactions even though you " +
                    "often find your thoughts still " +
                    "straying toward that special " +
                    "someone from so long ago. You " +
                    "gain access to the Charming " +
                    "social trait and the True Love " +
                    "story feat. Roll a d12 instead " +
                    "of a d20 on Table: Romantic " +
                    "Relationships.",
                Traits =
                {
                    TraitEnum.Charming,
                },
            },
            #endregion

            #region "The Fool"
            //31–35	The Fool One of your close associates was a clown who mocked propriety and custom, instead engaging in wild and somewhat random actions from time to time.After a while, you learned that there was simple wisdom to this foolery—a careless worldview that taught you how to cast off concern.You gain access to the Unpredictable social trait.
            new RandomTableEntry
            {
                LowerRange = 31,
                UpperRange = 35,
                Name = nameof(InfluentialAssociatesEnum.TheFool),
                ProperName = "The Fool",
                Description =
                    "One of your close associates was " +
                    "a clown who mocked propriety and "+
                    "custom, instead engaging in wild " +
                    "and somewhat random actions from " +
                    "time to time.After a while, you " +
                    "learned that there was simple " +
                    "wisdom to this foolery—a careless " +
                    "worldview that taught you how to " +
                    "cast off concern.You gain access " +
                    "to the Unpredictable social trait.",
                Traits =
                {
                    TraitEnum.Unpredictable,
                },
            },
            #endregion

            #region "The Liege Lord"
            //36–40	The Liege Lord You became close with someone you were bound to serve, be it a minor lord or lady, master (in the case of a slave), prince or princess, king or queen.Though this person held power over you, she held you closer than a subject or servant.As a result, you’re used to dealing with and being close to power, and your name is known among the ranks of the privileged.You gain access to the Influence social trait.
            new RandomTableEntry
            {
                LowerRange = 36,
                UpperRange = 40,
                Name = nameof(InfluentialAssociatesEnum.TheLiegeLord),
                ProperName = "The Liege Lord",
                Description =
                    "You became close with someone " +
                    "you were bound to serve, be " +
                    "it a minor lord or lady, master " +
                    "(in the case of a slave), prince " +
                    "or princess, king or queen. " +
                    "Though this person held power " +
                    "over you, she held you closer " +
                    "than a subject or servant. As a " +
                    "result, you’re used to dealing " +
                    "with and being close to power, " +
                    "and your name is known among " +
                    "the ranks of the privileged. " +
                    "You gain access to the Influence " +
                    "social trait.",
                Traits =
                {
                    TraitEnum.Influence,
                },
            },
            #endregion

            #region "The Relative"
            //41–45	The Relative There is a relative you were especially close to.To you, this person was the meaning of family. He helped shepherd you into adulthood, teaching you everything you know about the world. You are bound to this person or his memory, and you strive to keep a promise, vow, or oath that you made to him.You gain access to the Oathbound faith trait.
            new RandomTableEntry
            {
                LowerRange = 41,
                UpperRange = 45,
                Name = nameof(InfluentialAssociatesEnum.TheRelative),
                ProperName = "The Relative",
                Description =
                    "There is a relative you were " +
                    "especially close to.To you, " +
                    "this person was the meaning " +
                    "of family. He helped shepherd " +
                    "you into adulthood, teaching " +
                    "you everything you know about " +
                    "the world. You are bound to " +
                    "this person or his memory, " +
                    "and you strive to keep a promise, " +
                    "vow, or oath that you made to him. " +
                    "You gain access to the Oathbound " +
                    "faith trait.",
                Traits =
                {
                    TraitEnum.Oathbound,
                },
            },
            #endregion

            #region "The Boss"
            //46–50	The Boss You once gained employment under an organized and powerful individual with far-reaching influence. When the boss was present, everyone listened. This could have been a military commander, tribal chieftain, guild leader, or gang leader.From the boss, you learned how to make people listen, make them see reason, and keep them in line.You gain access to the Natural-Born Leader social trait.
            new RandomTableEntry
            {
                LowerRange = 46,
                UpperRange = 50,
                Name = nameof(InfluentialAssociatesEnum.TheBoss),
                ProperName = "The Boss",
                Description =
                    "You once gained employment " +
                    "under an organized and powerful " +
                    "individual with far-reaching " +
                    "influence. When the boss was " +
                    "present, everyone listened. " +
                    "This could have been a military " +
                    "commander, tribal chieftain, " +
                    "guild leader, or gang leader. " +
                    "From the boss, you learned how " +
                    "to make people listen, make them " +
                    "see reason, and keep them in " +
                    "line. You gain access to " +
                    "the Natural-Born Leader social trait.",
                Traits =
                {
                    TraitEnum.NaturalBornLeader,
                },
            },
            #endregion

            #region "The Academic"
            //51–55	The Academic One of your associates had such a lust for knowledge that she could never be satisfied with simple answers or obvious solutions.This desire for knowledge frequently exceeded her need for companionship, but you were the single exception. Through this association you developed a keen appreciation for numbers, geometry, logic, hard study, and problem solving.You gain access to the Mathematical Prodigy magic trait.
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 55,
                Name = nameof(InfluentialAssociatesEnum.TheAcademic),
                ProperName = "The Academic",
                Description =
                    "One of your associates had such " +
                    "a lust for knowledge that she " +
                    "could never be satisfied with " +
                    "simple answers or obvious " +
                    "solutions. This desire for " +
                    "knowledge frequently exceeded " +
                    "her need for companionship, " +
                    "but you were the single exception. " +
                    "Through this association you " +
                    "developed a keen appreciation for " +
                    "numbers, geometry, logic, hard " +
                    "study, and problem solving. You " +
                    "gain access to " +
                    "the Mathematical Prodigy magic trait.",
                Traits =
                {
                    TraitEnum.MathematicalProdigy,
                },
            },
            #endregion

            #region "The Criminal"
            //56–60	The Criminal One of your associates committed crimes regularly.He regaled you with many stories of daring robberies and break-ins—and perhaps even murders. You learned most of what you know of the criminal element from him, and he trusted you as a friend. You gain access to the Canter social trait.
            new RandomTableEntry
            {
                LowerRange = 56,
                UpperRange = 60,
                Name = nameof(InfluentialAssociatesEnum.TheCriminal),
                ProperName = "The Criminal",
                Description =
                    "One of your associates committed " +
                    "crimes regularly. He regaled you " +
                    "with many stories of daring " +
                    "robberies and break-ins—and " +
                    "perhaps even murders. You " +
                    "learned most of what you know " +
                    "of the criminal element from him, " +
                    "and he trusted you as a friend. " +
                    "You gain access to the Canter social trait.",
                Traits =
                {
                    TraitEnum.Canter,
                },
            },
            #endregion

            #region "The Seer"
            //61–65	The Seer You were close to a person who claimed to see the future—perhaps an oracle, seer, prophet, or merely some festival charlatan.Whether they’re true or a trick, you’ve seen visions of distant places and of times that may come to pass. The seer’s influence either made you into an optimist with a drive to change the future or a fatalist resigned to accept it. You gain access to the Scholar of the Great Beyond faith trait.
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 65,
                Name = nameof(InfluentialAssociatesEnum.TheSeer),
                ProperName = "The Seer",
                Description =
                    "You were close to a person who " +
                    "claimed to see the future—perhaps " +
                    "an oracle, seer, prophet, or merely " +
                    "some festival charlatan.Whether " +
                    "they’re true or a trick, you’ve " +
                    "seen visions of distant places " +
                    "and of times that may come to " +
                    "pass. The seer’s influence either " +
                    "made you into an optimist with a " +
                    "drive to change the future or a " +
                    "fatalist resigned to accept it." +
                    "You gain access to the " +
                    "Scholar of the Great Beyond faith trait.",
                Traits =
                {
                    TraitEnum.ScholaroftheGreatBeyond,
                },
            },
            #endregion

            #region "The Mystic"
            //66–70	The Mystic  You were especially close to a holy person in your community who fundamentally changed your life by opening your eyes to the incredible powers that exist beyond the natural world.Regardless of whether you follow a faith, certain religious artifacts, rituals, and texts played a large part in making you the person you are. You gain access to the Child of the Temple faith trait.
            new RandomTableEntry
            {
                LowerRange = 66,
                UpperRange = 70,
                Name = nameof(InfluentialAssociatesEnum.TheMystic),
                ProperName = "The Mystic",
                Description =
                    "You were especially close to a " +
                    "holy person in your community " +
                    "who fundamentally changed your " +
                    "life by opening your eyes to the " +
                    "incredible powers that exist " +
                    "beyond the natural world. " +
                    "Regardless of whether you follow " +
                    "a faith, certain religious " +
                    "artifacts, rituals, and texts " +
                    "played a large part in making " +
                    "you the person you are. You gain " +
                    "access to the Child of the Temple " +
                    "faith trait.",
                Traits =
                {
                    TraitEnum.ChildoftheTemple,
                },
            },
            #endregion

            #region "The Dead One"
            //71–75	The Dead One One of your greatest influences was a sentient undead creature, such as a ghost, lich, grave knight, wraith, or vampire. You encountered it on several occasions and survived…mostly unscathed. Through this strange relationship you learned of its mortal life, giving you perspective on your own life.You gain access to the Deathtouched bloodline race trait and the Glimpse Beyond story feat.
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 75,
                Name = nameof(InfluentialAssociatesEnum.TheDeadOne),
                ProperName = "The Dead One",
                Description =
                    "One of your greatest influences " +
                    "was a sentient undead creature, " +
                    "such as a ghost, lich, grave " +
                    "knight, wraith, or vampire. You " +
                    "encountered it on several " +
                    "occasions and survived…mostly " +
                    "unscathed. Through this strange " +
                    "relationship you learned of its " +
                    "mortal life, giving you perspective " +
                    "on your own life. You gain access " +
                    "to the Deathtouched bloodline " +
                    "race trait and the Glimpse Beyond " +
                    "story feat.",
                Traits =
                {
                    TraitEnum.Deathtouched,
                    //TraitEnum.GlimpseBeyond,
                },
            },
            #endregion

            #region "The Fiend"
            //76–80	The Fiend In your adolescent years, you dealt with or were possessed by a fiend who lent you raw power at a time of great need. This experience tainted your body and mind and changed your life.Some part of the demon remains inside you like an old friend, influencing you toward destructive ends.You gain access to the Possessed magic trait and the Damned story feat.
            new RandomTableEntry
            {
                LowerRange = 76,
                UpperRange = 80,
                Name = nameof(InfluentialAssociatesEnum.TheFiend),
                ProperName = "The Fiend",
                Description =
                    "In your adolescent years, you " +
                    "dealt with or were possessed by " +
                    "a fiend who lent you raw power " +
                    "at a time of great need. This " +
                    "experience tainted your body " +
                    "and mind and changed your life. " +
                    "Some part of the demon remains " +
                    "inside you like an old friend, " +
                    "influencing you toward destructive " +
                    "ends. You gain access to " +
                    "the Possessed magic trait and " +
                    "the Damned story feat.",
                Traits =
                {
                    TraitEnum.Possessed,
                    //TraitEnum.Damned,
                },
            },
            #endregion

            #region "The Wanderer"
            //81–85	The Wanderer You knew someone who traveled from place to place with the changing of the wind, such as a minstrel, convict, merchant, outcast, soldier, or sailor. This person brought you wondrous mementos and told you of all the places he had traveled and the people who lived there, inspiring a wanderlust within you.You gain access to the Worldly social trait.
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 85,
                Name = nameof(InfluentialAssociatesEnum.TheWanderer),
                ProperName = "The Wanderer",
                Description =
                    "You knew someone who traveled " +
                    "from place to place with the " +
                    "changing of the wind, such as " +
                    "a minstrel, convict, merchant, " +
                    "outcast, soldier, or sailor. " +
                    "This person brought you wondrous " +
                    "mementos and told you of all " +
                    "the places he had traveled and " +
                    "the people who lived there, " +
                    "inspiring a wanderlust within " +
                    "you. You gain access to " +
                    "the Worldly social trait.",
                Traits =
                {
                    TraitEnum.Worldly,
                },
            },
            #endregion

            #region "The Champion"
            //86–90	The Champion You were close to someone who excelled at athletic endeavors and tests of strength or skill. Through your friendship or rivalry, you developed the competitive spirit that continues to drive you in everything you do. You gain access to the Ambitious social trait.
            new RandomTableEntry
            {
                LowerRange = 86,
                UpperRange = 90,
                Name = nameof(InfluentialAssociatesEnum.TheChampion),
                ProperName = "The Champion",
                Description =
                    "You were close to someone who " +
                    "excelled at athletic endeavors " +
                    "and tests of strength or skill. " +
                    "Through your friendship or " +
                    "rivalry, you developed the " +
                    "competitive spirit that continues " +
                    "to drive you in everything you do. " +
                    "You gain access to the Ambitious " +
                    "social trait.",
                Traits =
                {
                    TraitEnum.Ambitious,
                },
            },
            #endregion

            #region "The Craftsperson"
            //91–95	The Craftsperson    One of your major influences cherished perfection in every form of art. This person might have followed any path in life, from craftsperson to artist to assassin. From this person you developed a disciplined mind, a solitary focus, and the ability to create something useful and beautiful.You gain access to the Artisan social trait.
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 95,
                Name = nameof(InfluentialAssociatesEnum.TheCraftsperson),
                ProperName = "The Craftsperson",
                Description =
                    "One of your major influences " +
                    "cherished perfection in every " +
                    "form of art. This person might " +
                    "have followed any path in life, " +
                    "from craftsperson to artist to " +
                    "assassin. From this person you " +
                    "developed a disciplined mind, " +
                    "a solitary focus, and the ability " +
                    "to create something useful and " +
                    "beautiful. You gain access to " +
                    "the Artisan social trait.",
                Traits =
                {
                    TraitEnum.Artisan,
                },
            },
            #endregion

            #region "Well-Connected Friend"
            //96–100	Well-Connected Friend   In your circle of disparate associates, there was someone everyone knew.This person collected friends like trophies, and she had contacts in every social or professional circle.Through this connection, you continue to meet and associate with a wide variety of people in every walk of life. You gain access to the Well-Informed halfling race trait (which you may take regardless of your race).
            new RandomTableEntry
            {
                LowerRange = 96,
                UpperRange = 100,
                Name = nameof(InfluentialAssociatesEnum.WellConnectedFriend),
                ProperName = "Well-Connected Friend",
                Description =
                    "In your circle of disparate " +
                    "associates, there was someone " +
                    "everyone knew. This person " +
                    "collected friends like trophies, " +
                    "and she had contacts in every " +
                    "social or professional circle. " +
                    "Through this connection, you " +
                    "continue to meet and associate " +
                    "with a wide variety of people " +
                    "in every walk of life. You gain " +
                    "access to the Well-Informed " +
                    "halfling race trait (which you " +
                    "may take regardless of your race).",
                Traits =
                {
                    TraitEnum.WellInformed,
                },
            },
            #endregion
        ]
    };
}
