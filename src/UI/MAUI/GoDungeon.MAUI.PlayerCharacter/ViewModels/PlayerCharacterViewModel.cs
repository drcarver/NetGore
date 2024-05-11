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

    public bool Initializing { get; private set; }

    private IServiceProvider Services { get; }

    [ObservableProperty]
    private CharacterRaceViewModel race;

    #region Alignment Table
    [ObservableProperty]
    private ObservableCollection<string> alignmentList = [];
    [ObservableProperty]
    private string selectedAlignment;
    private IAlignmentTable AlignmentTable { get; }

    /// <summary>
    /// The race selection has changed
    /// </summary>
    [RelayCommand]
    private void AlignmentSelectionChanged()
    {
        if (Race != null)
        {
            Race.Alignment = ((AlignmentTableEntryViewModel)AlignmentTable.GetEntryByName(selectedAlignment)).Alignment;
        }
    }
    #endregion

    #region Race List
    [ObservableProperty]
    private ObservableCollection<RaceEnum> validRaceList = [];
    [ObservableProperty]
    private RaceEnum selectedRace;

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

    [ObservableProperty]
    private ClassEnum selectedClass;

    private ObservableCollection<ICharacterClass> fullClassList;

    /// <summary>
    /// The valid classes for the character to select
    /// </summary>
    [ObservableProperty]
    public ObservableCollection<ClassEnum> validClassList = [];

    [RelayCommand]
    private void Reroll()
    {
        Initialize();
    }

    private void Initialize(RaceEnum raceEnum = RaceEnum.Any)
    {
        Initializing = true;
        var dice = new Dice("1D10").Total;
        if (dice == 10)
        {
            dice = (int) RaceEnum.Human;
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

        ValidClassList.Clear();
        foreach (var characterClass in fullClassList)
        {
            if (characterClass.HasPrerequisites(Race))
            {
                ValidClassList.Add(characterClass.ClassEnum);
            }
        }
        SelectedClass = ValidClassList[new Dice($"1d{ValidClassList.Count}").Total-1];
        Initializing = false;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public PlayerCharacterViewModel(
        IServiceProvider services,
        ILoggerFactory loggerFactory,
        IAlignmentTable alignmentTable)
    {
        logger = loggerFactory.CreateLogger<PlayerCharacterViewModel>();
        Services = services;
        AlignmentTable = alignmentTable;
        alignmentTable?.InitializeTable();
        foreach (var alignment in alignmentTable.Table.Cast<AlignmentTableEntryViewModel>())
        {
            AlignmentList.Add(alignment.ProperName);
        }
        SelectedAlignment = ((AlignmentTableEntryViewModel) alignmentTable?.GetRandomEntry()).ProperName;

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
