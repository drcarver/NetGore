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
    //01–10	Lost in the Wild    You got lost in the wilderness and were forced to survive on your own.You may have wandered desert dunes, thick forest, or high mountains—or perhaps you were shipwrecked on a desert island.Young and vulnerable, you feared the natural dangers of the world at first, but acclimated to the natural way of life as you learned to tap into the primal power of the world.You gain access to the Resilient combat trait.
    //11–20	Fey Meeting Walking in the woods, you met a fey creature, such as a brownie, elf, nymph, gnome, sprite, or treant. This magical being taught you how to tend the natural world in the gentle manner of the fey. You gain access to the Magical Knack magic trait.
    //21–30	Spirit of Nature Through a ritual, vision, or dream, you communed with a primordial spirit of nature. In the form of a majestic beast, this spirit charged you with preserving the natural world from those who would destroy it. You are instilled with the spirit of this creature—a small fragment of its power grows in you as you mature. You gain access to the Sacred Touch faith trait.
    //31–40	Tree Tender You learned to care for plants in your youth by tending a small garden, orchard, grove, or field. These plants flourished like no others. You’ve always understood plants better than people.You gain access to the Devotee of the Green faith trait.
    //41–50	Druid Circle    You discovered, or were initiated into, a circle of druids that protects an expanse of wilderness. The druids taught you of their duty to nature and the powers that the natural world granted them. Soon you learned enough to join the circle as an initiate. You gain access to the Mentored social trait.
    //51–60	Civilized Outcast   For a time, you lived in an urban environment.But you soon discovered that social communities, bureaucracies, and laws made you feel constrained and unnatural. You left civilization and retreated into the wild at the first opportunity. You still retain the lessons, habits, and refinements of civilized behavior, but your heart belongs to nature. You gain access to the Civilized social trait.
    //61–70	Savage You spent your formative years among a tribe or village far from civilization. The elders chose you as successor and taught you the lore of the elements and the animals. You gain access to the Savage social trait.
    //71–80	Raised by Beasts You were reared in part by wild animals. Most of what you know you learned by observing these beasts, their natural instincts being unburdened by artifice or manipulation.Even though you possess a humanoid body, the beasts recognize you as one of their own. You gain access to the Animal Friend gnome race trait (which you may take regardless of your race) and the Feral Heart story feat.
    //81–90	Avatar Once you were an ordinary youth.But when the natural world needed saving, the land chose you as its champion, lending you as much power as you were able to control.You might not understand the reasons for your power, but you are one with nature and your will is the will of the world.You gain access to the Child of Nature religion trait.
    //91–100	Beastlord Natural birds and beasts have always obeyed you.From your earliest years, you’ve possessed a gentleness or a power that allows you to communicate with animals as though you shared a common language. Perhaps you have fey blood or traces of lycanthrope ancestry. You gain access to the Beast Bond social trait.
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
            #region Lost in the Wild
            //01–10	Lost in the Wild You got lost in the wilderness and were forced to survive on your own.You may have wandered desert dunes, thick forest, or high mountains—or perhaps you were shipwrecked on a desert island.Young and vulnerable, you feared the natural dangers of the world at first, but acclimated to the natural way of life as you learned to tap into the primal power of the world.You gain access to the Resilient combat trait.
            new BackgroundTableEntry
            {
                Range = new Range(01, 10),
                Name = nameof(DruidBackgroundEnum.LostintheWild),
                ProperName = "Lost in the Wild",
                Description =
                    "You got lost in the wilderness and were " +
                    "forced to survive on your own.You may " +
                    "have wandered desert dunes, thick forest, " +
                    "or high mountains—or perhaps you were " +
                    "shipwrecked on a desert island. Young " +
                    "and vulnerable, you feared the natural " +
                    "dangers of the world at first, but " +
                    "acclimated to the natural way of life " +
                    "as you learned to tap into the primal " +
                    "power of the world.You gain access to " +
                    "the Resilient combat trait.",
                Traits =
                [
                    TraitEnum.Resilient,
                ]
            },
            #endregion

            #region Fey Meeting
            //11–20	Fey Meeting Walking in the woods, you met a fey creature, such as a brownie, elf, nymph, gnome, sprite, or treant. This magical being taught you how to tend the natural world in the gentle manner of the fey. You gain access to the Magical Knack magic trait.
            new BackgroundTableEntry
            {
                Range = new Range(11, 20),
                Name = nameof(DruidBackgroundEnum.FeyMeeting),
                ProperName = "Fey Meeting",
                Description =
                    "Meeting Walking in the woods, you met a " +
                    "fey creature, such as a brownie, elf, " +
                    "nymph, gnome, sprite, or treant. This " +
                    "magical being taught you how to tend the " +
                    "natural world in the gentle manner of " +
                    "the fey. You gain access to the Magical Knack " +
                    "magic trait.",
                Traits =
                [
                    TraitEnum.MagicalKnack,
                ]
            },
            #endregion

            #region Spirit of Nature
           //21–30	Spirit of Nature Through a ritual, vision, or dream, you communed with a primordial spirit of nature. In the form of a majestic beast, this spirit charged you with preserving the natural world from those who would destroy it. You are instilled with the spirit of this creature—a small fragment of its power grows in you as you mature. You gain access to the Sacred Touch faith trait.
            new BackgroundTableEntry
            {
                Range = new Range(21, 30),
                Name = nameof(DruidBackgroundEnum.SpiritofNature),
                ProperName = "Spirit of Nature",
                Description =
                    "Through a ritual, vision, or dream, you " +
                    "communed with a primordial spirit of nature. " +
                    "In the form of a majestic beast, this " +
                    "spirit charged you with preserving the " +
                    "natural world from those who would destroy " +
                    "it. You are instilled with the spirit of " +
                    "this creature—a small fragment of its " +
                    "power grows in you as you mature. You " +
                    "gain access to the Sacred Touch faith trait.",
                Traits =
                [
                    TraitEnum.SacredTouch,
                ]
            },
            #endregion

            #region Tree Tender
            //31–40	Tree Tender You learned to care for plants in your youth by tending a small garden, orchard, grove, or field. These plants flourished like no others. You’ve always understood plants better than people.You gain access to the Devotee of the Green faith trait.
            new BackgroundTableEntry
            {
                Range = new Range(31, 40),
                Name = nameof(DruidBackgroundEnum.TreeTender),
                ProperName = "Tree Tender",
                Description =
                    "You learned to care for plants in your " +
                    "youth by tending a small garden, orchard, " +
                    "grove, or field. These plants flourished " +
                    "like no others. You’ve always understood " +
                    "plants better than people. You gain access " +
                    "to the Devotee of the Green faith trait.",
                Traits =
                [
                    TraitEnum.DevoteeoftheGreen,
                ]
            },
            #endregion

            #region Druid Circle
            //41–50	Druid Circle You discovered, or were initiated into, a circle of druids that protects an expanse of wilderness. The druids taught you of their duty to nature and the powers that the natural world granted them. Soon you learned enough to join the circle as an initiate. You gain access to the Mentored social trait.
            new BackgroundTableEntry
            {
                Range = new Range(41, 50),
                Name = nameof(DruidBackgroundEnum.DruidCircle),
                ProperName = "Druid Circle",
                Description =
                    "You discovered, or were initiated into, " +
                    "a circle of druids that protects an " +
                    "expanse of wilderness. The druids taught " +
                    "you of their duty to nature and the powers " +
                    "that the natural world granted them. Soon " +
                    "you learned enough to join the circle as " +
                    "an initiate. You gain access to the " +
                    "Mentored social trait.",
                Traits =
                [
                    TraitEnum.Mentored,
                ]
            },
            #endregion

            #region Civilized Outcast
            //51–60	Civilized Outcast   For a time, you lived in an urban environment.But you soon discovered that social communities, bureaucracies, and laws made you feel constrained and unnatural. You left civilization and retreated into the wild at the first opportunity. You still retain the lessons, habits, and refinements of civilized behavior, but your heart belongs to nature. You gain access to the Civilized social trait.
            new BackgroundTableEntry
            {
                Range = new Range(51, 60),
                Name = nameof(DruidBackgroundEnum.CivilizedOutcast),
                ProperName = "Civilized Outcast",
                Description =
                    "For a time, you lived in an urban " +
                    "environment. But you soon discovered " +
                    "that social communities, bureaucracies, " +
                    "and laws made you feel constrained and " +
                    "unnatural. You left civilization and " +
                    "retreated into the wild at the first " +
                    "opportunity. You still retain the lessons, " +
                    "habits, and refinements of civilized " +
                    "behavior, but your heart belongs to nature. " +
                    "You gain access to the Civilized social trait.",
                Traits =
                [
                    TraitEnum.Civilized,
                ]
            },
            #endregion

            #region Savage
            //61–70	Savage You spent your formative years among a tribe or village far from civilization. The elders chose you as successor and taught you the lore of the elements and the animals. You gain access to the Savage social trait.
            new BackgroundTableEntry
            {
                Range = new Range(61, 70),
                Name = nameof(DruidBackgroundEnum.Savage),
                ProperName = "Savage",
                Description =
                    "You spent your formative years among a " +
                    "tribe or village far from civilization. " +
                    "The elders chose you as successor and " +
                    "taught you the lore of the elements and " +
                    "the animals. You gain access to the " +
                    "Savage social trait.",
                Traits =
                [
                    TraitEnum.Savage,
                ]
            },
            #endregion

            #region Raised by Beasts
            //71–80	Raised by Beasts You were reared in part by wild animals. Most of what you know you learned by observing these beasts, their natural instincts being unburdened by artifice or manipulation.Even though you possess a humanoid body, the beasts recognize you as one of their own. You gain access to the Animal Friend gnome race trait (which you may take regardless of your race) and the Feral Heart story feat.
            new BackgroundTableEntry
            {
                Range = new Range(71, 80),
                Name = nameof(DruidBackgroundEnum.RaisedbyBeasts),
                ProperName = "Raised by Beasts",
                Description =
                    "You were reared in part by wild animals. " +
                    "Most of what you know you learned by " +
                    "observing these beasts, their natural " +
                    "instincts being unburdened by artifice " +
                    "or manipulation.Even though you possess a " +
                    "humanoid body, the beasts recognize you " +
                    "as one of their own. You gain access to " +
                    "the Animal Friend gnome race trait (which " +
                    "you may take regardless of your race) and " +
                    "the Feral Heart story feat.",
                Traits =
                [
                    TraitEnum.AnimalFriend,
                    TraitEnum.FeralHeart,
                ]
            },
            #endregion

            #region Avatar
            //81–90	Avatar Once you were an ordinary youth.But when the natural world needed saving, the land chose you as its champion, lending you as much power as you were able to control.You might not understand the reasons for your power, but you are one with nature and your will is the will of the world.You gain access to the Child of Nature religion trait.
            new BackgroundTableEntry
            {
                Range = new Range(81, 90),
                Name = nameof(DruidBackgroundEnum.Avatar),
                ProperName = "Avatar",
                Description =
                    "Once you were an ordinary youth. But when " +
                    "the natural world needed saving, the land " +
                    "chose you as its champion, lending you as " +
                    "much power as you were able to control. " +
                    "You might not understand the reasons for " +
                    "your power, but you are one with nature " +
                    "and your will is the will of the world. " +
                    "You gain access to the Child of Nature " +
                    "religion trait.",
                Traits =
                [
                    TraitEnum.ChildofNature,
                    TraitEnum.MagnumOpus,
                ]
            },
            #endregion

            #region Beastlord
            //91–100	Beastlord Natural birds and beasts have always obeyed you.From your earliest years, you’ve possessed a gentleness or a power that allows you to communicate with animals as though you shared a common language. Perhaps you have fey blood or traces of lycanthrope ancestry. You gain access to the Beast Bond social trait.
            new BackgroundTableEntry
            {
                Range = new Range(91, 100),
                Name = nameof(DruidBackgroundEnum.Beastlord),
                ProperName = "Beastlord",
                Description =
                    "Natural birds and beasts have always obeyed " +
                    "you. From your earliest years, you’ve " +
                    "possessed a gentleness or a power that " +
                    "allows you to communicate with animals as " +
                    "though you shared a common language. Perhaps " +
                    "you have fey blood or traces of lycanthrope " +
                    "ancestry. You gain access to the Beast Bond " +
                    "social trait.",
                Traits =
                [
                    TraitEnum.BeastBond,
                ]
            },
            #endregion
        ];
    }
}
