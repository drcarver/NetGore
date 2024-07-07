using System;

using GoDungeon.Character.Interfaces;
using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Abilities;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.NPC
{
    public class Commoner : CharacterViewModel
    {
        /// <summary>
        /// The hit dice for this class
        /// </summary>
        private const string HitDice = "1d8";

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="loggerFactory"></param>
        public Commoner(
            ILoggerFactory loggerFactory,
            IServiceProvider services,
            IClassService classService)
            : base(services, loggerFactory)
        {
            Initialize();
        }

        /// <summary>
        /// The commoner's profession
        /// </summary>
        public IBackgroundTableEntry Profession { get; private set; }

        /// <summary>
        /// Initialize the class 
        /// </summary>
        private void Initialize()
        {
            Name = "Commoner";
            Description =
                "Commoners include peasants, serfs, slaves, " +
                "servants, pilgrims, merchants, artisans,";

            // The Abilities
            Strength = new Strength(10, this);
            Intelligence = new Intelligence(10, this);
            Wisdom = new Wisdom(10, this);
            Dexterity = new Dexterity(10, this);
            Constitution = new Constitution(10, this);
            Charisma = new Charisma(10, this);

            // The rest of the NPC values
            HitPoints = new HitPointsViewModel(HitDice, this);
            Size = SizeEnum.Medium;
            Speed.Add(new MovementViewModel { Speed = 30, MovementType = MovementEnum.Normal });
            //IRaceService.SetRace(this);

            //Commoner
            //Medium humanoid(any race),	any alignment
            //Senses passive	Perception	10
            //Challenge	0	(10	XP)
            //Actions
            //Club.	Melee	Weapon	Attack: +2  to hit, reach	5	ft., one	
            //target.	Hit:	2(1d4)   bludgeoning damage.
            //

        }
    }
}
