using System;
using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Abilities;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Models;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GoDungeon.Core.ViewModels
{
    public partial class CreatureViewModel : StandardTableEntryViewModel, ICreature
    {
        ///// <summary>
        /// The creatures gender
        /// </summary>
        [ObservableProperty]
        private GenderEnum gender;

        /// <summary>
        /// The character's race
        /// </summary>
        [ObservableProperty]
        private RaceEnum race;

        /// <summary>
        /// Race Type
        /// </summary>
        [ObservableProperty]
        private RaceTypeEnum raceType;

        /// <summary>
        /// Race Sub Type
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<RaceSubTypeEnum> raceSubType = new ObservableCollection<RaceSubTypeEnum>();

        /// <summary>
        /// The languages the creature speaks
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<LanguageEnum> languages = new ObservableCollection<LanguageEnum>();

        /// <summary>
        /// Strength measures bodily power, athletic 
        /// training, and the extent to which you can 
        /// exert raw physical force.
        /// </summary>
        [ObservableProperty]
        private IAbilityBase strength;

        /// <summary>
        /// Intelligence measures mental acuity, accuracy 
        /// of recall, and the ability to reason.
        /// </summary>
        [ObservableProperty]
        private IAbilityBase intelligence;

        /// <summary>
        /// Wisdom reflects how attuned you are to the 
        /// world around you and represents perceptiveness 
        /// and intuition.
        /// </summary>
        [ObservableProperty]
        private IAbilityBase wisdom;

        /// <summary>
        /// Dexterity measures agility, reflexes, and 
        /// balance.
        /// </summary>
        [ObservableProperty]
        private IAbilityBase dexterity;

        /// <summary>
        /// Constitution measures health, stamina, and 
        /// vital force.
        /// </summary>
        [ObservableProperty]
        private IAbilityBase constitution;

        /// <summary>
        /// Charisma measures your ability to interact 
        /// effectively with others. It includes such 
        /// factors as confidence and eloquence, and 
        /// it can represent a charming or commanding 
        /// personality.
        /// </summary>
        [ObservableProperty]
        private IAbilityBase charisma;

        /// <summary>
        /// The size of the creature
        /// </summary>
        [ObservableProperty]
        private SizeEnum size;

        /// <summary>
        /// The height of the creature in feet and inches
        /// </summary>
        [ObservableProperty]
        public IHeight height;

        /// <summary>
        /// The weight of the creature in pounds
        /// </summary>
        [ObservableProperty]
        private int weight;

        /// <summary>
        /// The age of the creature
        /// </summary>
        [ObservableProperty]
        private int age;

        /// <summary>
        /// The weight in lbs being dragged
        /// </summary>
        [ObservableProperty]
        private float dragOrPushWeight = 0;

        /// <summary>
        /// The creature's speed in feet
        /// </summary>
        [ObservableProperty]
        private int speed;
        //{
        //    get
        //    {
        //        if (DragOrPushWeight > CarryingCapacity)
        //        {
        //            return 5;
        //        }
        //        return speed;
        //    }
        //    set => speed = value;
        //}

        /// <summary>
        /// Wealth in gold pieces
        /// </summary>
        [ObservableProperty]
        private int wealth;

        /// <summary>
        /// Creature alignment
        /// </summary>
        [ObservableProperty]
        private AlignmentEnum alignment = AlignmentEnum.NonAligned;

        /// <summary>
        /// The base armor class of the creature
        /// </summary>
        [ObservableProperty]
        private IArmorClass armorClass = new ArmorClassViewModel();

        /// <summary>
        /// The hit points for the character
        /// </summary>
        [ObservableProperty]
        private IHitPoints hitPoints;

        /// <summary>
        /// These saves reflect your resistance to mental 
        /// influence as well as many magical effects. 
        /// Apply your Wisdom modifier to your Will saving 
        /// throws.
        /// </summary>
        [ObservableProperty]
        private ISavingThrow willSave;

        /// <summary>
        /// These saves measure your ability to stand up 
        /// to physical punishment or attacks against your 
        /// vitality and health. Apply your Constitution 
        /// modifier to your Fortitude saving throws.
        /// </summary>
        [ObservableProperty]
        private ISavingThrow fortitudeSave;

        /// <summary>
        /// These saves test your ability to dodge area 
        /// attacks and unexpected situations. Apply 
        /// your Dexterity modifier to your Reflex saving 
        /// throws
        /// </summary>
        [ObservableProperty]
        private ISavingThrow reflexSave;

        /// <summary>
        /// The creature skills
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<SkillEnum> skills = new ObservableCollection<SkillEnum>();

        /// <summary>
        /// The challenge rating of the creature
        /// </summary>
        [ObservableProperty]
        private decimal challengeRating;

        /// <summary>
        /// THe experience points for killing the creature
        /// </summary>
        [ObservableProperty]
        private int experiencePoints;

        #region Drag, lift, push and carry
        // Size and Strength. Larger creatures can bear
        //more weight, whereas Tiny creatures can carry less.
        //For each size category above Medium, double the
        //creature’s carrying capacity and the amount it can
        //push, drag, or lift. For a Tiny creature, halve these
        //weights.

        /// <summary>
        /// Push, Drag, or Lift.You can push, drag, or lift a
        /// weight in pounds up to twice your carrying capacity
        /// (or 30 times your Strength score). While pushing or
        /// dragging weight in excess of your carrying capacity, 
        /// your speed drops to 5 feet
        /// </summary>
        public float canDrag => Capacity(30);

        /// <summary>
        /// Your carrying capacity is your Strength score 
        /// multiplied by 15. This is the weight (in pounds) that 
        /// you can carry, which is high enough that most characters 
        /// don’t usually have to worry about it.
        /// </summary>
        public float CarryingCapacity => Capacity(15);

        public IServiceProvider Services { get; }

        /// <summary>
        /// Compute capacity based on size
        /// </summary>
        /// <param name="multiplier">Either 15 for carrying or 30 for dragging</param>
        /// <returns>The weight in lbs.</returns>
        private float Capacity(int multiplier)
        {
            switch (Size)
            {
                case SizeEnum.Gargantuan:
                    return Strength.Score * (multiplier * 16);
                case SizeEnum.Colossal:
                    return Strength.Score * (multiplier * 8);
                case SizeEnum.Huge:
                    return Strength.Score * (multiplier * 4);
                case SizeEnum.Large:
                    return Strength.Score * (multiplier * 2);
                case SizeEnum.Medium:
                    return Strength.Score * multiplier;
                case SizeEnum.Small:
                    return Strength.Score * (multiplier / 2);
                case SizeEnum.Tiny:
                    return Strength.Score * (multiplier / 4);
                case SizeEnum.Diminutive:
                    return Strength.Score * (multiplier / 8);
                case SizeEnum.Fine:
                    return Strength.Score * (multiplier / 16);
            }
            return Strength.Score * multiplier;
        }
        #endregion

        /// <summary>
        /// Creatures that have a height and weight implement
        /// this method
        /// </summary>
        public virtual void SetHeightAndWeight()
        {
        }

        /// <summary>
        /// Alignment. Most halflings are lawful good. As a 
        /// rule, they are good-hearted and kind, hate to see 
        /// others in pain, and have no tolerance for oppression.
        /// <para>
        /// They are also very orderly and traditional, leaning 
        /// heavily on the support of their community and the 
        /// comfort of their old ways.
        /// </para>
        /// </summary>
        /// <param name="service">The service provider</param>
        /// <param name="filter">The alignment filter</param>
        public void SetAlignment(AlignmentFilterEnum filter)
        {
            IRandomAlignmentTable alignmentTable = Services.GetRequiredService<IRandomAlignmentTable>();
            alignmentTable.InitializeTable();
            alignmentTable.AlignmentFilter = AlignmentFilterEnum.GoodOnly;
            var alignmentVM = (AlignmentTableEntryViewModel)alignmentTable.GetRandomRangeEntry();
            Alignment = alignmentVM.Alignment;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CreatureViewModel()
        {
            // Setup some required values
            HitPoints = new HitPointsViewModel(this);

            // Generate the abilities
            Strength = new Strength(this);
            Intelligence = new Intelligence(this);
            Wisdom = new Wisdom(this);
            Dexterity = new Dexterity(this);
            Constitution = new Constitution(this);
            Charisma = new Charisma(this);

            // Generate the gender
            Gender = new GenderTable().GetGender();
            SetHeightAndWeight();

            // Saving throws
            WillSave = new WillSaveViewModel(this);
            FortitudeSave = new FortitudeSaveViewModel(this);
            ReflexSave = new ReflexSaveViewModel(this);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="services"></param>
        /// <param name="logger"></param>
        public CreatureViewModel(
            IServiceProvider services,
            ILoggerFactory logger)
            : this()
        {
            Services = services;

            // Alignment
            SetAlignment(AlignmentFilterEnum.NonEvil);
        }
    }
}
