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
/// During your childhood, you were influenced by 
/// a significant event that helped to shape the 
/// person you became. Roll on Table: Major 
/// Childhood Event to determine the type of 
/// event that shaped you in early childhood.
/// </summary>
public partial class BackgroundTables
{
    //Table: Major Childhood Event
    //d%	Result
    //01–05	Academy Training    You attended a private academy where you studied a number of skills and gained training in your current profession.Whether you were a brilliant student or a dropout, the university environment was your home for a good portion of your formative years.You gain access to the Focused Mind magic trait.
    //06–10	Betrayal a friend or family member whom you trusted more than anyone else betrayed you.You have never fully trusted anyone since and prefer to rely on your own abilities rather than place your trust in others.You gain access to the Suspicious social trait.
    //11–15	Bullied In your early life, you were a victim—easy prey for those stronger or cleverer than yourself. They beat you when they could, using you for their sport.This abuse nursed a powerful flame of vengeance.You gain access to the Bullied combat trait.
    //16–20	Competition Champion    You distinguished yourself at an early age when you won a competition. This might have been a martial contest of arms, a showing of apprentice magicians, high stakes gambling, or something mundane like an eating championship.You gain access to the Influence social trait and the Champion story feat.
    //21–25	Death in the Family You were profoundly affected by the death of the relative closest to you—a parent, grandparent, favorite sibling, aunt, uncle, or cousin. This death affected you profoundly, and you’ve never been able to let go of it.You gain access to the Reactionary combat trait and the Deny the Reaper story feat.
    //26–30	Died You died, or came so close to death that you walked the boundary between the realms of the living and the dead. Having passed from life’s domain once, you have a unique perspective on life, perhaps even a greater appreciation for it—or maybe your experience caused you to reject all trivial things, focusing only on matters of true import.You gain access to the Fearless Defiance faith trait and the Arisen story feat.
    //31–35	Fall of a Major Power In your early years, an old power with far-reaching influence fell into decline.This could have been an empire, a major organization or gang, or a person such as a benevolent king or evil dictator. Your early memories were founded in a world where this great power affected your region for good or ill.You gain access to the Worldly social trait.
    //36–40	Fell in with a Bad Crowd    In your youth, you ran with a brutal, evil, or sadistic crowd.You might have belonged to a gang, a thieves’ guild, or some other nefarious organization.It was easy to cave in to pressure and do whatever they told you to do, and your outlook is colored by moral ambiguity. You gain access to the Child of the Streets social trait.
    //41–45	First Kill  You’ve had blood on your hands since your youth, when you first took the life of another creature.Whether this act repulsed you or gave you pleasure, it was a formative experience.You gain access to the Killer combat trait and the Innocent Blood story feat.
    //46–50	Troubled First Love Your first love was everything you imagined it would be.That is, until you were separated from your beloved.This may have been the result of distance, changing perspectives, death, or differences in class or family.Some have said this made you jaded—you think it has granted you insight on how the world really works.You gain access to the Worldly social trait and you roll a d12 instead of a d20 on Table: Romantic Relationships.
    //51–55	Imprisoned Your criminal record began when you were young.You were imprisoned, punished, and possibly displayed in public as a criminal.Whether or not you committed the crime, the experience has stayed with you. You gain access to the Criminal social trait. See the Crime and Punishment section. You also gain access to the Liberator story feat.
    //56–60	Inheritance A great sum of wealth or property was bequeathed to you at an early age, providing you with extraordinary means.Daily costs of living have ceased to concern you, and you’ve learned that there is little that money cannot buy.You gain access to the Rich Parents social trait.
    //61–65	Kidnapped You were kidnapped at some point in your childhood. The kidnappers might have been pirates, slavers, thieves looking for ransom, a powerful guild seeking to blackmail your parents, a cult, and so on else. Before you were released, were ransomed, or escaped, you picked up on various aspects of the criminal underworld. You gain access to the Canter social trait and the Liberator story feat.
    //66–70	Magical Gift    When you were a child, you found, stole, or were given a magic item that gave you an extraordinary ability. You may have used this item for mischief, crime, or good. Since that time, magic items have always held a special fascination for you.You gain access to the Magical Talent magic trait.
    //71–75	Major Disaster  You witnessed—and survived—a major disaster in your childhood years, such as a great fire, flood, earthquake, volcano, or storm. It obliterated the settlement where you lived, whether a small village, large city, or entire island.You gain access to the Resilient combat trait and the Unforgotten story feat.
    //76–80	Mentorship/Patronage a mentor or patron took an interest in your development and volunteered to train or sponsor you.This creature’s motives might not be entirely clear, but without its influence you would not be who you are.You gain access to the Mentored social trait.
    //81–85	Met a Fantastic Creature    When you were only a child, you made contact with a magical creature, such as a dragon, unicorn, genie, pixie, or similar creature.You learned a powerful lesson or a magic trick from that creature. This meeting changed your life and made you different from the other children.You gain access to the Gifted Adept magic trait.
    //86–90	Ordinary Childhood  Your childhood was fairly ordinary, with no major blessing or catastrophe—a stark contrast to an adventuring life.You lived your life in anticipation of growing up so you could affect the dull backdrop upon which your mundane life was painted. Now that you’ve grown, it’s easy to miss those tranquil days where nothing ever seemed to happen.You gain access to the Ordinary social trait.
    //91–95	Raiders a horde of raiders attacked your settlement and killed several of your people. This could have been a tribe of brutal humanoids or the conquering army of a civilized nation.As a result, you harbor deep resentment toward a particular faction, race, or country. You gain access to the Axe to Grind combat trait, the Foeslayer story feat, and the Vengeance story feat.
    //96–100	The War You grew up against the backdrop of a major military conflict that affected much of your childhood world. You became accustomed to a short food supply, living in occupied territory, and moving from place to place. Several of the people you knew in your childhood were lost in the war, including members of your family.You gain access to the Vagabond Child regional trait and the Deny the Reaper story feat.
    /// <summary>
    /// Major Childhood Event
    /// </summary>
    public static RandomTable MajorChildhoodEventTable { get; } = new()
    {
        Name = "Major Childhood Event Table",
        DiceSides = 100,
        Table =
        [
            #region "Academy Training"
            //01–05	Academy Training You attended a private academy where you studied a number of skills and gained training in your current profession.Whether you were a brilliant student or a dropout, the university environment was your home for a good portion of your formative years.You gain access to the Focused Mind magic trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 05,
                Name = nameof(MajorChildhoodEventEnum.AcademyTraining),
                ProperName = "Academy Training",
                Description =
                    "You attended a private academy " +
                    "where you studied a number of " +
                    "skills and gained training in " +
                    "your current profession. Whether " +
                    "you were a brilliant student or " +
                    "a dropout, the university " +
                    "environment was your home for " +
                    "a good portion of your formative " +
                    "years. You gain access to the " +
                    "Focused Mind magic trait.",
                Traits =
                {
                    TraitEnum.FocusedMind,
                },

            },
            #endregion

            #region "Betrayal"
            //06–10	Betrayal a friend or family member whom you trusted more than anyone else betrayed you.You have never fully trusted anyone since and prefer to rely on your own abilities rather than place your trust in others.You gain access to the Suspicious social trait.
            new RandomTableEntry
            {
                LowerRange = 06,
                UpperRange = 10,
                Name = nameof(MajorChildhoodEventEnum.Betrayal),
                Description =
                    "A friend or family member whom " +
                    "you trusted more than anyone " +
                    "else betrayed you. You have " +
                    "never fully trusted anyone since " +
                    "and prefer to rely on your own " +
                    "abilities rather than place your " +
                    "trust in others. You gain access " +
                    "to the Suspicious social trait.",
                Traits =
                {
                    TraitEnum.Suspicious,
                },

            },
            #endregion

            #region "Bullied"
            //11–15	Bullied In your early life, you were a victim—easy prey for those stronger or cleverer than yourself. They beat you when they could, using you for their sport.This abuse nursed a powerful flame of vengeance.You gain access to the Bullied combat trait.
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 15,
                Name = nameof(MajorChildhoodEventEnum.Bullied),
                Description =
                    "In your early life, you were a " + 
                    "victim—easy prey for those " +
                    "stronger or cleverer than " +
                    "yourself. They beat you when " +
                    "they could, using you for " +
                    "their sport. This abuse nursed " +
                    "a powerful flame of vengeance. " +
                    "You gain access to the Bullied " +
                    "combat trait.",
                Traits =
                {
                    TraitEnum.Bullied,
                },

            },
            #endregion

