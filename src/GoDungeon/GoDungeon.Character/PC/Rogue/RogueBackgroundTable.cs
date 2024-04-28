using System.Diagnostics.CodeAnalysis;

using GoDungeon.Background.Enum;
using GoDungeon.Background.Models;
using GoDungeon.Character.Enum;
using GoDungeon.Character.Models;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Models;

namespace GoDungeon.Character.PC.Rogue;

public class RogueBackgroundTable : RandomTable, IRogueBackgroundTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public RogueBackgroundTable()
    {
        Name = nameof(RogueBackgroundTable);
        ProperName = "Rogue backgrounds table";
        TableType = TableTypeEnum.CharacterTable;
        DiceSides = 100;
        Description =
            "The rogue’s path is one of cunning, quickness, skill, and stealth. " +
            "One of the broadest character archetypes, the rogue is found among  " +
            "all walks of life—from highborn spies infiltrating the courts of " +
            "kings to common criminals making their livings preying on " +
            "passersby in the alleys and streets.";
    }

    //Table: Rogue Backgrounds
    //d%	Result
    //01–10	Gang War    Growing up in the backstreets of an urban jungle, you were forced to choose between surviving as a predator or suffering as prey.You affiliated with a guild, gang, or group of thieves and thugs, carrying out illicit missions to further their interests and sabotage those of rival gangs. You gain access to the Dirty Fighter combat trait.
    //11–20	Greed No matter how much or little you had growing up, it was never enough. You discovered a talent for lifting items and coin purses from others’ belts.The world always provided for you, and when you saw something you wanted, you learned to take it.You gain access to the Ambitious social trait and the Thief of Legend story feat.
    //21–30	Poverty In your youth, you rarely had enough food to keep from starving.Poverty and hunger forced you to steal to survive, or to help your loved ones survive.You gain access to the Poverty-Stricken social trait.
    //31–40	Spy You’ve always had an innocent expression and a silver tongue, so naturally you were recruited as a spy during your childhood.You could have come from any social class; you might have gathered information as an urchin on the streets or acted as servant to one lord while you reported to another.You gain access to the Fast Talker social trait.
    //41–50	The Kill    You killed someone when you were relatively young. You might have done it in self-defense, in anger, or as part of an initiation ritual, and it was easier than you suspected.Afterward, some individuals or groups started paying you to kill for them, and you made a lucrative career of assassination. You gain access to the Killer combat trait and the Innocent Blood story feat.
    //51–60	The Trained Your early talent for feats of agility and acrobatics garnered you an experienced mentor. Impressed by your natural ability, this mentor taught you how to fight, dodge, and throw. He may have been a master thief, circus performer, fencing master, or swashbuckling pirate.You gain access to the Mentored social trait.
    //61–70	Outlawed For reasons just or unjust, you became a fugitive at an early age. You have lived outside the light of society for some time, risking capture or punishment whenever you need to break the law again.You gain access to the Criminal social trait. See the Crime and Punishment sidebar.
    //71–80	Thrill Seeker   As an adolescent, you and your friends took turns daring one another to take risks, each new challenge inspiring greater excitement.Since then, you’ve become an adrenaline junkie, performing dangerous tasks in order to chase that high.You gain access to the Acrobat social trait.
    //81–90	Henchman You’ve always worked for someone else. You do what you are told and in return you are appreciated by the boss, rewarded, and paid. You gain access to either the Oathbound faith trait or the Child of the Streets social trait.
    //91–100	Scout Your natural ability turned into employment in an elite squad of stealthy infiltrators. You penetrate enemy lines, gather information, deliver coded messages, and sabotage enemy supplies. You likely work for a private individual or military order.You gain access to the Canter social trait.
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
            #region "Gang War"
            //01–10	Gang War    Growing up in the backstreets of an urban jungle, you were forced to choose between surviving as a predator or suffering as prey.You affiliated with a guild, gang, or group of thieves and thugs, carrying out illicit missions to further their interests and sabotage those of rival gangs. You gain access to the Dirty Fighter combat trait.
            new BackgroundTableEntry
            {
                Range = new Range(01, 10),
                Name = nameof(RogueBackgroundEnum.GangWar),
                ProperName = "Gang War",
                Description =
                    "Growing up in the backstreets of an urban " +
                    "jungle, you were forced to choose between " +
                    "surviving as a predator or suffering as prey. " +
                    "You affiliated with a guild, gang, or group " +
                    "of thieves and thugs, carrying out illicit " +
                    "missions to further their interests and " +
                    "sabotage those of rival gangs. You gain " +
                    "access to the Dirty Fighter combat trait.",
                Traits =
                [
                    TraitEnum.DirtyFighter,
                ]
            },
            #endregion

            #region "Greed"
            //11–20	Greed No matter how much or little you had growing up, it was never enough. You discovered a talent for lifting items and coin purses from others’ belts.The world always provided for you, and when you saw something you wanted, you learned to take it.You gain access to the Ambitious social trait and the Thief of Legend story feat.
            new BackgroundTableEntry
            {
                Range = new Range(11, 20),
                Name = nameof(RogueBackgroundEnum.Greed),
                ProperName = "Greed",
                Description =
                    "No matter how much or little you had growing " +
                    "up, it was never enough. You discovered a " +
                    "talent for lifting items and coin purses " +
                    "from others’ belts. The world always provided " +
                    "for you, and when you saw something you wanted, " +
                    "you learned to take it. You gain access to the " +
                    "Ambitious social trait and the Thief of Legend " +
                    "story feat.",
                Traits =
                [
                    TraitEnum.Ambitious,
                    TraitEnum.ThiefofLegend,
                ]
            },
            #endregion

            #region "Poverty"
            //21–30	Poverty In your youth, you rarely had enough food to keep from starving.Poverty and hunger forced you to steal to survive, or to help your loved ones survive.You gain access to the Poverty-Stricken social trait.
            new BackgroundTableEntry
            {
                Range = new Range(21, 30),
                Name = nameof(RogueBackgroundEnum.Poverty),
                ProperName = "Poverty",
                Description =
                    "In your youth, you rarely had enough food " +
                    "to keep from starving.Poverty and hunger " +
                    "forced you to steal to survive, or to help " +
                    "your loved ones survive. You gain access to " +
                    "the Poverty-Stricken social trait.",
                Traits =
                [
                    TraitEnum.PovertyStricken,
                ]
            },
            #endregion

            #region "Spy"
            //31–40	Spy You’ve always had an innocent expression and a silver tongue, so naturally you were recruited as a spy during your childhood.You could have come from any social class; you might have gathered information as an urchin on the streets or acted as servant to one lord while you reported to another.You gain access to the Fast Talker social trait.
            new BackgroundTableEntry
            {
                Range = new Range(31, 40),
                Name = nameof(RogueBackgroundEnum.Spy),
                ProperName = "Spy",
                Description =
                    "You’ve always had an innocent expression " +
                    "and a silver tongue, so naturally you were " +
                    "recruited as a spy during your childhood. " +
                    "You could have come from any social class; " +
                    "you might have gathered information as an " +
                    "urchin on the streets or acted as servant " +
                    "to one lord while you reported to another. " +
                    "You gain access to the Fast Talker social trait.",
                Traits =
                [
                    TraitEnum.FastTalker,
                    TraitEnum.Foeslayer
                ]
            },
            #endregion

            #region "The Kill"
            //41–50	The Kill    You killed someone when you were relatively young. You might have done it in self-defense, in anger, or as part of an initiation ritual, and it was easier than you suspected.Afterward, some individuals or groups started paying you to kill for them, and you made a lucrative career of assassination. You gain access to the Killer combat trait and the Innocent Blood story feat.
            new BackgroundTableEntry
            {
                Range = new Range(41, 50),
                Name = nameof(RogueBackgroundEnum.TheKill),
                ProperName = "The Kill",
                Description =
                    "You killed someone when you were relatively " +
                    "young. You might have done it in self-defense, " +
                    "in anger, or as part of an initiation ritual, " +
                    "and it was easier than you suspected.Afterward, " +
                    "some individuals or groups started paying you " +
                    "to kill for them, and you made a lucrative " +
                    "career of assassination. You gain access to " +
                    "the Killer combat trait and the " +
                    "Innocent Blood story feat.",
                Traits =
                [
                    TraitEnum.Killer,
                    TraitEnum.InnocentBlood,
                ]
            },
            #endregion

            #region "The Trained"
            //51–60	The Trained Your early talent for feats of agility and acrobatics garnered you an experienced mentor. Impressed by your natural ability, this mentor taught you how to fight, dodge, and throw. He may have been a master thief, circus performer, fencing master, or swashbuckling pirate.You gain access to the Mentored social trait.
            new BackgroundTableEntry
            {
                Range = new Range(51, 60),
                Name = nameof(RogueBackgroundEnum.TheTrained),
                ProperName = "The Trained",
                Description =
                    "Your early talent for feats of agility " +
                    "and acrobatics garnered you an experienced " +
                    "mentor. Impressed by your natural ability, " +
                    "this mentor taught you how to fight, dodge, " +
                    "and throw. He may have been a master thief, " +
                    "circus performer, fencing master, or " +
                    "swashbuckling pirate. You gain access to " +
                    "the Mentored social trait.",
                Traits =
                [
                    TraitEnum.Mentored,
                ]
            },
            #endregion

            #region "Outlawed"
            //61–70	Outlawed For reasons just or unjust, you became a fugitive at an early age. You have lived outside the light of society for some time, risking capture or punishment whenever you need to break the law again.You gain access to the Criminal social trait. See the Crime and Punishment sidebar.
            new BackgroundTableEntry
            {
                Range = new Range(61, 70),
                Name = nameof(RogueBackgroundEnum.Outlawed),
                ProperName = "Outlawed",
                Description =
                    "For reasons just or unjust, you became " +
                    "a fugitive at an early age. You have lived " +
                    "outside the light of society for some time, " +
                    "risking capture or punishment whenever you " +
                    "need to break the law again.You gain access " +
                    "to the Criminal social trait.",
                Traits =
                [
                    TraitEnum.Criminal,
                ]
            },
            #endregion

            #region "Thrill Seeker"
            //71–80	Thrill Seeker   As an adolescent, you and your friends took turns daring one another to take risks, each new challenge inspiring greater excitement.Since then, you’ve become an adrenaline junkie, performing dangerous tasks in order to chase that high.You gain access to the Acrobat social trait.
            new BackgroundTableEntry
            {
                Range = new Range(71, 80),
                Name = nameof(RogueBackgroundEnum.ThrillSeeker),
                ProperName = "Thrill Seeker",
                Description =
                    "As an adolescent, you and your friends took " +
                    "turns daring one another to take risks, each " +
                    "new challenge inspiring greater excitement. " +
                    "Since then, you’ve become an adrenaline junkie, " +
                    "performing dangerous tasks in order to chase " +
                    "that high.You gain access to the Acrobat " +
                    "social trait.",
                Traits =
                [
                    TraitEnum.Acrobat,
                ]
            },
            #endregion

            #region "Henchman"
            //81–90	Henchman You’ve always worked for someone else. You do what you are told and in return you are appreciated by the boss, rewarded, and paid. You gain access to either the Oathbound faith trait or the Child of the Streets social trait.
            new BackgroundTableEntry
            {
                Range = new Range(81, 90),
                Name = nameof(RogueBackgroundEnum.Henchman),
                ProperName = "Henchman",
                Description =
                    "You’ve always worked for someone else. You " +
                    "do what you are told and in return you are " +
                    "appreciated by the boss, rewarded, and paid. " +
                    "You gain access to either the Oathbound " +
                    "faith trait or the Child of the Streets " +
                    "social trait.",
                Traits =
                [
                    TraitEnum.Oathbound,
                    TraitEnum.ChildoftheStreets
                ]
            },
            #endregion

            #region "Scout"
            //91–100	Scout Your natural ability turned into employment in an elite squad of stealthy infiltrators. You penetrate enemy lines, gather information, deliver coded messages, and sabotage enemy supplies. You likely work for a private individual or military order.You gain access to the Canter social trait.
            new BackgroundTableEntry
            {
                Range = new Range(91, 100),
                Name = nameof(RogueBackgroundEnum.Scout),
                ProperName = "Scout",
                Description =
                    "Your natural ability turned into employment " +
                    "in an elite squad of stealthy infiltrators. " +
                    "You penetrate enemy lines, gather information, " +
                    "deliver coded messages, and sabotage enemy " +
                    "supplies. You likely work for a private " +
                    "individual or military order. You gain " +
                    "access to the Canter social trait.",
                Traits =
                [
                    TraitEnum.Canter,
                ]
            },
            #endregion
        ];
    }
}
