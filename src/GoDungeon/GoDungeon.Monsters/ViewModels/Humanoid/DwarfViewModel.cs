using System;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels.Humanoid
{
    /// <summary>
    /// Dwarves are a stoic but stern race, ensconced 
    /// in cities carved from the hearts of mountains 
    /// and fiercely determined to repel the depredations 
    /// of savage races like orcs and goblins. More than 
    /// any other race, dwarves have acquired a 
    /// reputation as dour and humorless artisans 
    /// of the earth.It could be said that their history 
    /// shapes the dark disposition of many dwarves, 
    /// for they reside in high mountains and dangerous 
    /// realms below the earth, constantly at war with 
    /// giants, goblins, and other such horrors.
    /// </summary>
    public partial class DwarfViewModel : CharacterRaceViewModel, IDwarf
    {
        private ILogger? _logger;
        private readonly ILoggerFactory loggerFactory;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">The logging service</param>
        public DwarfViewModel(
            ILoggerFactory logger,
            IServiceProvider services)
            : base(logger, services)
        {
            _logger = logger.CreateLogger<IDwarf>();
            loggerFactory = logger;
            Initialize();
        }

        /// <summary>
        /// Initialize all the race properties of the character
        /// </summary>
        public void Initialize()
        {
            //Type: Dwarves are humanoids with the dwarf subtype.
            Race = RaceEnum.Dwarf;
            RaceType = RaceTypeEnum.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.Dwarf);

            //Ability Score Increase. Your Constitution score
            //increases by 2.
            Constitution.RacialModifier = 2;

            //Size: Dwarves are Medium creatures and
            //thus receive no bonuses or penalties due
            //to their size.
            Size = SizeEnum.Medium;
            SetHeightAndWeight();

            //Base Speed: (Slow and Steady) Dwarves have
            //a base speed of 20 feet, but their speed
            //is never modified by armor or encumbrance.
            Speed = 20;

            //Languages: Dwarves begin play speaking
            //Common and Dwarven. Dwarves with high
            //Intelligence scores can choose from the
            //following: Giant, Gnome, Goblin, Orc,
            //Terran, and Undercommon. 
            Languages.Add(LanguageEnum.Common);
            Languages.Add(LanguageEnum.Dwarven);
        }

        /// <summary>
        /// Set the height, weight and age of the creature
        /// </summary>
        /// <param name="creature">creature info</param>
        private void GetVitalStatistics(ICreature creature)
        {
            int feet = 3, inches = 9, weight = 150;
            string heightdice = "2d4";
            string weightdice = "2D4";
            if (Gender == GenderEnum.Male)
            {
                //BackgroundTables.HeightAndWeight(
                //    ref feet, ref inches, ref weight,
                //    heightdice, weightdice, 7);
                Weight = weight;
                //Height = $"{feet} ft. {inches} in.";
            }
            else
            {
                feet = 3; inches = 7; weight = 120;
                //BackgroundTables.HeightAndWeight(
                //    ref feet, ref inches, ref weight,
                //    heightdice, weightdice, 7);
                Weight = weight;
                //Height = $"{feet} ft. {inches} in.";
            }

            string intuitiveDice = "3d6";
            string selftaughtDice = "5d6";
            string trainedDice = "7d6";
            int startingAge = 40;
            //Age = BackgroundTables.CalculateCharacterAge(
            //    ClassEnum.Any, startingAge, intuitiveDice,
            //    selftaughtDice, trainedDice);
        }
    }
}