            #region "Competition Champion"
            //16–20	Competition Champion You distinguished yourself at an early age when you won a competition. This might have been a martial contest of arms, a showing of apprentice magicians, high stakes gambling, or something mundane like an eating championship.You gain access to the Influence social trait and the Champion story feat.
            new RandomTableEntry
            {
                LowerRange = 16,
                UpperRange = 20,
                Name = nameof(MajorChildhoodEventEnum.CompetitionChampion),
                ProperName = "Competition Champion",
                Description =
                    "You distinguished yourself at an " +
                    "early age when you won a " +
                    "competition. This might have been " +
                    "a martial contest of arms, a " +
                    "showing of apprentice magicians, " +
                    "high stakes gambling, or something " +
                    "mundane like an eating championship. " +
                    "You gain access to the Influence " +
                    "social trait and the Champion story " +
                    "feat.",
                Traits =
                {
                    TraitEnum.Influence,
                    //TraitEnum.Champion,
                },

            },
            #endregion

            #region "Death in the Family"
            //21–25	Death in the Family You were profoundly affected by the death of the relative closest to you—a parent, grandparent, favorite sibling, aunt, uncle, or cousin. This death affected you profoundly, and you’ve never been able to let go of it.You gain access to the Reactionary combat trait and the Deny the Reaper story feat.
            new RandomTableEntry
            {
                LowerRange = 21,
                UpperRange = 25,
                Name = nameof(MajorChildhoodEventEnum.DeathintheFamily),
                ProperName = "Death in the Family",
                Description =
                    "You were profoundly affected by " +
                    "the death of the relative closest " +
                    "to you—a parent, grandparent, " +
                    "favorite sibling, aunt, uncle, or " +
                    "cousin. This death affected you " +
                    "profoundly, and you’ve never been " +
                    "able to let go of it. You gain " +
                    "access to the Reactionary combat " +
                    "trait and the Deny the Reaper " +
                    "story feat.",
                Traits =
                {
                    TraitEnum.Reactionary,
                    //TraitEnum.DenytheReaper,
                },

            },
            #endregion

