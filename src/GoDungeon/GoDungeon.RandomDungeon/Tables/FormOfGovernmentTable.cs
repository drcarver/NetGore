using System;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Enum;
using GoDungeon.RandomDungeon.Interfaces;

namespace GoDungeon.RandomDungeon.Tables
{
    /// <summary>
    /// In the feudal society common in most D&D worlds, power and authority
    /// are concentrated in towns and cities.Nobles hold authority over the
    /// where they live and the surrounding lands. They collect taxes from
    /// the populace, which they use for public building projects, to pay
    /// the soldiery, and to support a comfortable lifestyle for themselves
    /// (although nobles often have considerable hereditary wealth). In exchange,
    /// they promise to protect their citizens from threats such as ore marauders,
    /// hobgoblin armies, and roving human bandits. 
    ///  <para>
    /// Nobles appoint officers as their agents in villages, to supervise the
    /// collection of taxes and serve as judges in disputes and criminal trials.
    /// These reeves, sheriffs, or bailiffs are commoners native to the villages
    /// they govern, chosen for their positions because they already hold the
    /// respect of their fellow citizens.
    ///  </para>
    ///  <para>
    /// Within towns and cities, lords share authority and administrative
    /// responsibility with lesser nobles (usually their own relatives), and
    /// also with representatives of the middle class, such as traders and
    /// artisans. A lord mayor of noble birth is appointed to head the town
    /// or city council and to perform the same administrative functions that
    /// reeves carry out in villages. The council consists of representatives
    /// elected by the middle class. Only foolish nobles ignore the wishes of
    /// their councils, since the economic power of the middle class is often
    /// more important to the prosperity of a town or city than the hereditary
    /// authority of the nobility.  The larger a settlement, the more likely
    /// that other individuals or organizations hold significant power there
    /// as well.Even in a village, a popular individual-a wise elder or a
    /// well-liked farmer-can wield more influence than the appointed reeve,
    /// and a wise reeve avoids making an enemy of such a person. In towns
    /// and cities, the same power might lie in the hands of a prominent temple,
    /// a guild independent of the council, or an individual with magical power.
    /// </para>
    /// </summary>
    public class FormOfGovernmentTable : RandomTable, IFormOfGovernmentTable
    {
        /// <summary>
        /// A settlement rarely stands alone. A given town or city might be a theocratic
        /// city-state or a prosperous free city governed by a merchant council. More
        /// likely, it's part of a feudal kingdom, a bureaucratic empire, or a remote
        /// realm ruled by an iron-fisted tyrant. Consider how your settlement fits
        /// into the bigger picture of your world or region-who rules its ruler,
        /// and what other settlements might also lie under its control.
        /// </summary>
        public FormOfGovernmentTable()
        {
            Name = nameof(FormOfGovernmentTable);
            ProperName = "Form Of Government Table";
            TableType = TableTypeEnum.RandomDungeonTable;
            DiceSides = 100;
            Description =
                "A settlement rarely stands alone. A given town or city might be a theocratic city-state or a prosperous free city governed by a merchant council. More likely, it's part of a feudal kingdom, a bureaucratic empire, or a remote realm ruled by an iron-fisted tyrant. Consider how your settlement fits into the bigger picture of your world or region-who rules its ruler, and what other settlements might also lie under its control.";
        }

