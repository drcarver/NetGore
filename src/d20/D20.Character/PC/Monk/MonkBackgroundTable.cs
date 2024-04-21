using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;

using D20.Character.Enum;
using D20.Character.Models;
using D20.Character.PC.Ranger;
using D20.Core.Enum;
using D20.Core.Models;

using Microsoft.Maui.Controls.PlatformConfiguration;

namespace D20.Character.PC.Monk;

/// <summary>
/// Masters of the martial arts, monks are the pinnacle of 
/// discipline and perfection.Wielding strange arms and
/// stranger fighting arts, monks are defined by their
/// training.Whether brought up as the protege of a grand
/// master or self-taught through stolen glimpses into the
/// windows of a secret school, a monk’s story is emblazoned
/// in every step, cut, and strike he makes
/// </summary>
public class MonkBackgroundTable : RandomTable, IMonkBackgroundTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public MonkBackgroundTable()
    {
        Name = nameof(MonkBackgroundTable);
        ProperName = "Monk backgrounds";
        TableType = TableTypeEnum.CharacterTable;
        DiceSides = 100;
        Description =
            "Masters of the martial arts, monks are the pinnacle " +
            "of discipline and perfection.Wielding strange arms and " +
            "stranger fighting arts, monks are defined by their " +
            "training.Whether brought up as the protege of a grand " +
            "master or self - taught through stolen glimpses into the " +
            "windows of a secret school, a monk’s story is emblazoned " +
            "in every step, cut, and strike he makes";
    }

    //Table: Monk Backgrounds
    //d%	Result
    //01–10	Bellicose Historian What started as a scholar’s curiosity in exotic fighting styles bloomed into a fanatical desire not just to learn about martial arts, but to master them.You gain access to the Style Sage social trait.
    //11–20	Classically Schooled    Training from dawn to dusk to hone every inch of your body into a fighting instrument, you studied with scores of other students in an academy or school dedicated to one specific martial art. You gain access to the Simple Disciple social trait.
    //21–30	Elite Fighting Force You learned your fighting skills as one of a highly trained group dedicated to a special purpose, such as guarding a temple or protecting a noble.Your training emphasized unobtrusive teamwork and unquestioned dedication to some higher purpose. You gain access to the Veiled Disciple social trait.
    //31–40	Tournament Champion a shining example of your style or order, you’ve honed martial prowess through spirited and exciting competition.You gain access to the Martial Performer combat trait.
    //41–50	Lineage Holder  You are the senior or sole student of a great master.You rose to prominence early and received secret training in an art that is rare and exotic.Having achieved a strong foundation in the physical and metaphysical elements of this martial art, you’ve been designated the lore keeper for its history and traditions, and must now find new student or students to train.You gain access to the Martial Manuscript faith trait.
    //51–60	Nature’s Disciple   Just as many great masters learned and crafted styles from the beauty and majesty of nature, your fighting style comes from time spent in the wild rather than from formal training.You have seen firsthand how the mantis hunts, how the tiger swipes, and how the crane beats its wings.Your observance of the natural world gave you the ability to extrapolate combat forms without traditional training.You gain access to the Nature’s Mimic combat trait.
    //61–70	Secret Student  Your teacher and fellow students grew up as part of a conquered people, forbidden to train at war and forced to conceal the fighting style as seemingly harmless dances and your weapons as mundane tools… until the day you all you could rise up against tyranny.You gain access to the Hidden Hand combat trait.
    //71–80	Spirit Teacher  Your martial training is both physical and metaphysical in nature, allowing you to unlock a higher state of consciousness that allows you to draw on the wisdom and power of long-dead masters. You gain access to the Spirit Sense faith trait.
    //81–90	Unsuspecting Master You were trained in martial arts through unorthodox methods such as seemingly menial tasks or training through conditioning exercises that promised the smallest scrap of food as a reward. Your nontraditional training makes you resourceful and clever. You gain access to the Surprise Weapon combat trait.
    //91–100	Wandering Savant    Although you’ve received some formal training in exotic combat, you decided to put your skills to the test and further your learning by wandering the wide world. You gain access to the Wanderer’s Shroud faith trait.
    /// <summary>
    /// Initialize the game table.  This is a separate method so 
    /// we can create a game table for it's meta properties with 
    /// out creating the actual able values.  A bit of optimization 
    /// to conserve  memory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region Bellicose Historian
            //01–10	Bellicose Historian What started as a scholar’s curiosity in exotic fighting styles bloomed into a fanatical desire not just to learn about martial arts, but to master them.You gain access to the Style Sage social trait.
            new BackgroundTableEntry
            {
                Range = new Range(01, 10),
                Name = nameof(MonkBackgroundEnum.BellicoseHistorian),
                ProperName = "Bellicose Historian",
                Description =
                    "What started as a scholar’s curiosity in " +
                    "exotic fighting styles bloomed into a " +
                    "fanatical desire not just to learn about " +
                    "martial arts, but to master them. You " +
                    "gain access to the Style Sage social trait.",
                Traits =
                [
                    TraitEnum.StyleSage,
                ]
            },
            #endregion

            #region Classically Schooled
            //11–20	Classically Schooled    Training from dawn to dusk to hone every inch of your body into a fighting instrument, you studied with scores of other students in an academy or school dedicated to one specific martial art. You gain access to the Simple Disciple social trait.
            new BackgroundTableEntry
            {
                Range = new Range(11, 20),
                Name = nameof(MonkBackgroundEnum.ClassicallySchooled),
                ProperName = "Classically Schooled",
                Description =
                    "Training from dawn to dusk to hone every " +
                    "inch of your body into a fighting instrument, " +
                    "you studied with scores of other students " +
                    "in an academy or school dedicated to one " +
                    "specific martial art. You gain access to " +
                    "the Simple Disciple social trait.",
                Traits =
                [
                    TraitEnum.SimpleDisciple,
                ]
            },
            #endregion

            #region Elite Fighting Force
            //21–30	Elite Fighting Force You learned your fighting skills as one of a highly trained group dedicated to a special purpose, such as guarding a temple or protecting a noble.Your training emphasized unobtrusive teamwork and unquestioned dedication to some higher purpose. You gain access to the Veiled Disciple social trait.
            new BackgroundTableEntry
            {
                Range = new Range(21, 30),
                Name = nameof(MonkBackgroundEnum.EliteFightingForce),
                ProperName = "Elite Fighting Force",
                Description =
                    "You learned your fighting skills as one of " +
                    "a highly trained group dedicated to a " +
                    "special purpose, such as guarding a temple " +
                    "or protecting a noble.Your training " +
                    "emphasized unobtrusive teamwork and " +
                    "unquestioned dedication to some higher " +
                    "purpose. You gain access to the Veiled " +
                    "Disciple social trait.",
                Traits =
                [
                    TraitEnum.VeiledDisciple,
                ]
            },
            #endregion

            #region Tournament Champion
            //31–40	Tournament Champion a shining example of your style or order, you’ve honed martial prowess through spirited and exciting competition.You gain access to the Martial Performer combat trait.
            new BackgroundTableEntry
            {
                Range = new Range(31, 40),
                Name = nameof(MonkBackgroundEnum.TournamentChampion),
                ProperName = "Tournament Champion",
                Description =
                    "A shining example of your style or order, " +
                    "you’ve honed martial prowess through " +
                    "spirited and exciting competition. You " +
                    "gain access to the Martial Performer " +
                    "combat trait.",
                Traits =
                [
                    TraitEnum.MartialPerformer,
                ]
            },
            #endregion

            #region Lineage Holder
            //41–50	Lineage Holder  You are the senior or sole student of a great master.You rose to prominence early and received secret training in an art that is rare and exotic.Having achieved a strong foundation in the physical and metaphysical elements of this martial art, you’ve been designated the lore keeper for its history and traditions, and must now find new student or students to train.You gain access to the Martial Manuscript faith trait.
             new BackgroundTableEntry
            {
                Range = new Range(41, 50),
                Name = nameof(MonkBackgroundEnum.LineageHolder),
                ProperName = "Lineage Holder",
                Description =
                    "You are the senior or sole student of a " +
                    "great master.You rose to prominence early " +
                    "and received secret training in an art " +
                    "that is rare and exotic. Having achieved " +
                    "a strong foundation in the physical and " +
                    "metaphysical elements of this martial art, " +
                    "you’ve been designated the lore keeper " +
                    "for its history and traditions, and must " +
                    "now find new student or students to train. " +
                    "You gain access to the Martial Manuscript " +
                    "faith trait.",
                Traits =
                [
                    TraitEnum.MartialManuscript,
                ]
            },
            #endregion

            #region Nature’s Disciple
            //51–60	Nature’s Disciple   Just as many great masters learned and crafted styles from the beauty and majesty of nature, your fighting style comes from time spent in the wild rather than from formal training.You have seen firsthand how the mantis hunts, how the tiger swipes, and how the crane beats its wings.Your observance of the natural world gave you the ability to extrapolate combat forms without traditional training.You gain access to the Nature’s Mimic combat trait.
            new BackgroundTableEntry
            {
                Range = new Range(51, 60),
                Name = nameof(MonkBackgroundEnum.NaturesDisciple),
                ProperName = "Nature’s Disciple",
                Description =
                    "Just as many great masters learned and " +
                    "crafted styles from the beauty and majesty " +
                    "of nature, your fighting style comes from " +
                    "time spent in the wild rather than from " +
                    "formal training. You have seen firsthand " +
                    "how the mantis hunts, how the tiger swipes, " +
                    "and how the crane beats its wings. Your " +
                    "observance of the natural world gave you " +
                    "the ability to extrapolate combat forms " +
                    "without traditional training. You gain " +
                    "access to the Nature’s Mimic combat trait.",
                Traits =
                [
                    TraitEnum.NaturesMimic,
                ]
            },
            #endregion

            #region Secret Student
            //61–70	Secret Student  Your teacher and fellow students grew up as part of a conquered people, forbidden to train at war and forced to conceal the fighting style as seemingly harmless dances and your weapons as mundane tools… until the day you all you could rise up against tyranny.You gain access to the Hidden Hand combat trait.
            new BackgroundTableEntry
            {
                Range = new Range(61, 70),
                Name = nameof(MonkBackgroundEnum.SecretStudent),
                ProperName = "Secret Student",
                Description =
                    "Your teacher and fellow students grew " +
                    "up as part of a conquered people, forbidden " +
                    "to train at war and forced to conceal " +
                    "the fighting style as seemingly harmless " +
                    "dances and your weapons as mundane tools… " +
                    "until the day you all you could rise up " +
                    "against tyranny. You gain access to the " +
                    "Hidden Hand combat trait.",
                Traits =
                [
                    TraitEnum.HiddenHand,
                ]
            },
            #endregion

            #region Spirit Teacher
            //71–80	Spirit Teacher  Your martial training is both physical and metaphysical in nature, allowing you to unlock a higher state of consciousness that allows you to draw on the wisdom and power of long-dead masters. You gain access to the Spirit Sense faith trait.
            new BackgroundTableEntry
            {
                Range = new Range(71, 80),
                Name = nameof(MonkBackgroundEnum.SpiritTeacher),
                ProperName = "Spirit Teacher",
                Description =
                    "Your martial training is both physical " +
                    "and metaphysical in nature, allowing you " +
                    "to unlock a higher state of consciousness " +
                    "that allows you to draw on the wisdom and " +
                    "power of long-dead masters. You gain " +
                    "access to the Spirit Sense faith trait.",
                Traits =
                [
                    TraitEnum.SpiritSense,
                ]
            },
            #endregion

            #region Unsuspecting Master
            //81–90	Unsuspecting Master You were trained in martial arts through unorthodox methods such as seemingly menial tasks or training through conditioning exercises that promised the smallest scrap of food as a reward. Your nontraditional training makes you resourceful and clever. You gain access to the Surprise Weapon combat trait.
            new BackgroundTableEntry
            {
                Range = new Range(81, 90),
                Name = nameof(MonkBackgroundEnum.UnsuspectingMaster),
                ProperName = "Unsuspecting Master",
                Description =
                    "You were trained in martial arts through " +
                    "unorthodox methods such as seemingly " +
                    "menial tasks or training through conditioning " +
                    "exercises that promised the smallest " +
                    "scrap of food as a reward. Your nontraditional " +
                    "training makes you resourceful and clever. " +
                    "You gain access to the Surprise Weapon combat " +
                    "trait.",
                Traits =
                [
                    TraitEnum.SurpriseWeapon,
                ]
            },
            #endregion

            #region Wandering Savant
            //91–100	Wandering Savant    Although you’ve received some formal training in exotic combat, you decided to put your skills to the test and further your learning by wandering the wide world. You gain access to the Wanderer’s Shroud faith trait.
            new BackgroundTableEntry
            {
                Range = new Range(91, 100),
                Name = nameof(MonkBackgroundEnum.WanderingSavant),
                ProperName = "Wandering Savant",
                Description =
                    "Although you’ve received some formal " +
                    "training in exotic combat, you decided " +
                    "to put your skills to the test and " +
                    "further your learning by wandering the " +
                    "wide world. You gain access to the " +
                    "Wanderer’s Shroud faith trait.",
                Traits =
                [
                    TraitEnum.WanderersShroud,
                ]
            },
            #endregion
        ];
    }
}