            #region "Died"
            //26–30	Died You died, or came so close to death that you walked the boundary between the realms of the living and the dead. Having passed from life’s domain once, you have a unique perspective on life, perhaps even a greater appreciation for it—or maybe your experience caused you to reject all trivial things, focusing only on matters of true import.You gain access to the Fearless Defiance faith trait and the Arisen story feat.
            new RandomTableEntry
            {
                LowerRange = 26,
                UpperRange = 30,
                Name = nameof(MajorChildhoodEventEnum.Died),
                ProperName = "Died",
                Description =
                    "You died, or came so close to " +
                    "death that you walked the boundary " +
                    "between the realms of the living " +
                    "and the dead. Having passed from " +
                    "life’s domain once, you have a " +
                    "unique perspective on life, perhaps " +
                    "even a greater appreciation for " +
                    "it—or maybe your experience caused " +
                    "you to reject all trivial things, " +
                    "focusing only on matters of true " +
                    "import.You gain access to the " +
                    "Fearless Defiance faith trait and " +
                    "the Arisen story feat.",
                Traits =
                {
                    TraitEnum.FearlessDefiance,
                    //TraitEnum.Arisen,
                },

            },
            #endregion

            #region "Fall of a Major Power"
            //31–35	Fall of a Major Power In your early years, an old power with far-reaching influence fell into decline.This could have been an empire, a major organization or gang, or a person such as a benevolent king or evil dictator. Your early memories were founded in a world where this great power affected your region for good or ill.You gain access to the Worldly social trait.
            new RandomTableEntry
            {
                LowerRange = 31,
                UpperRange = 35,
                Name = nameof(MajorChildhoodEventEnum.FallofaMajorPower),
                ProperName = "Fall of a Major Power",
                Description =
                    "In your early years, an old power " +
                    "with far-reaching influence fell " +
                    "into decline. This could have been " +
                    "an empire, a major organization or " +
                    "gang, or a person such as a " +
                    "benevolent king or evil dictator. " +
                    "Your early memories were founded " +
                    "in a world where this great power " +
                    "affected your region for good or " +
                    "ill. You gain access to the Worldly " +
                    "social trait.",
                Traits =
                {
                    TraitEnum.Worldly,
                },
            },
            #endregion

