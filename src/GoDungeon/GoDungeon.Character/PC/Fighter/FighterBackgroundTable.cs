using System;
using System.Collections.ObjectModel;

using GoDungeon.Background.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Character.PC.Fighter
{
    /// <summary>
    /// Those who become fighters take up the sword for many reasons.
    /// Some fight for coin, others for duty, and others for survival. 
    /// </summary>
    public class FighterBackgroundTable : RandomTable, IFighterBackgroundTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FighterBackgroundTable()
        {
            Name = nameof(FighterBackgroundTable);
            ProperName = "Fighter backgrounds";
            TableType = TableTypeEnum.CharacterTable;
            DiceSides = 100;
            Description =
                "Those who become fighters take up the sword for " +
                "many reasons. Some fight for coin, others for " +
                "duty, and others for survival.";
        }

        //Table: Fighter Backgrounds
        //d%	Result
        //01–10	Adventure Since you can remember, you sought to become a great warrior.Inspired by legends of the past or personal heroes of your civilization, you longed to wield steel and carve your way in the world.You gain access to the Seeker social trait.
        //11–20	Conscripted You didn’t choose the military life so much as you were drafted into it.You have a non-military background and skill set.Who knows what course your life might have taken had you not been forced to take up arms? You gain access to the Worldly social trait.
        //21–30	Duty You took up the sword because no one else would.When a great danger threatened your home, you stepped forth to meet the challenge, though you were only a youth with just the strength of your arm and steadfastness of your courage to see you through. You gain access to the Courageous combat trait.
        //31–40	Gladiator As an adolescent, you learned to fight and kill because your master made you, and if you had not learned, you would be dead. Killing was a way of life—a means of survival. At first you did it because you had to, but that soon changed when you heard the chorus of the crowd. You gain access to the Killer combat trait, the Life of Toil social trait, and the Champion story feat.
        //41–50	Joined the Watch Your village, town, city, or tribe needed new recruits for the volunteer watch patrol, and you joined up—whether for money, duty, peace, or power.This rudimentary training gave you an understanding of civilized justice and showed you how to wield a weapon with skill.You gain access to the Militia Veteran regional trait.
        //51–60	Knighted Your military path began when you were knighted or made a squire to a knight. Your family’s status could have influenced this event, or you might be a simple commoner rewarded with a title for a rare feat of courage.As a member of the nobility, you gain access to the Influence social trait.
        //61–70	Mercenary Everyone needs to earn a living, and in your youth you were fast, strong, or tough enough to fight for pay.There are good causes and bad causes, but at the end of the day, it all comes down to money. Sometimes you got easy jobs, like guarding merchant caravans; other times the jobs are rough, like fighting in a rebel lord’s private army.You gain access to the Mercenary social trait.
        //71–80	On the Street You spent adolescence in a seedy part of town.You learned to fight dirty and fight mean. Turns out you were good at it.Your skills drew the interest of gang and guild leaders, tavern keepers, and anyone else who needed hired muscle. You gain access to the Child of the Streets social trait.
        //81–90	Schooled You learned to fight in a structured environment where you were exposed to a variety of weapons, armor, strategies, and tactics. You learned to fight as part of a unit, how to follow orders and how to command a squad. You gain access to the Tactician combat trait.
        //91–100	Survival You spent some part of your life in the wild—in places that abide by the laws of nature rather than those of civilization.You survived by being stronger, faster, and more cunning than the predators. That meant you fought not for coin, honor, or principle, but for your very life.You gain access to the Resilient combat trait.
        /// <summary>
        /// Initialize the game table.This is a separate method so 
        /// we can create a game table for it's meta properties with 
        /// out creating the actual able values.A bit of optimization 
        /// to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            Table = new ObservableCollection<IGameTableEntry>
            {
                #region Adventure
                //01–10	Adventure Since you can remember, you sought to become a great warrior.Inspired by legends of the past or personal heroes of your civilization, you longed to wield steel and carve your way in the world.You gain access to the Seeker social trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(01, 10),
                    Name = nameof(FighterBackgroundEnum.Adventure),
                    ProperName = "Adventure",
                    Description =
                        "Since you can remember, you sought to " +
                        "become a great warrior.Inspired by " +
                        "legends of the past or personal heroes " +
                        "of your civilization, you longed to wield " +
                        "steel and carve your way in the world. " +
                        "You gain access to the Seeker social trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.Seeker,
                    }
                },
                #endregion

                #region Conscripted
                //11–20	Conscripted You didn’t choose the military life so much as you were drafted into it.You have a non-military background and skill set.Who knows what course your life might have taken had you not been forced to take up arms? You gain access to the Worldly social trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(11, 20),
                    Name = nameof(FighterBackgroundEnum.Conscripted),
                    ProperName = "Conscripted",
                    Description =
                        "You didn’t choose the military life so " +
                        "much as you were drafted into it. You have " +
                        "a non-military background and skill set. " +
                        "Who knows what course your life might have " +
                        "taken had you not been forced to take up " +
                        "arms? You gain access to the Worldly social trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.Worldly,
                    }
                },
                #endregion

                #region Duty
                //21–30	Duty You took up the sword because no one else would.When a great danger threatened your home, you stepped forth to meet the challenge, though you were only a youth with just the strength of your arm and steadfastness of your courage to see you through. You gain access to the Courageous combat trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(21, 30),
                    Name = nameof(FighterBackgroundEnum.Duty),
                    ProperName = "Duty",
                    Description =
                        "You took up the sword because no one " +
                        "else would.When a great danger threatened " +
                        "your home, you stepped forth to meet the " +
                        "challenge, though you were only a youth " +
                        "with just the strength of your arm and " +
                        "steadfastness of your courage to see you " +
                        "through. You gain access to the Courageous combat trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.Courageous,
                    }
                },
                #endregion

                #region Gladiator
                //31–40	Gladiator As an adolescent, you learned to fight and kill because your master made you, and if you had not learned, you would be dead. Killing was a way of life—a means of survival. At first you did it because you had to, but that soon changed when you heard the chorus of the crowd. You gain access to the Killer combat trait, the Life of Toil social trait, and the Champion story feat.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(31, 40),
                    Name = nameof(FighterBackgroundEnum.Gladiator),
                    ProperName = "Gladiator",
                    Description =
                        "As an adolescent, you learned to fight " +
                        "and kill because your master made you, " +
                        "and if you had not learned, you would be " +
                        "dead. Killing was a way of life—a means " +
                        "of survival. At first you did it because " +
                        "you had to, but that soon changed when " +
                        "you heard the chorus of the crowd. You " +
                        "gain access to the Killer combat trait, " +
                        "the Life of Toil social trait, and the " +
                        "Champion story feat.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.Killer,
                        TraitEnum.LifeofToil,
                        TraitEnum.Champion,
                    }
                },
                #endregion

                #region Joined the Watch
                //41–50	Joined the Watch Your village, town, city, or tribe needed new recruits for the volunteer watch patrol, and you joined up—whether for money, duty, peace, or power.This rudimentary training gave you an understanding of civilized justice and showed you how to wield a weapon with skill.You gain access to the Militia Veteran regional trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(41, 50),
                    Name = nameof(FighterBackgroundEnum.JoinedTheWatch),
                    ProperName = "Joined the Watch",
                    Description =
                        "Your village, town, city, or tribe needed " +
                        "new recruits for the volunteer watch patrol, " +
                        "and you joined up—whether for money, duty, " +
                        "peace, or power. This rudimentary training " +
                        "gave you an understanding of civilized " +
                        "justice and showed you how to wield a weapon " +
                        "with skill. You gain access to the " +
                        "Militia Veteran regional trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.MilitiaVeteran,
                    }
                },
                #endregion

                #region Knighted
                //51–60	Knighted Your military path began when you were knighted or made a squire to a knight. Your family’s status could have influenced this event, or you might be a simple commoner rewarded with a title for a rare feat of courage.As a member of the nobility, you gain access to the Influence social trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(51, 60),
                    Name = nameof(FighterBackgroundEnum.Knighted),
                    ProperName = "Knighted",
                    Description =
                        "Your military path began when you were " +
                        "knighted or made a squire to a knight. " +
                        "Your family’s status could have influenced " +
                        "this event, or you might be a simple " +
                        "commoner rewarded with a title for a rare " +
                        "feat of courage. As a member of the " +
                        "nobility, you gain access to the Influence social trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.Influence,
                    }
                },
                #endregion

                #region Mercenary
                //61–70	Mercenary Everyone needs to earn a living, and in your youth you were fast, strong, or tough enough to fight for pay.There are good causes and bad causes, but at the end of the day, it all comes down to money. Sometimes you got easy jobs, like guarding merchant caravans; other times the jobs are rough, like fighting in a rebel lord’s private army.You gain access to the Mercenary social trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(61, 70),
                    Name = nameof(FighterBackgroundEnum.Mercenary),
                    ProperName = "Mercenary",
                    Description =
                        "Everyone needs to earn a living, and in " +
                        "your youth you were fast, strong, or " +
                        "tough enough to fight for pay. There " +
                        "are good causes and bad causes, but at " +
                        "the end of the day, it all comes down " +
                        "to money. Sometimes you got easy jobs, " +
                        "like guarding merchant caravans; other " +
                        "times the jobs are rough, like fighting " +
                        "in a rebel lord’s private army. You gain " +
                        "access to the Mercenary social trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.Mercenary,
                    }
                },
                #endregion

                #region On the Street
                //71–80	On the Street You spent adolescence in a seedy part of town.You learned to fight dirty and fight mean. Turns out you were good at it.Your skills drew the interest of gang and guild leaders, tavern keepers, and anyone else who needed hired muscle. You gain access to the Child of the Streets social trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(71, 80),
                    Name = nameof(FighterBackgroundEnum.OnTheStreet),
                    ProperName = "On the Street",
                    Description =
                        "You spent adolescence in a seedy part " +
                        "of town. You learned to fight dirty and " +
                        "fight mean. Turns out you were good " +
                        "at it. Your skills drew the interest " +
                        "of gang and guild leaders, tavern " +
                        "keepers, and anyone else who needed " +
                        "hired muscle. You gain access to the " +
                        "Child of the Streets social trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.ChildoftheStreets,
                    }
                },
                #endregion

                #region Schooled
                //81–90	Schooled You learned to fight in a structured environment where you were exposed to a variety of weapons, armor, strategies, and tactics. You learned to fight as part of a unit, how to follow orders and how to command a squad. You gain access to the Tactician combat trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(81, 90),
                    Name = nameof(FighterBackgroundEnum.Schooled),
                    ProperName = "Schooled",
                    Description =
                        "You learned to fight in a structured " +
                        "environment where you were exposed to a " +
                        "variety of weapons, armor, strategies, " +
                        "and tactics. You learned to fight as " +
                        "part of a unit, how to follow orders " +
                        "and how to command a squad. You gain " +
                        "access to the Tactician combat trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.Tactician,
                    }
                },
                #endregion

                #region Survival
                //91–100	Survival You spent some part of your life in the wild—in places that abide by the laws of nature rather than those of civilization.You survived by being stronger, faster, and more cunning than the predators. That meant you fought not for coin, honor, or principle, but for your very life.You gain access to the Resilient combat trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(91, 190),
                    Name = nameof(FighterBackgroundEnum.Survival),
                    ProperName = "Survival",
                    Description =
                        "You spent some part of your life in the " +
                        "wild—in places that abide by the laws of " +
                        "nature rather than those of civilization. " +
                        "You survived by being stronger, faster, " + 
                        "and more cunning than the predators. That " +
                        "meant you fought not for coin, honor, or " +
                        "principle, but for your very life. You " +
                        "gain access to the Resilient combat trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.Resilient,
                    }
                },
                #endregion
            };
        }
    }

}
