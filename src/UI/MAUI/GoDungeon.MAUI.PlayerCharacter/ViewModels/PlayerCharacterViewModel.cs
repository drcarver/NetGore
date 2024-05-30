using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GoDungeon.Character.PC.Barbarian;
using GoDungeon.Character.PC.Bard;
using GoDungeon.Character.PC.Cleric;
using GoDungeon.Character.PC.Druid;
using GoDungeon.Core;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.MAUI.PlayerCharacter.ViewModels;

public partial class PlayerCharacterViewModel : ObservableObject
{
    private ILogger<PlayerCharacterViewModel> logger;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(SelectedClass))]
    public bool initializing;

    private IServiceProvider Services { get; }

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

        Race.SetAlignment(AlignmentFilterEnum.NonEvil);
        Race.SetShortDescription();

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

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="services"></param>
    /// <param name="loggerFactory"></param>
    /// <param name="alignmentTable"></param>
    public PlayerCharacterViewModel(
            IServiceProvider services,
            ILoggerFactory loggerFactory,
            IAlignmentTable alignmentTable
            )
    {
        logger = loggerFactory.CreateLogger<PlayerCharacterViewModel>();
        Services = services;

        // Initialize the alignment table
        AlignmentTable = alignmentTable;
        AlignmentTable.InitializeTable();

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