        //FORMS OF GOVERNMENT
        //d1OO Government
        //01-08  Autocracy       
        //09-13  Bureaucracy      
        //14-19  Confederacy      
        //20-22  Democracy      
        //23-27  Dictatorship      
        //28-42  Feudalism      
        //43-44  Gerontocracy     
        //45-53  Hierarchy       
        //54-56  Magocracy       
        //57-58  Matriarchy      
        //59-64  Militocracy
        //65-74  Monarchy
        //75-78  Oligarchy
        //79-80  Patriarchy
        //81-83  Meritocracy
        //84-85  Plutocracy
        //86-92  Republic
        //93-94  Satrapy
        //95  Kleptocracy
        //96-00  Theocracy
        /// <summary>
        /// Initialize the game table.  This is a separate method so we 
        /// can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region 01-08  Autocracy 
                    //01-08  Autocracy 
                    new RandomTableEntryViewModel
                    {
                        Range = new Range(01, 08),
                        Name = nameof(FormOfGovernmentEnum.Autocracy),
                        ProperName = nameof(FormOfGovernmentEnum.Autocracy),
                        Description = "One hereditary ruler wields absolute power. The autocrat either is supported by a well­ developed bureaucracy or military or stands as the only authority in an otherwise anarchic society. The dynastic ruler could be immortal or undead."
                    },
                    #endregion
                };
            }
        }
    }


    //Autocracy.One hereditary ruler wields absolute power. The autocrat either is supported by a well­
    //developed bureaucracy or military or stands as the only authority in an otherwise anarchic society. 
    //The dynastic ruler could be immortal or undead. Aundair and Karrnath, two kingdoms in the Eberron
    //campaign setting. have autocrats with royal blood in their veins. Whereas Queen Aurala of Aundair
    //relies on wizards and spies to enforce her will, Kaius, the vampire king of Karrnath, has a
    //formidable army of living and undead soldiers under his command.
    //Bureaucracy.Various departments compose the government, each responsible for an aspect of rule. 
    //The department heads, ministers, or secretaries answer to a figurehead autocrat or council.
    //Confederacy.Each individual city or town within the confederacy governs itself, but all contribute
    //to a league or federation that promotes (at least in theory)
    //the common good of all member states.Conditions and attitudes toward the central government vary
    //from place to place within the confederacy.The Lords' Alliance in the Forgotten Realms setting is 
    //a loose confederacy of cities, while the Mror Holds in the Eberron campaign setting is a
    //confederacy of allied dwarf clans.
    //Democracy.Citizens or their elected representatives determine the laws in a democracy. A
    //bureaucracy or military carries out the day-to-day work of government, with positions filled
    //through open elections.
    //Dictatorship.One supreme ruler holds absolute authority, but his or her rule isn't necessarily 
    //dynastic.In other respects this resembles an autocracy.In the Greyhawk campaign setting, a
    //half-demon named luz is the dictator of a conquered land that bears his name.
    //Feudalism.The typical government of Europe in
    //the Middle Ages, a feudalistic society consists of layers of lords and vassals. The vassals provide
    //soldiers or scutage (payment in lieu of military service) to the lords, who in turn promise
    //protection to their vassals.
    //Gerontocracy.Elders preside over this society.In some cases, long-lived races such as elves or
    //dragons are entrusted with the leadership of the land.
    //Hiera_rchy.A feudal or bureaucratic government where every member, except one, is subordinate to
    //another member. In the Dragonlance campaign setting, the dragonarmies of Krynn form a military
    //hierarchy, with the Dragon Highlords as leaders under the dragon queen Takbisis.
    //Kleptocracy.This government is composed of groups or individuals primarily seeking wealth for 
    //themselves, often at the expense of their subjects.The grasping Bandit Kingdoms in the Greyhawk
    //campaign setting are prime examples.A kingdom run by thieves' guilds would also fall into this 
    //category.
    //Magocracy.The governing body is composed of spellcasters who rule directly as oligarchs or feudal
    //lords, or participate in a democracy or bureaucracy. Examples include the Red Wizards of Thay in
    //the Forgotten Realms campaign setting and the sorcerer­ kings of Athas in the Dark Sun campaign
    //setting.
    //Matriarchy or Patriarchy.This society is governed by the eldest or most important members of one
    //gender.Drow cities are examples of theocratic matriarchies, for
    //CHAPTER I / A WORLD OF YOUR OWN
    //18

    //each is ruled by a council of drow high priestesses who answer to Lolth, the Demon Queen of
    //Spiders.
    //Meritocracy.The most intelligent and educated people oversee the society, often with a bureaucracy
    //co handle the day-to-day work of government. In the Forgotten Realms, scholarly monks preside over
    //the
    //fortress-library of Candlekeep, overseen by a master of lore called the Keeper.
    //Militocracy.Military leaders run the nation under martial law, us.ing the army and other armed
    //forces.A militocracy might be based on an elite group of soldiers, an order of dragon riders, or a
    //league of sea princes.
    //Solamnia, a nation ruled by knights in the Dragonlance campaign setting, falls into this category.
    //Monarchy.Asingle hereditary sovereign wears the crown. Unlike the autocrat, the monarch's powers 
    //are limited by law, and the ruler serves as the head of a democracy, feudal state, or militocracy. 
    //The kingdom of Breland, in the Eberron campaign setting, has both a parliament that makes laws and
    //a monarch who enforces them.
    //Oligarchy.A small number of absolute rulers share power, possibly dividing the land into districts
    //or provinces under their control, or jointly ruling together. Agroup of adventurers who take
    //control of a nation together might form an oligarchy. The Free City of Greyhawk is an oligarchy
    //composed of various faction leaders, with a Lord Mayor as its figurehead.
    //Plutocracy.Society is governed by the wealthy. The elite form a ruling council, purchase
    //representation at the court of a figurehead monarch, or rule by default because money is the true 
    //power in the realm. Many cities in the Forgotten Realms campaign setting, including Waterdeep and
    //Baldur's Gate, are plutocracies.
    //Republic.Government is entrusted to representatives of an established electorate who rule on
    //behalf of the electors. Any democracy in which only landowners or certain classes can vote could be
    //considered a republic.
    //Satrapy.Conquerors and representatives of another government wield power, ruling the settlement or
    //region as part of a larger empire.The satraps are bureaucrats and military officers, or unusual
    //characters or monsters.The cities of Highport and Suderham in the Greyhawk campaign setting are
    //satrapies controlled by agents of a
    //\icious gang of marauders known as the Slave Lords.
    //Theocracy.Rulership falls to a direct representative or a collection of agents of a deity. The
    //centers of power in a theocracy are usually located on sacred sites. In the Eberron campaign
    //setting, the nation ofThrane is a theocracy devoted to the Silver Flame, a divine spirit that
    //resides in Thrane's capital ofFlamekeep.

    //SAMPLE HIERARCHY OF NOBLE TITLES
    //Rank Title Rank Title
    //1st Emperor/Empress    7th Viscount/ 2nd King/Queen Viscountess
    //3rd Duke/Duchess      8th Baron/Baroness
    //4th Prince/Princess     9th Baronet 5th Marquess/Marquise   
    //    10th Knight 
    //6th Earl or
    //Countess
}