            #region "Fell in with a Bad Crowd"
            //36–40	Fell in with a Bad Crowd In your youth, you ran with a brutal, evil, or sadistic crowd.You might have belonged to a gang, a thieves’ guild, or some other nefarious organization.It was easy to cave in to pressure and do whatever they told you to do, and your outlook is colored by moral ambiguity. You gain access to the Child of the Streets social trait.
            new RandomTableEntry
            {
                LowerRange = 36,
                UpperRange = 40,
                Name = nameof(MajorChildhoodEventEnum.FellinwithaBadCrowd),
                ProperName = "Fell in with a Bad Crowd",
                Description =
                    "In your " +
                    "youth, you ran with a brutal, evil, " +
                    "or sadistic crowd. You might have " +
                    "belonged to a gang, a thieves’ " +
                    "guild, or some other nefarious " +
                    "organization. It was easy to cave " +
                    "in to pressure and do whatever they " +
                    "told you to do, and your outlook " +
                    "is colored by moral ambiguity. You " +
                    "gain access to the Child of the Streets " +
                    "social trait.",
                Traits =
                {
                    TraitEnum.ChildoftheStreets,
                },
            },
            #endregion

            #region "First Kill"
            //41–45	First Kill You’ve had blood on your hands since your youth, when you first took the life of another creature.Whether this act repulsed you or gave you pleasure, it was a formative experience.You gain access to the Killer combat trait and the Innocent Blood story feat.
            new RandomTableEntry
            {
                LowerRange = 41,
                UpperRange = 45,
                Name = nameof(MajorChildhoodEventEnum.FirstKill),
                ProperName = "First Kill",
                Description =
                    "You’ve had blood on your hands " +
                    "since your youth, when you first " +
                    "took the life of another creature. " +
                    "Whether this act repulsed you or " +
                    "gave you pleasure, it was a " +
                    "formative experience. You gain " +
                    "access to the Killer combat trait " +
                    "and the Innocent Blood story feat.",
                Traits =
                {
                    TraitEnum.Killer,
                    //TraitEnum.InnocentBlood,
                },
            },
            #endregion

            #region "Troubled First Love"
            //46–50	Troubled First Love Your first love was everything you imagined it would be.That is, until you were separated from your beloved.This may have been the result of distance, changing perspectives, death, or differences in class or family.Some have said this made you jaded—you think it has granted you insight on how the world really works.You gain access to the Worldly social trait and you roll a d12 instead of a d20 on Table: Romantic Relationships.
            new RandomTableEntry
            {
                LowerRange = 46,
                UpperRange = 50,
                Name = nameof(MajorChildhoodEventEnum.TroubledFirstLove),
                ProperName = "Troubled First Love",
                Description =
                    "Your first love was everything " +
                    "you imagined it would be.That is, " +
                    "until you were separated from " +
                    "your beloved. This may have been " +
                    "the result of distance, changing " +
                    "perspectives, death, or differences " +
                    "in class or family. Some have said " +
                    "this made you jaded—you think it " +
                    "has granted you insight on how " +
                    "the world really works .You gain " +
                    "access to the Worldly social trait " +
                    "and you roll a d12 instead of a " +
                    "d20 on Table: Romantic Relationships.",
                Traits =
                {
                    TraitEnum.Worldly,
                },
            },
            #endregion

