using System.Collections.ObjectModel;

using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GoDungeon.Character.PC.Barbarian;
using GoDungeon.Character.PC.Bard;
using GoDungeon.Character.PC.Cleric;
using GoDungeon.Character.PC.Druid;
using GoDungeon.Core;
using GoDungeon.Core.Abilities;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.ViewModels;
using GoDungeon.RandomDungeon.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.MAUI.PlayerCharacter.ViewModels;

public partial class PlayerCharacterViewModel : ObservableObject
{
    private ILogger<PlayerCharacterViewModel> logger;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(SelectedClass))]
    public bool initializing;

    private IServiceProvider Services { get; }
    private INPCHighAbilitiesTable NPCHighAbilitiesTable { get; }
    private INPCLowAbilitiesTable NPCLowAbilitiesTable { get; }

    #region Alignment Table
    [ObservableProperty]
    private AlignmentTableEntryViewModel selectedAlignment;

    [ObservableProperty]
    private IAlignmentTable alignmentTable;

    /// <summary>
    /// The race selection has changed
    /// </summary>
    [RelayCommand]
    private void AlignmentSelectionChanged()
    {
        if (Race != null)
        {
            Race.Alignment = SelectedAlignment.Alignment;
        }
    }
    #endregion

    #region Race List
    [ObservableProperty]
    private ObservableCollection<RaceEnum> validRaceList = [];
    [ObservableProperty]
    private RaceEnum selectedRace;

    [ObservableProperty]
    private CharacterRaceViewModel race;

    /// <summary>
    /// The race selection has changed
    /// </summary>
    [RelayCommand]
    private void RaceSelectionChanged()
    {
        if (!Initializing) 
        {
            Initialize(SelectedRace);
        }
    }
    #endregion

    #region Character Class
    [ObservableProperty]
    private ClassEnum selectedClass;

    private ObservableCollection<ICharacterClass> fullClassList;

    /// <summary>
    /// The race selection has changed
    /// </summary>
    [RelayCommand]
    private void ClassSelectionChanged()
    {
        var fc = fullClassList.First(cl => cl.ClassEnum == SelectedClass);
        if (fc.Level == 0)
        {
            fc?.LevelUp(Race);
        }
    }

    /// <summary>
    /// The valid classes for the character to select
    /// </summary>
    [ObservableProperty]
    public ObservableCollection<ClassEnum> validClassList = [];
    #endregion

    /// <summary>
    /// Navigate to the selected url
    /// </summary>
    /// <param name="uri">THe requested url</param>
    /// <returns>The Task from the await</returns>
    [RelayCommand]
    private async Task DisplayWebPage(string url)
    {
        await Launcher.OpenAsync(url);
    }

    /// <summary>
    /// Re-roll the character
    /// </summary>
    [RelayCommand]
    private void ReRoll()
    {
        Initialize();
    }

    /// <summary>
    /// Initialize a new character race and class
    /// </summary>
    /// <param name="raceEnum"></param>
    private void Initialize(RaceEnum raceEnum = RaceEnum.Any)
    {
        Initializing = true;

        #region First get a random character race from the humanoid race factory 
        var dice = new Dice("1D10").Total;
        if (dice == 10)
        {
            dice = (int)RaceEnum.Human;
        }

        IHumanoidRaceFactory raceFactory = Services.GetService<IHumanoidRaceFactory>();
        if (raceEnum != RaceEnum.Any)
        {
            Race = (CharacterRaceViewModel)raceFactory.Create(raceEnum);
        }
        else
        {
            Race = (CharacterRaceViewModel)raceFactory.Create((RaceEnum)dice);
            SelectedRace = (RaceEnum)dice;
        }
        #endregion

        #region Now the character alignment
        AlignmentTableEntryViewModel alignEntry = (AlignmentTableEntryViewModel)AlignmentTable?.GetRandomEntry();
        Race.Alignment = alignEntry.Alignment;
        SelectedAlignment = alignEntry;
        #endregion

        SetShortDescription();

        // Get the classes that prerequisites are equal or better to
        // the character abilities.
        ValidClassList.Clear();
        foreach (var characterClass in fullClassList)
        {
            if (characterClass.HasPrerequisites(Race))
            {
                ValidClassList.Add(characterClass.ClassEnum);
            }
        }

        // Set the class selected to a random value
        var classIndex = new Dice($"1d{ValidClassList.Count}").Total - 1;
        if (classIndex < 0 || classIndex > ValidClassList.Count - 1)
        {
            classIndex = 0;
        }
        // If no valid classes try a new roll
        if (!ValidClassList.Any())
        {
            Initializing = false;
            Initialize();
        }
        SelectedClass = ValidClassList[classIndex];

        // if required, LevelUp the class for the first time
        var fc = fullClassList.First(cl => cl.ClassEnum == SelectedClass);
        if (fc.Level == 0)
        {
            fc?.LevelUp(Race);
        }

        Initializing = false;
    }

    private void SetShortDescription()
    {
        Race.ShortDescription = string.Empty;
        string highAbilities = string.Empty;
        string lowAbilities = string.Empty;
        foreach (var enumMember in Enum.GetValues(typeof(AbilityEnum)))
        {
            // Ability
            var highEntry = (IRandomTableEntry)NPCHighAbilitiesTable.GetEntryByName(enumMember.ToString());
            var lowEntry = (IRandomTableEntry)NPCLowAbilitiesTable.GetEntryByName(enumMember.ToString());
            int score = 0;
            switch (enumMember)
            {
                case AbilityEnum.Strength:
                    score = Race.Strength.Score;
                    break;
                case AbilityEnum.Intelligence:
                    score = Race.Intelligence.Score;
                    break;
                case AbilityEnum.Dexterity:
                    score = Race.Dexterity.Score;
                    break;
                case AbilityEnum.Constitution:
                    score = Race.Constitution.Score;
                    break;
                case AbilityEnum.Wisdom:
                    score = Race.Wisdom.Score;
                    break;
                case AbilityEnum.Charisma:
                    score = Race.Charisma.Score;
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
            Race.ShortDescription = string.Empty;
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
                Race.ShortDescription = lowAbilities;
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
                if (Race.ShortDescription.Length > 0)
                {
                    Race.ShortDescription += " while also being " + highAbilities;
                }
                else
                {
                    Race.ShortDescription = highAbilities;
                }
            }
            if (Race.ShortDescription.Length >= 0)
            {
                Race.ShortDescription = Race.ShortDescription + ".";
            }
            else
            {
                Race.ShortDescription = "completely average looking.";
            }
        }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="services"></param>
    /// <param name="loggerFactory"></param>
    /// <param name="alignmentTable"></param>
    /// <param name="npcHighAbilitiesTable"></param>
    /// <param name="npcLowAbilitiesTable"></param>
    public PlayerCharacterViewModel(
            IServiceProvider services,
            ILoggerFactory loggerFactory,
            IAlignmentTable alignmentTable,
            INPCHighAbilitiesTable npcHighAbilitiesTable,
            INPCLowAbilitiesTable npcLowAbilitiesTable
            )
    {
        logger = loggerFactory.CreateLogger<PlayerCharacterViewModel>();
        Services = services;

        // Initialize the alignment table
        AlignmentTable = alignmentTable;
        AlignmentTable.InitializeTable();

       NPCHighAbilitiesTable = npcHighAbilitiesTable;
       NPCHighAbilitiesTable.InitializeTable();

       NPCLowAbilitiesTable = npcLowAbilitiesTable;
       NPCLowAbilitiesTable.InitializeTable();

        // The list of races
        for (int i = 1; i < 10; i++)
        {
            ValidRaceList.Add((RaceEnum)i);
        }

        // The full class list
        fullClassList = new ObservableCollection<ICharacterClass>();
        fullClassList.Add(services.GetService<IBarbarian>());
        fullClassList.Add(services.GetService<IBard>());
        fullClassList.Add(services.GetService<ICleric>());
        fullClassList.Add(services.GetService<IDruid>());
        Initialize();
    }
}
