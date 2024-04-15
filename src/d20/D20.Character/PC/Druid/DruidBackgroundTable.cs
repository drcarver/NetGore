using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Core.Models;

namespace D20.Character.PC.Druid;

public class DruidBackgroundTable : RandomTable, IDruidBackgroundTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public DruidBackgroundTable()
    {
        Name = nameof(DruidBackgroundTable);
        ProperName = "Druid backgrounds";
        TableType = TableTypeEnum.CharacterTable;
        DiceSides = 100;
        Description =
            "Druids have a talent for song and story, and they " +
            "come to their careers by developing this talent " +
            "as they pick up on a smattering of other skills.";
    }

    //Table: Druid Backgrounds
    //d%	Result
    //01–10	Celebrity In your formative years, you saw a player or troupe of players perform before an enthralled audience.That’s when you decided that you wanted to be up on that stage performing for the adulation of the crowd.As a minor celebrity, you gain access to either the Charming social trait or the Influence social trait.
    //11–20	Cultural Mandate    There has always been a revered storyteller in your culture.This could be an official skald, a royal minstrel, the washerman who spins parables and folk wisdom, or the old farmer who tells tall tales at the pub.Ever since you were young, your community has groomed you to fulfill this role.As a silver-tongued storyteller, you gain access to the Fast Talker social trait.
    //21–30	Dabbler Whether you grew up rich or poor, you refused to accept the limits imposed by your social class or means.In your youth, you determined to learn a little bit of all there was to know.You may not be the master of any one career, but the breadth of your experience is wide, textured, and diverse.You gain access to the Worldly social trait.
    //31–40	For Love    When you were young, you tried to express yourself to your beloved using song or poetry.Driven by desire, you refined your skill and learned to articulate raw emotion in story and song.You gain access to the Ear for Music religion trait and the True Love story feat.You roll a d12 instead of a d20 on Table: Romantic Relationships.
    //41–50	Gift Someone gave you a special instrument or a collection of songs and stories at a time in your life when you needed them most.You have treasured this object above all other possessions, and it started you on a path to new songs and stories.You gain access to the Seeker social trait.
    //51–60	Ongoing Patron  When you were young, a person with money or power took an interest in your art and sponsored you.Most of what you created was dictated by the patron’s tastes, and you probably still work for this patron, who maintains a strong influence over your life. You gain access to the Oathbound faith trait.
    //61–70	Spy Someone once asked you to employ your artistic talents as an excuse to observe a person, steal an object, or retrieve a piece of information. Infiltrating various houses and estates in the guise of an actor, minstrel, or storyteller, you honed your art while being paid better than most other performers.You gain access to the Criminal social trait. See the Crime and Punishment sidebar.
    //71–80	Troupe of Players You were born into, helped found, or fell in with a troupe of traveling players. You spent your early years rambling from one place to another—from tavern to tavern, town to town, or even between countries. Long hours traveling gave you plenty of time to practice and hone your skill. You gain access to the World Traveler human race trait (which you may take regardless of your race).
    //81–90	Virtuoso One day, you picked up an instrument or told a tale, and your raw natural ability captivated everyone who saw you perform.Words and music have always come to you effortlessly, as naturally as breathing.You gain access to the Talented social trait and the Magnum Opus story feat.
    //91–100	Worldshaker Since childhood, you’ve observed the world around you and translated those observations into story and song. Your unique, unabashed vision resonated with the audience, revealing new perspectives as well as simple truths.You’re used to people quoting your words and looking up to you, though some authority figures deem you a rabble-rouser and troublemaker.You gain access to the Natural-Born Leader social trait.
    /// <summary>
    /// Initialize the game table.  This is a separate method so 
    /// we can create a game table for it's meta properties with 
    /// out creating the actual able values.  A bit of optimization 
    /// to conserve memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region "Celebrity"
            //01–10	Celebrity In your formative years, you saw a player or troupe of players perform before an enthralled audience.That’s when you decided that you wanted to be up on that stage performing for the adulation of the crowd.As a minor celebrity, you gain access to either the Charming social trait or the Influence social trait.
            new BackgroundTableEntry
            {
                Range = new Range(01, 10),
                Name = nameof(DruidBackgroundEnum.Celebrity),
                ProperName = "Celebrity",
                Description =
                    "In your formative years, you saw a player " +
                    "or troupe of players perform before an " +
                    "enthralled audience. That’s when you decided " +
                    "that you wanted to be up on that stage " +
                    "performing for the adulation of the crowd. " +
                    "As a minor celebrity, you gain access to " +
                    "either the Charming social trait or the " +
                    "Influence social trait.",
                Traits =
                [
                    TraitEnum.Charming,
                    TraitEnum.Influence,
                ]
            },
            #endregion

            #region "Cultural Mandate"
            //11–20	Cultural Mandate    There has always been a revered storyteller in your culture.This could be an official skald, a royal minstrel, the washerman who spins parables and folk wisdom, or the old farmer who tells tall tales at the pub.Ever since you were young, your community has groomed you to fulfill this role.As a silver-tongued storyteller, you gain access to the Fast Talker social trait.
            new BackgroundTableEntry
            {
                Range = new Range(11, 20),
                Name = nameof(DruidBackgroundEnum.CulturalMandate),
                ProperName = "Cultural Mandate",
                Description =
                    "There has always been a revered storyteller " +
                    "in your culture.This could be an official " +
                    "skald, a royal minstrel, the washerman who " +
                    "spins parables and folk wisdom, or the old " +
                    "farmer who tells tall tales at the pub. " +
                    "Ever since you were young, your community " +
                    "has groomed you to fulfill this role. As " +
                    "a silver-tongued storyteller, you gain " +
                    "access to the Fast Talker social trait.",
                Traits =
                [
                    TraitEnum.FastTalker,
                ]
            },
            #endregion

            #region "Dabbler"
            //21–30	Dabbler Whether you grew up rich or poor, you refused to accept the limits imposed by your social class or means.In your youth, you determined to learn a little bit of all there was to know.You may not be the master of any one career, but the breadth of your experience is wide, textured, and diverse.You gain access to the Worldly social trait.
            new BackgroundTableEntry
            {
                Range = new Range(21, 30),
                Name = nameof(DruidBackgroundEnum.Dabbler),
                ProperName = "Dabbler",
                Description =
                    "Whether you grew up rich or poor, you " +
                    "refused to accept the limits imposed by " +
                    "your social class or means. In your youth, " +
                    "you determined to learn a little bit of " +
                    "all there was to know. You may not be " +
                    "the master of any one career, but the " +
                    "breadth of your experience is wide, " +
                    "textured, and diverse. You gain access " +
                    "to the Worldly social trait.",
                Traits =
                [
                    TraitEnum.Worldly,
                ]
            },
            #endregion

            #region "For Love"
            //31–40	For Love    When you were young, you tried to express yourself to your beloved using song or poetry.Driven by desire, you refined your skill and learned to articulate raw emotion in story and song.You gain access to the Ear for Music religion trait and the True Love story feat.You roll a d12 instead of a d20 on Table: Romantic Relationships.
            new BackgroundTableEntry
            {
                Range = new Range(31, 40),
                Name = nameof(DruidBackgroundEnum.ForLove),
                ProperName = "For Love",
                Description =
                    "When you were young, you tried to express " +
                    "yourself to your beloved using song or " +
                    "poetry. Driven by desire, you refined your " +
                    "skill and learned to articulate raw emotion " +
                    "in story and song. You gain access to the " +
                    "Ear for Music religion trait and the " +
                    "True Love story feat. You roll a d12 instead " +
                    "of a d20 on Table: Romantic Relationships.",
                Traits =
                [
                    TraitEnum.EarforMusic,
                    TraitEnum.TrueLove
                ]
            },
            #endregion

            #region "Gift"
            //41–50	Gift Someone gave you a special instrument or a collection of songs and stories at a time in your life when you needed them most.You have treasured this object above all other possessions, and it started you on a path to new songs and stories.You gain access to the Seeker social trait.
            new BackgroundTableEntry
            {
                Range = new Range(41, 50),
                Name = nameof(DruidBackgroundEnum.Gift),
                ProperName = "Gift",
                Description =
                    "Someone gave you a special instrument or " +
                    "a collection of songs and stories at a time " +
                    "in your life when you needed them most. You " +
                    "have treasured this object above all other " +
                    "possessions, and it started you on a path " +
                    "to new songs and stories. You gain access " +
                    "to the Seeker social trait.",
                Traits =
                [
                    TraitEnum.Seeker,
                ]
            },
            #endregion

            #region "Ongoing Patron"
            //51–60	Ongoing Patron  When you were young, a person with money or power took an interest in your art and sponsored you.Most of what you created was dictated by the patron’s tastes, and you probably still work for this patron, who maintains a strong influence over your life. You gain access to the Oathbound faith trait.
            new BackgroundTableEntry
            {
                Range = new Range(51, 60),
                Name = nameof(DruidBackgroundEnum.OngoingPatron),
                ProperName = "Ongoing Patron",
                Description =
                    "When you were young, a person with money " +
                    "or power took an interest in your art and " +
                    "sponsored you. Most of what you created " +
                    "was dictated by the patron’s tastes, and " +
                    "you probably still work for this patron, " +
                    "who maintains a strong influence over " +
                    "your life. You gain access to the " +
                    "Oathbound faith trait.",
                Traits =
                [
                    TraitEnum.Oathbound,
                ]
            },
            #endregion

            #region "Spy"
            //61–70	Spy Someone once asked you to employ your artistic talents as an excuse to observe a person, steal an object, or retrieve a piece of information. Infiltrating various houses and estates in the guise of an actor, minstrel, or storyteller, you honed your art while being paid better than most other performers.You gain access to the Criminal social trait. See the Crime and Punishment sidebar.
            new BackgroundTableEntry
            {
                Range = new Range(61, 70),
                Name = nameof(DruidBackgroundEnum.Spy),
                ProperName = "Spy",
                Description =
                    "Someone once asked you to employ your " +
                    "artistic talents as an excuse to observe " +
                    "a person, steal an object, or retrieve " +
                    "a piece of information. Infiltrating " +
                    "various houses and estates in the guise " +
                    "of an actor, minstrel, or storyteller, " +
                    "you honed your art while being paid better " +
                    "than most other performers. You gain access " +
                    "to the Criminal social trait. See the Crime " +
                    "and Punishment sidebar.",
                Traits =
                [
                    TraitEnum.Criminal,
                ]
            },
            #endregion

            #region "Troupe of Players"
            //71–80	Troupe of Players You were born into, helped found, or fell in with a troupe of traveling players. You spent your early years rambling from one place to another—from tavern to tavern, town to town, or even between countries. Long hours traveling gave you plenty of time to practice and hone your skill. You gain access to the World Traveler human race trait (which you may take regardless of your race).
            new BackgroundTableEntry
            {
                Range = new Range(71, 80),
                Name = nameof(DruidBackgroundEnum.TroupeofPlayers),
                ProperName = "Troupe of Players",
                Description =
                    "You were born into, helped found, or " +
                    "fell in with a troupe of traveling players. " +
                    "You spent your early years rambling from " +
                    "one place to another—from tavern to tavern, " +
                    "town to town, or even between countries. " +
                    "Long hours traveling gave you plenty of " +
                    "time to practice and hone your skill. You " +
                    "gain access to the World Traveler human " +
                    "race trait (which you may take regardless " +
                    "of your race).",
                Traits =
                [
                    TraitEnum.WorldTraveler,
                ]
            },
            #endregion

            #region "Virtuoso"
            //81–90	Virtuoso One day, you picked up an instrument or told a tale, and your raw natural ability captivated everyone who saw you perform.Words and music have always come to you effortlessly, as naturally as breathing.You gain access to the Talented social trait and the Magnum Opus story feat.
            new BackgroundTableEntry
            {
                Range = new Range(81, 90),
                Name = nameof(DruidBackgroundEnum.Virtuoso),
                ProperName = "Virtuoso",
                Description =
                    "One day, you picked up an instrument or " +
                    "told a tale, and your raw natural ability " +
                    "captivated everyone who saw you perform. " +
                    "Words and music have always come to you " +
                    "effortlessly, as naturally as breathing. " +
                    "You gain access to the Talented social " +
                    "trait and the Magnum Opus story feat.",
                Traits =
                [
                    TraitEnum.Talented,
                    TraitEnum.MagnumOpus,
                ]
            },
            #endregion

            #region "Worldshaker"
            //91–100	Worldshaker Since childhood, you’ve observed the world around you and translated those observations into story and song. Your unique, unabashed vision resonated with the audience, revealing new perspectives as well as simple truths.You’re used to people quoting your words and looking up to you, though some authority figures deem you a rabble-rouser and troublemaker.You gain access to the Natural-Born Leader social trait.
            new BackgroundTableEntry
            {
                Range = new Range(91, 100),
                Name = nameof(DruidBackgroundEnum.Worldshaker),
                ProperName = "Worldshaker",
                Description =
                    "Since childhood, you’ve observed the " +
                    "world around you and translated those " +
                    "observations into story and song. Your " +
                    "unique, unabashed vision resonated with " +
                    "the audience, revealing new perspectives " +
                    "as well as simple truths. You’re used " +
                    "to people quoting your words and looking " +
                    "up to you, though some authority figures " +
                    "deem you a rabble-rouser and troublemaker. " +
                    "You gain access to the Natural-Born Leader " +
                    "social trait.",
                Traits =
                [
                    TraitEnum.NaturalBornLeader,
                ]
            },
            #endregion
        ];
    }
}