            #region "Imprisoned"
            //51–55	Imprisoned Your criminal record began when you were young.You were imprisoned, punished, and possibly displayed in public as a criminal.Whether or not you committed the crime, the experience has stayed with you. You gain access to the Criminal social trait. See the Crime and Punishment section. You also gain access to the Liberator story feat.
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 55,
                Name = nameof(MajorChildhoodEventEnum.Imprisoned),
                ProperName = "Imprisoned",
                Description =
                    "Your criminal record began when " +
                    "you were young.You were imprisoned, " +
                    "punished, and possibly displayed in " +
                    "public as a criminal. Whether or not " +
                    "you committed the crime, the " +
                    "experience has stayed with you. " +
                    "You gain access to the Criminal social " +
                    "trait. See the Crime and Punishment " +
                    "section. You also gain access to the " +
                    "Liberator story feat.",
                Traits =
                {
                    TraitEnum.Criminal,
                    //TraitEnum.Liberator
                },
            },
            #endregion

            #region "Inheritance"
            //56–60	Inheritance A great sum of wealth or property was bequeathed to you at an early age, providing you with extraordinary means.Daily costs of living have ceased to concern you, and you’ve learned that there is little that money cannot buy.You gain access to the Rich Parents social trait.
            new RandomTableEntry
            {
                LowerRange = 56,
                UpperRange = 60,
                Name = nameof(MajorChildhoodEventEnum.Inheritance),
                ProperName = "Inheritance",
                Description =
                    "A great sum of wealth or property " +
                    "was bequeathed to you at an early " +
                    "age, providing you with extraordinary " +
                    "means. Daily costs of living have " +
                    "ceased to concern you, and you’ve " +
                    "learned that there is little that " +
                    "money cannot buy. You gain access " +
                    "to the Rich Parents social trait.",
                Traits =
                {
                    TraitEnum.RichParents,
                },
            },
            #endregion

            #region "Kidnapped"
            //61–65	Kidnapped You were kidnapped at some point in your childhood. The kidnappers might have been pirates, slavers, thieves looking for ransom, a powerful guild seeking to blackmail your parents, a cult, and so on else. Before you were released, were ransomed, or escaped, you picked up on various aspects of the criminal underworld. You gain access to the Canter social trait and the Liberator story feat.
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 65,
                Name = nameof(MajorChildhoodEventEnum.Kidnapped),
                ProperName = "Kidnapped",
                Description =
                    "You were kidnapped at some point " +
                    "in your childhood. The kidnappers " +
                    "might have been pirates, slavers, " +
                    "thieves looking for ransom, a " +
                    "powerful guild seeking to blackmail " +
                    "your parents, a cult, and so on else. " +
                    "Before you were released, were ransomed, " +
                    "or escaped, you picked up on various " +
                    "aspects of the criminal underworld. " +
                    "You gain access to the Canter social " +
                    "trait and the Liberator story feat.",
                Traits =
                {
                    TraitEnum.Canter,
                },
            },
            #endregion

            #region "Magical Gift"
            //66–70	Magical Gift When you were a child, you found, stole, or were given a magic item that gave you an extraordinary ability. You may have used this item for mischief, crime, or good. Since that time, magic items have always held a special fascination for you.You gain access to the Magical Talent magic trait.
            new RandomTableEntry
            {
                LowerRange = 66,
                UpperRange = 70,
                Name = nameof(MajorChildhoodEventEnum.MagicalGift),
                ProperName = "Magical Gift",
                Description =
                    "When you were a child, you found, " +
                    "stole, or were given a magic item " +
                    "that gave you an extraordinary " +
                    "ability. You may have used this " +
                    "item for mischief, crime, or good. " +
                    "Since that time, magic items have " +
                    "always held a special fascination " +
                    "for you. You gain access to the " +
                    "Magical Talent magic trait.",
                Traits =
                {
                    TraitEnum.MagicalTalent,
                },
            },
            #endregion

            #region "Major Disaster"
            //71–75	Major Disaster You witnessed—and survived—a major disaster in your childhood years, such as a great fire, flood, earthquake, volcano, or storm. It obliterated the settlement where you lived, whether a small village, large city, or entire island.You gain access to the Resilient combat trait and the Unforgotten story feat.
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 75,
                Name = nameof(MajorChildhoodEventEnum.MajorDisaster),
                ProperName = "Major Disaster",
                Description =
                    "You witnessed—and survived—a " +
                    "major disaster in your childhood " +
                    "years, such as a great fire, " +
                    "flood, earthquake, volcano, or " +
                    "storm. It obliterated the " +
                    "settlement where you lived, " +
                    "whether a small village, large " +
                    "city, or entire island. You " +
                    "gain access to the Resilient " +
                    "combat trait and the Unforgotten " +
                    "story feat.",
                Traits =
                {
                    TraitEnum.Resilient,
                },
            },
            #endregion

            #region "Mentorship/Patronage"
            //76–80	Mentorship/Patronage a mentor or patron took an interest in your development and volunteered to train or sponsor you.This creature’s motives might not be entirely clear, but without its influence you would not be who you are.You gain access to the Mentored social trait.
            new RandomTableEntry
            {
                LowerRange = 76,
                UpperRange = 80,
                Name = nameof(MajorChildhoodEventEnum.MentorshipPatronage),
                ProperName = "Mentorship/Patronage",
                Description =
                    "A mentor or patron took an " +
                    "interest in your development " +
                    "and volunteered to train or " +
                    "sponsor you.This creature’s " +
                    "motives might not be entirely " +
                    "clear, but without its " +
                    "influence you would not be who " +
                    "you are.You gain access to the " +
                    "Mentored social trait.",
                Traits =
                {
                    TraitEnum.Mentored,
                },
            },
            #endregion

            #region "Met a Fantastic Creature"
            //81–85	Met a Fantastic Creature When you were only a child, you made contact with a magical creature, such as a dragon, unicorn, genie, pixie, or similar creature.You learned a powerful lesson or a magic trick from that creature. This meeting changed your life and made you different from the other children.You gain access to the Gifted Adept magic trait.
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 85,
                Name = nameof(MajorChildhoodEventEnum.MetaFantasticCreature),
                ProperName = "Met a Fantastic Creature",
                Description =
                    "When you were only a child, you " +
                    "made contact with a magical " +
                    "creature, such as a dragon, " +
                    "unicorn, genie, pixie, or " +
                    "similar creature. You learned " +
                    "a powerful lesson or a magic " +
                    "trick from that creature. " +
                    "This meeting changed your " +
                    "life and made you different " +
                    "from the other children. You " +
                    "gain access to the Gifted Adept " +
                    "magic trait.",
                Traits =
                {
                    TraitEnum.GiftedAdept,
                },
            },
            #endregion

            #region "Ordinary Childhood"
            //86–90	Ordinary Childhood  Your childhood was fairly ordinary, with no major blessing or catastrophe—a stark contrast to an adventuring life.You lived your life in anticipation of growing up so you could affect the dull backdrop upon which your mundane life was painted. Now that you’ve grown, it’s easy to miss those tranquil days where nothing ever seemed to happen.You gain access to the Ordinary social trait.
            new RandomTableEntry
            {
                LowerRange = 86,
                UpperRange = 90,
                Name = nameof(MajorChildhoodEventEnum.OrdinaryChildhood),
                ProperName = "Ordinary Childhood",
                Description =
                    "Your childhood was fairly ordinary, " +
                    "with no major blessing or " +
                    "catastrophe—a stark contrast to " +
                    "an adventuring life. You lived " +
                    "your life in anticipation of " +
                    "growing up so you could affect " +
                    "the dull backdrop upon which " +
                    "your mundane life was painted. " +
                    "Now that you’ve grown, it’s easy " +
                    "to miss those tranquil days where " +
                    "nothing ever seemed to happen. " +
                    "You gain access to the Ordinary " +
                    "social trait.",
                Traits =
                {
                    TraitEnum.Ordinary,
                },
            },
            #endregion

            #region "Raiders"
            //91–95	Raiders a horde of raiders attacked your settlement and killed several of your people. This could have been a tribe of brutal humanoids or the conquering army of a civilized nation.As a result, you harbor deep resentment toward a particular faction, race, or country. You gain access to the Axe to Grind combat trait, the Foeslayer story feat, and the Vengeance story feat.
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 95,
                Name = nameof(MajorChildhoodEventEnum.Raiders),
                ProperName = "Raiders",
                Description =
                    "A horde of raiders attacked your " +
                    "settlement and killed several of " +
                    "your people. This could have been " +
                    "a tribe of brutal humanoids or the " +
                    "conquering army of a civilized " +
                    "nation. As a result, you harbor " +
                    "deep resentment toward a " +
                    "particular faction, race, or country. " +
                    "You gain access to the Axe to Grind " +
                    "combat trait, the Foeslayer story " +
                    "feat, and the Vengeance story feat.",
                Traits =
                {
                    TraitEnum.AxetoGrind,
                },
            },
            #endregion

            #region "War"
            //96–100 The War You grew up against the backdrop of a major military conflict that affected much of your childhood world. You became accustomed to a short food supply, living in occupied territory, and moving from place to place. Several of the people you knew in your childhood were lost in the war, including members of your family.You gain access to the Vagabond Child regional trait and the Deny the Reaper story feat.
            new RandomTableEntry
            {
                LowerRange = 96,
                UpperRange = 100,
                Name = nameof(MajorChildhoodEventEnum.War),
                ProperName = "War",
                Description =
                    "You grew up against the backdrop " +
                    "of a major military conflict that " +
                    "affected much of your childhood " +
                    "world. You became accustomed to a " +
                    "short food supply, living in " +
                    "occupied territory, and moving " +
                    "from place to place. Several of " +
                    "the people you knew in your " +
                    "childhood were lost in the war, " +
                    "including members of your family. " +
                    "You gain access to the Vagabond " +
                    "Child regional trait and the " +
                    "Deny the Reaper story feat.",
                Traits =
                {
                    TraitEnum.VagabondChild,
                    //TraitEnum.DenytheReaper,
                },
            },
            #endregion
        ]
    };
}
