using System.Buffers.Text;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using static System.Collections.Specialized.BitVector32;

namespace GoDungeon.Core.Tables
{
    public class LanguageTable : NamedTable, ILanguageTable
    {
        /// <summary>
        /// The Language Table
        /// </summary>
        public LanguageTable()
        {
            Name = nameof(LanguageTable);
            ProperName = "Language Table";
            Description = "Your race indicates the " +
                "languages your character can  speak by " +
                "default, and your background might give " +
                "you access to one or more additional " +
                "languages of  your choice.";
            TableType = TableTypeEnum.CharacterTable;
        }

        /// <summary>
        /// Initialize the game table.  This is a separate method 
        /// so we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region boleth
                    //boleth
                    //Spoken By: Aboleth and other deep sea (aquatic) aberrations.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.boleth),
                        ProperName = nameof(LanguageEnum.boleth),
                        Description = "Spoken By: Aboleth and other deep sea (aquatic) aberrations."
                    },
                    #endregion

                    #region Abyssal
                    //Abyssal
                    //Spoken By: Demons and other chaotic evil outsiders
                    //The language of demons, Abyssal is often spoken by evil spirits.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Abyssal),
                        ProperName = nameof(LanguageEnum.Abyssal),
                        Description = "Spoken By: Demons and other chaotic evil outsiders. The language of demons, Abyssal is often spoken by evil spirits."
                    },
                    #endregion

                    #region Aklo
                    //Aklo
                    //Spoken By: Derro, inhuman or otherworldly monsters, evil fey.
                    //This ancient tongue is spoken by strange eldritch entities, and certain ancient beings.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Aklo),
                        ProperName = nameof(LanguageEnum.Aklo),
                        Description = "Spoken By: Derro, inhuman or otherworldly monsters, evil fey. This ancient tongue is spoken by strange eldritch entities, and certain ancient beings."
                    },
                    #endregion

                    #region Aquan
                    //Aquan (“Tongue of the Sea”)
                    //Spoken By: Aquatic and water-based creatures
                    //The so-called “tongue of the sea” is spoken primarily in the sunken nation of the locathahs— those who trade frequently with the ocean empires often speak this tongue as well.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Aquan),
                        ProperName = "Aquan (“Tongue of the Sea”)",
                        Description = "Spoken By: Aquatic and water-based creatures. The so-called “tongue of the sea” is spoken primarily in the sunken nation of the locathahs— those who trade frequently with the ocean empires often speak this tongue as well."
                    },
                    #endregion

                    #region Auran
                    //Auran (“Tongue of the Heavens”)
                    //Spoken By: Flying creatures, air-based creatures
                    //A soft-spoken, breathy language, also known as the “tongue of the heavens.”
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Auran),
                        ProperName = "Auran (“Tongue of the Heavens”)",
                        Description = "Spoken By: Flying creatures, air-based creatures. A soft-spoken, breathy language, also known as the “tongue of the heavens.”"
                    },
                    #endregion

                    #region Boggard
                    //Boggard
                    //Spoken By: Boggard.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Boggard),
                        ProperName = "Boggard",
                        Description = "Spoken By: Boggard."
                    },
                    #endregion

                    #region Celestial
                    //Celestial
                    //Spoken By: Angels and other good outsiders.
                    //The language of angels.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Celestial),
                        ProperName = "Celestial",
                        Description = "Spoken By: Angels and other good outsiders. The language of angels."
                    },
                    #endregion

                    #region Common
                    //Common
                    //Spoken By: humans and the other core races
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Common),
                        ProperName = "Common",
                        Description = "Common. Spoken By: humans and the other core races"
                    },
                    #endregion

                    #region Cyclops
                    //Cyclops
                    //Spoken By: Cyclops and their kin.
                    //Once the ancient language of the giants, this tongue was created before the rise of humanity by the cyclopes.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Cyclops),
                        ProperName = "Cyclops",
                        Description = "Spoken By: Cyclops and their kin. Once the ancient language of the giants, this tongue was created before the rise of humanity by the cyclopes."
                    },
                    #endregion

                    #region Dark Folk
                    //Dark Folk
                    //Spoken By: Dark creepers, dark slayers, and dark stalkers (creatures of the Dark Folk subtype.)
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.DarkFolk),
                        ProperName = "Dark Folk",
                        Description = "Spoken By: Dark creepers, dark slayers, and dark stalkers (creatures of the Dark Folk subtype.)"
                    },
                    #endregion

                    #region Draconic
                    //Draconic
                    //Spoken By: dragons, reptilian humanoids
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Draconic),
                        ProperName = "Draconic",
                        Description = "Spoken By: dragons, reptilian humanoids"
                    },
                    #endregion

                    #region Drow Sign Language
                    //Drow Sign Language
                    //Used By: Drow.
                    //Like Druidic, drow sign language is a “secret” language.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.DrowSignLanguage),
                        ProperName = "Drow Sign Language",
                        Description = "Used By: Drow. Like Druidic, drow sign language is a “secret” language."
                    },
                    #endregion

                    #region Druidic
                    //Druidic
                    //Spoken By: Druids(only)
                    //Druidic is a secret language known only to druids. It is a free language for a druid; that is, it doesn’t take up a language slot. Druids are forbidden to teach this language to nondruids and has its own alphabet.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Druidic),
                        ProperName = "Druidic",
                        Description = "Spoken By: Druids(only). Druidic is a secret language known only to druids. It is a free language for a druid; that is, it doesn’t take up a language slot. Druids are forbidden to teach this language to nondruids and has its own alphabet."
                    },
                    #endregion

                    #region Dwarven
                    //Dwarven
                    //Spoken By: Dwarves.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Dwarven),
                        ProperName = "Dwarven",
                        Description = "Spoken By: Dwarves."
                    },
                    #endregion

                    #region D’ziriak
                    //D’ziriak
                    //Spoken By: D’ziriak.
                    //The insectoid d’ziriak language consists of buzzes and chitters. It is an obscure one known by few outside their race.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Dziriak),
                        ProperName = "D’ziriak",
                        Description = "Spoken By: D’ziriak. The insectoid d’ziriak language consists of buzzes and chitters. It is an obscure one known by few outside their race."
                    },
                    #endregion

                    #region Elven
                    //Elven
                    //Spoken By: Elves, half-elves
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Elven),
                        ProperName = "Elven",
                        Description = "Spoken By: Elves, half-elves"
                    },
                    #endregion

                    #region Giant
                    //Giant
                    //Spoken By: Cyclops, ettins, giants, ogres, trolls
                    //This brutish tongue and its numerous minor variants are spoken in any region where the wrath of giants is known.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Giant),
                        ProperName = "Giant",
                        Description = "Spoken By: Cyclops, ettins, giants, ogres, trolls. This brutish tongue and its numerous minor variants are spoken in any region where the wrath of giants is known."
                    },
                    #endregion

                    #region Gnoll
                    //Gnoll
                    //Spoken By: Gnolls
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Gnoll),
                        ProperName = "Gnoll",
                        Description = "Spoken By: Gnolls"
                    },
                    #endregion

                    #region Gnome
                    //Gnome
                    //Spoken By: Gnomes
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Gnome),
                        ProperName = "Gnome",
                        Description = "Spoken By: Gnomes"
                    },
                    #endregion

                    #region Goblin
                    //Goblin
                    //Spoken By: Bugbears, goblins, hobgoblins
                    //The official language of hobgoblins, this dialect is similar to the goblin tongue.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Goblin),
                        ProperName = "Goblin",
                        Description = "Spoken By: Bugbears, goblins, hobgoblins. The official language of hobgoblins, this dialect is similar to the goblin tongue."
                    },
                    #endregion

                    #region Grippli
                    //Grippli
                    //Spoken By: Grippli.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Grippli),
                        ProperName = "Grippli",
                        Description = "Spoken By: Grippli."
                    },
                    #endregion

                    #region Halfling
                    //Halfling
                    //Spoken By: Halflings
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Halfling),
                        ProperName = "Halfling",
                        Description = "Spoken By: Halflings."
                    },
                    #endregion

                    #region Ignan
                    //Ignan(“Tongue of Fire”)
                    //Spoken By: Fire - based creatures
                    //Also called the “tongue of fire.”
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Ignan),
                        ProperName = "Ignan (“Tongue of Fire”)",
                        Description = "Spoken By: Fire - based creatures. Also called the “tongue of fire.”"
                    },
                    #endregion

                    #region Infernal
                    //Infernal
                    //Spoken By: Devils and other lawful evil outsiders
                    //The language of devils is often spoken by evil spirits.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Infernal),
                        ProperName = "Infernal",
                        Description = "Spoken By: Devils and other lawful evil outsiders. The language of devils is often spoken by evil spirits."
                    },
                    #endregion

                    #region Necril
                    //Necril
                    //Spoken By: undead
                    //An ancient language of the dead, this whispering tongue is shared among undead and is also often associated with necromancy.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Necril),
                        ProperName = "Necril",
                        Description = "Spoken By: undead. An ancient language of the dead, this whispering tongue is shared among undead and is also often associated with necromancy."
                    },
                    #endregion

                    #region Orc
                    //Orc
                    //Spoken By: Orcs, half-orcs
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Orc),
                        ProperName = "Orc",
                        Description = "Spoken By: Orcs, half-orcs"
                    },
                    #endregion

                    #region Protean
                    //Protean
                    //Spoken By: Proteans.
                    //Like the proteans chaotic nature, the protean language itself is mutable, evolving so quickly that few outsiders can understand it without magical aid.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Protean),
                        ProperName = "Protean",
                        Description = "Spoken By: Proteans. Like the proteans chaotic nature, the protean language itself is mutable, evolving so quickly that few outsiders can understand it without magical aid."
                    },
                    #endregion

                    #region Rougarou
                    //Rougarou
                    //Spoken By: Rougarou.
                    //Rougarou speak their own tongue.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Rougarou),
                        ProperName = "Rougarou",
                        Description = "Spoken By: Rougarou. Rougarou speak their own tongue."
                    },
                    #endregion

                    #region Sphinx
                    //Sphinx
                    //Spoken By: Sphinxes.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Sphinx),
                        ProperName = "Sphinx",
                        Description = "Spoken By: Sphinxes."
                    },
                    #endregion

                    #region Sylvan
                    //Sylvan
                    //Spoken By: Centaurs, fey creatures, plant creatures, unicorns.
                    //The language of the fey.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Sylvan),
                        ProperName = "Sylvan",
                        Description = "Spoken By: Centaurs, fey creatures, plant creatures, unicorns. The language of the fey."
                    },
                    #endregion

                    #region Tengu
                    //Tengu
                    //Spoken By: Tengu
                    //The official language of the tengu race.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Tengu),
                        ProperName = "Tengu",
                        Description = "Spoken By: Tengu. The official language of the tengu race."
                    },
                    #endregion

                    #region Terran
                    //Terran (“Tongue of Earth”)
                    //Spoken By: Earth - based creatures.
                    //Also called the “tongue of earth.”
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Terran),
                        ProperName = "Terran (“Tongue of Earth”)",
                        Description = "Spoken By: Earth - based creatures. Also called the “tongue of earth.”"
                    },
                    #endregion

                    #region Treant
                    //Treant
                    //Spoken By: Treants.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Treant),
                        ProperName = "Treant",
                        Description = "Spoken By: Treants."
                    },
                    #endregion

                    #region Undercommon
                    //Undercommon
                    //Spoken By: Drow, duergar, morlocks, svirfneblin.
                    //This language is derived from an ancient combination of Elven and even older tongues.
                    new StandardTableEntryViewModel
                    {
                        Name = nameof(LanguageEnum.Undercommon),
                        ProperName = "Undercommon",
                        Description = "Spoken By: Drow, duergar, morlocks, svirfneblin. This language is derived from an ancient combination of Elven and even older tongues."
                    },
                    #endregion
                };
            }
        }
    }
}
