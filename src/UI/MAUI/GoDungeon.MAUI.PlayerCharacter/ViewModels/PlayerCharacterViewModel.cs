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

using Microsoft.Extensions.Logging;

namespace GoDungeon.MAUI.PlayerCharacter.ViewModels;

public partial class PlayerCharacterViewModel : BaseObjectViewModel, ICharacterRace
{

    private ILogger<PlayerCharacterViewModel> logger;

    private IServiceProvider Services { get; }

    private ObservableCollection<ICharacterClass> fullClassList;

    [ObservableProperty]
    private int strengthScore;
    [ObservableProperty]
    private int intelligenceScore;
    [ObservableProperty]
    private int wisdomScore;
    [ObservableProperty]
    private int dexterityScore;
    [ObservableProperty]
    private int constitutionScore;
    [ObservableProperty]
    private int charismaScore;
    [ObservableProperty]
    private RaceEnum race;
    [ObservableProperty]
    private ObservableCollection<ClassEnum> validClasses;
    [ObservableProperty]
    private GenderEnum gender;
    [ObservableProperty]
    private RaceType raceType;
    [ObservableProperty]
    private ObservableCollection<RaceSubTypeEnum> raceSubType;
    [ObservableProperty]
    private ObservableCollection<LanguageEnum> languages;
    [ObservableProperty]
    private SizeEnum size;
    [ObservableProperty]
    private IHeight height;
    [ObservableProperty]
    private int weight;
    [ObservableProperty]
    private int age;
    [ObservableProperty]
    private int speed;
    [ObservableProperty]
    private int wealth;
    [ObservableProperty]
    private AlignmentEnum alignment;
    [ObservableProperty]
    private IArmorClass armorClass;
    [ObservableProperty]
    private IHitPoints hitPoints;
    [ObservableProperty]
    private ISavingThrow willSave;
    [ObservableProperty]
    private ISavingThrow fortitudeSave;
    [ObservableProperty]
    private ISavingThrow reflexSave;
    [ObservableProperty]
    private ObservableCollection<SkillEnum> skills;
    [ObservableProperty]
    private decimal challengeRating;
    [ObservableProperty]
    private int experiencePoints;

    public IAbilityBase Strength { get; set; }
    public IAbilityBase Intelligence { get; set; }
    public IAbilityBase Wisdom { get; set; }
    public IAbilityBase Dexterity { get; set; }
    public IAbilityBase Constitution { get; set; }
    public IAbilityBase Charisma { get; set; }


    [RelayCommand]
    private void Reroll()
    {
        Initialize();
    }

    private void Initialize()
    {
        IHumanoidRaceTable? raceTable = Services.GetService<IHumanoidRaceTable>();
        var dice = new Dice("1D10").Total;
        if (dice == 10)
        {
            dice = (int) RaceEnum.Human;
        }

        IHumanoidRaceFactory raceFactory = Services.GetService<IHumanoidRaceFactory>();
        var character = raceFactory.Create((RaceEnum)dice);

        // Copy over the character values
        Strength = character.Strength;
        StrengthScore = character.Strength.Score();
        Intelligence = character.Intelligence;
        IntelligenceScore = character.Intelligence.Score();
        Wisdom = character.Wisdom;
        WisdomScore = character.Wisdom.Score();
        Dexterity = character.Dexterity;
        DexterityScore = character.Dexterity.Score();
        Constitution = character.Constitution;
        ConstitutionScore = character.Constitution.Score();
        Charisma = character.Charisma;
        CharismaScore = character.Charisma.Score();
        Race = character.Race;

        foreach (var pcclass in fullClassList)
        {
            bool classValid = false;
            foreach (var ability in pcclass.ClassPrerequisites)
            {
                if (ability.AbilityAcceptable(this))
                {

                }
            }
        }

        ValidClasses = new ObservableCollection<ClassEnum>();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public PlayerCharacterViewModel(
        IServiceProvider services,
        ILoggerFactory loggerFactory)
    {
        logger = loggerFactory.CreateLogger<PlayerCharacterViewModel>();
        Services = services;

        // The full class list
        fullClassList = new ObservableCollection<ICharacterClass>();
        fullClassList.Add(services.GetService<IBarbarian>());
        fullClassList.Add(services.GetService<IBard>());
        fullClassList.Add(services.GetService<ICleric>());
        fullClassList.Add(services.GetService<IDruid>());
        Initialize();
    }
}
