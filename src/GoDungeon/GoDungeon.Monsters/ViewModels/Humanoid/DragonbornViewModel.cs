using System;

using GoDungeon.Background.Interfaces;
using GoDungeon.Background.Tables.Dragonborn;
using GoDungeon.Core;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;
using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels.Humanoid
{
    /// <summary>
    /// Social and amicable by nature, halflings fit 
    /// equally well in both communities of humans 
    /// and those of their wily kinsfolk. Prone to 
    /// wanderlust, halflings can be found anywhere 
    /// civilized humanoids settle.
    /// </summary>
    public class DragonbornViewModel : CharacterRaceViewModel, IDragonborn
    {
        public IServiceProvider ServiceProvider { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="loggerFactory">The logger factory</param>
        /// <param name="services">The service provider</param>
        public DragonbornViewModel(
            IServiceProvider serviceProvider,
            ILoggerFactory loggerFactory)
            : base(loggerFactory, serviceProvider)
        {
            // Setup the service provider
            ServiceProvider = serviceProvider;

            // Initialize  the character from the race features
            Initialize();

            // Now generate the characters background
            // First the homeland
            var homelandTable = ServiceProvider.GetRequiredService<IDragonbornHomelandTable>();
            homelandTable.InitializeTable();
            IUnusualHomelandTable unusualHomelandTable = ServiceProvider.GetRequiredService<IUnusualHomelandTable>();
            unusualHomelandTable.InitializeTable();
            GetHomeland(homelandTable, unusualHomelandTable);

            // Net the parents
            var parentsTable = ServiceProvider.GetRequiredService<IDragonbornParentsTable>();
            parentsTable.InitializeTable();
            GetParents(parentsTable);

            // Next the Circumstance of birth
            GetCircumstanceOfBirth();

            // Set the alignment
            SetAlignment(AlignmentFilterEnum.GoodOnly);

            // Next set the short description
            SetShortDescription();
        }

        /// <summary>
        /// Initialize the creature
        /// </summary>
        private void Initialize()
        {
            Race = RaceEnum.Dragonborn;

            //Ability Score Increase.Your Dexterity
            //score increases by 2.
            Dexterity.RacialModifier += 2;

            // Size. Your size is Small.
            SetHeightAndWeight();
            Age = 20;
            Size = SizeEnum.Small;

            // Speed. Your base walking speed is 25 feet.
            Speed.Add(new MovementViewModel { Speed = 25, MovementType = MovementEnum.Normal });
        }

        //Table: Random Height and Weight
        //Gender Base Height    Height Modifier Base Weight Weight Modifier
        //Male	    2 ft. 8 in.	 +2d4 in.        30 lbs. +(2d4 lbs.)
        //Female	2 ft. 6 in.	 +2d4 in.        25 lbs. +(2d4 lbs.)
        /// <summary>
        /// The Height
        /// </summary>
        /// <param name="creature">The player character</param>
        public override void SetHeightAndWeight()
        {
            switch (Gender)
            {
                case GenderEnum.Male:
                    Height = new HeightViewModel(2, 8).Add("2d4");
                    Weight = 30 + new Dice("2d4").Total;
                    break;
                case GenderEnum.Female:
                    Height = new HeightViewModel(2, 6).Add("2d4");
                    Weight = 25 + new Dice("2d4").Total;
                    break;
            }
        }
    }
}