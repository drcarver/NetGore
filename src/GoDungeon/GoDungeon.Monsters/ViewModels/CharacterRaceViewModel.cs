using System;
using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Background.Enum;
using GoDungeon.Background.Interfaces;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Monsters.ViewModels.Humanoid;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels
{
    public partial class CharacterRaceViewModel : HumanoidRaceViewModel, ICharacterRace
    {
        /// <summary>
        /// The level of the character
        /// </summary>
        [ObservableProperty]
        private int level;

        /// <summary>
        /// The creatures homeland
        /// </summary>
        [ObservableProperty]
        private IBackgroundTableEntry? homeland;

        /// <summary>
        /// The traits for this creature
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<TraitEnum> traits = new ObservableCollection<TraitEnum>();

        /// <summary>
        /// The creature's parents
        /// </summary>
        [ObservableProperty]
        private IBackgroundTableEntry? parents;

        /// <summary>
        /// The creature's circumstance of birth
        /// </summary>
        [ObservableProperty]
        private IBackgroundTableEntry? circumstanceOfBirth;

        /// <summary>
        /// THe creature's parents profession
        /// </summary>
        [ObservableProperty]
        private IBackgroundTableEntry? parentProfession;

        /// <summary>
        /// Adopted parents if needed
        /// </summary>
        [ObservableProperty]
        private IBackgroundTableEntry? adoptedParents;

        [ObservableProperty]
        private string? shortDescription;

        public IServiceProvider Services { get; }

        /// <summary>
        /// Set the short description
        /// </summary>
        public void SetShortDescription()
        {
            // NPC High Abilities Table
            INPCHighAbilitiesTable NPCHighAbilitiesTable =
                Services.GetRequiredService<INPCHighAbilitiesTable>();
            NPCHighAbilitiesTable.InitializeTable();

            // NPC Low Abilities Table
            INPCLowAbilitiesTable NPCLowAbilitiesTable =
                Services.GetRequiredService<INPCLowAbilitiesTable>();
            NPCLowAbilitiesTable.InitializeTable();

            ShortDescription = string.Empty;
            string highAbilities = string.Empty;
            string lowAbilities = string.Empty;
            foreach (var enumMember in System.Enum.GetValues(typeof(AbilityEnum)))
            {
                // Ability
                var highEntry = (IRandomTableEntry)NPCHighAbilitiesTable.GetEntryByName(enumMember.ToString());
                var lowEntry = (IRandomTableEntry)NPCLowAbilitiesTable.GetEntryByName(enumMember.ToString());
                int score = 0;
                switch (enumMember)
                {
                    case AbilityEnum.Strength:
                        score = Strength.Score;
                        break;
                    case AbilityEnum.Intelligence:
                        score = Intelligence.Score;
                        break;
                    case AbilityEnum.Dexterity:
                        score = Dexterity.Score;
                        break;
                    case AbilityEnum.Constitution:
                        score = Constitution.Score;
                        break;
                    case AbilityEnum.Wisdom:
                        score = Wisdom.Score;
                        break;
                    case AbilityEnum.Charisma:
                        score = Charisma.Score;
                        break;

                }
                if (score >= 14)
                {
                    if (highAbilities.Length > 0)
                    {
                        highAbilities += "," + highEntry.ProperName;
                    }
                    else
                    {
                        highAbilities += highEntry.ProperName;
                    }
                }
                else if (score <= 8)
                {
                    if (lowAbilities.Length > 0)
                    {
                        lowAbilities += "," + lowEntry.ProperName;
                    }
                    else
                    {
                        lowAbilities += lowEntry.ProperName;
                    }
                }
            }
            if (lowAbilities.Length >= 0 || highAbilities.Length >= 0)
            {
                ShortDescription = string.Empty;
                if (lowAbilities.Length > 0)
                {
                    if (lowAbilities.IndexOf(",") > -1)
                    {
                        var lowAbilitiesList = lowAbilities.Split(',');
                        lowAbilities = string.Empty;
                        for (int i = 0; i < lowAbilitiesList.Length - 1; i++)
                        {
                            lowAbilities += lowAbilitiesList[i] + ", ";
                        }
                        lowAbilities += " and " + lowAbilitiesList[lowAbilitiesList.Length - 1];
                        lowAbilities = lowAbilities.Replace(",  and ", " and ");
                    }
                    ShortDescription = lowAbilities;
                }
                if (highAbilities.Length > 0)
                {
                    if (highAbilities.IndexOf(",") > -1)
                    {
                        var highAbilitiesList = highAbilities.Split(',');
                        highAbilities = string.Empty;
                        for (int i = 0; i < highAbilitiesList.Length - 1; i++)
                        {
                            highAbilities += highAbilitiesList[i] + ", ";
                        }
                        highAbilities += " and " + highAbilitiesList[highAbilitiesList.Length - 1];
                        highAbilities = highAbilities.Replace(",  and ", " and ");
                    }
                    if (ShortDescription.Length > 0)
                    {
                        ShortDescription += " while also being " + highAbilities;
                    }
                    else
                    {
                        ShortDescription = highAbilities;
                    }
                }
                if (ShortDescription.Length >= 0)
                {
                    ShortDescription = ShortDescription + ".";
                }
                else
                {
                    ShortDescription = "completely average looking.";
                }
            }
        }

        /// <summary>
        /// Set the character background
        /// </summary>
        /// <param name="homelandTable"></param>
        /// <param name="unusualHomelandTable"></param>
        protected virtual void GetHomeland(
            IRandomTable homelandTable,
            IUnusualHomelandTable unusualHomelandTable)
        {
            homelandTable?.InitializeTable();
            Homeland = (IBackgroundTableEntry?)homelandTable?.GetRandomRangeEntry();
            if (Homeland?.Name == "UnusualHomeland")
            {
                unusualHomelandTable?.InitializeTable();
                Homeland = (IBackgroundTableEntry?)unusualHomelandTable?.GetRandomRangeEntry();
            }
            if (Homeland?.Traits != null)
            {
                foreach (var trait in Homeland.Traits)
                {
                    if (!Traits.Contains(trait))
                    {
                        Traits.Add(trait);
                    }
                }
            }
        }

        /// <summary>
        /// Get the parent info
        /// </summary>
        /// <param name="parentsTable">The parents table</param>
        protected virtual void GetParents(IRandomTable parentsTable)
        {
            parentsTable?.InitializeTable();
            Parents = (IBackgroundTableEntry?)parentsTable?.GetRandomRangeEntry();
            if (Parents?.Traits != null)
            {
                foreach (var trait in Parents.Traits)
                {
                    if (Traits.Contains(trait))
                    {
                        Traits.Add(trait);
                    }
                }
            }
        }

        /// <summary>
        /// Get circumstances of birth.  This will populate a
        /// number of properties based on the results.
        /// </summary>
        protected virtual void GetCircumstanceOfBirth()
        {
            // Circumstance of Birth Table
            ICircumstanceofBirthTable circumstanceofBirthTable =
                Services.GetRequiredService<ICircumstanceofBirthTable>();
            circumstanceofBirthTable.InitializeTable();

            // ProfessionTable
            IProfessionTable professionTable =
                Services.GetRequiredService<IProfessionTable>();
            professionTable.InitializeTable();

            // NobilityTable
            INobilityTable nobilityTable =
                Services.GetRequiredService<INobilityTable>();
            nobilityTable.InitializeTable();

            // NobilityTable
            IAdoptedOutsideYourRaceTable adoptedOutsideYourRaceTable =
                Services.GetRequiredService<IAdoptedOutsideYourRaceTable>();
            adoptedOutsideYourRaceTable.InitializeTable();

            // Get circumstance of birth
            CircumstanceOfBirth = (IBackgroundTableEntry?)circumstanceofBirthTable?.GetRandomRangeEntry();
            switch (CircumstanceOfBirth?.Name)
            {
                case nameof(CircumstanceofBirthEnum.LowerClassBirth):
                    ParentProfession = (IBackgroundTableEntry?)professionTable?.GetRandomRangeEntry(20);
                    break;
                case nameof(CircumstanceofBirthEnum.NobleBirth):
                    nobilityTable.InitializeTable();
                    ParentProfession = (IBackgroundTableEntry?)nobilityTable?.GetRandomRangeEntry();
                    break;
                case nameof(CircumstanceofBirthEnum.AdoptedOutsideYourRace):
                    adoptedOutsideYourRaceTable.InitializeTable();
                    AdoptedParents = (IBackgroundTableEntry?)adoptedOutsideYourRaceTable?.GetRandomRangeEntry();
                    break;
                default:
                    ParentProfession = (IBackgroundTableEntry?)professionTable?.GetRandomRangeEntry();
                    break;
            }

            // Copy over the traits
            if (CircumstanceOfBirth?.Traits != null)
            {
                foreach (var trait in CircumstanceOfBirth.Traits)
                {
                    if (Traits.Contains(trait))
                    {
                        Traits.Add(trait);
                    }
                }
            }
            if (ParentProfession?.Traits != null)
            {
                foreach (var trait in ParentProfession.Traits)
                {
                    if (Traits.Contains(trait))
                    {
                        Traits.Add(trait);
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="services"></param>
        protected CharacterRaceViewModel
        (
            ILoggerFactory logger,
            IServiceProvider services
        ) : base(services, logger)
        {
            Services = services;
        }
    }
}
