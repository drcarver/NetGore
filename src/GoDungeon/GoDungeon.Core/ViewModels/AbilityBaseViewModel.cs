using System.ComponentModel.DataAnnotations;
using System.Linq;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Core.ViewModels
{
    public partial class AbilityBaseViewModel : DataObjectViewModel, IAbilityBase
    {
        /// <summary>
        /// The creature with this ability
        /// </summary>
        [ObservableProperty]
        private ICreature? creature;

        /// <summary>
        /// The base ability from the total of dice roll
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Score))]
        private int baseAbility;

        /// <summary>
        /// The separate dice rolls
        /// </summary>
        [ObservableProperty]
        private int[]? rolls;

        /// <summary>
        /// The abbreviation for the ability
        /// </summary>
        [ObservableProperty]
        [StringLength(3)]
        private string abbreviation = string.Empty;

        /// <summary>
        /// Any racial modifiers
        /// </summary>
        [ObservableProperty]
        private int racialModifier = 0;

        /// <summary>
        /// Temporary modifiers
        /// </summary>
        [ObservableProperty]
        private int temporaryModifier = 0;

        /// <summary>
        /// The bonus for the Ability
        /// </summary>
        [ObservableProperty]
        private int abilityBonus;

        /// <summary>
        /// The computed ability score
        /// </summary>
        /// <returns>The current ability score with all modifiers</returns>
        public int Score
        {
            get { 
                return BaseAbility
                    + RacialModifier
                    + TemporaryModifier;
            } 
        }

        /// <summary>
        /// The modifier table
        /// </summary>
        private SpellAbilityModifierTable ModifierTable { get; }

        /// <summary>
        /// Return the Ability as a string
        /// </summary>
        /// <returns>The ability as a string</returns>
        public override string ToString()
        {
            var retval = Abbreviation + " ";
            for (int i = 0; i < Rolls?.Length; i++)
            {
                retval += $"Dice{i}={Rolls[i]} ";
            }
            // BaseAbility + RacialModifier + TemporaryModifier
            retval += $"BaseAbility({BaseAbility}) + ";
            retval += $"RacialModifier({RacialModifier}) + ";
            retval += $"TemporaryModifier({TemporaryModifier}) = ";
            retval += $" Total({Score})";
            return retval;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="creature">The creature that has this ability</param>
        protected AbilityBaseViewModel(ICreature creature)
        {
            Creature = creature;
            var dice = new Dice("4d6");
            do
            {
                dice.RollDice("4d6");
                Rolls = new int[3];
                for (int i = 0; i < Rolls.Length; i++)
                {
                    Rolls[i] = dice.Rolls[i];
                }
                BaseAbility = Rolls.Sum();
            } while (BaseAbility <= 6);
            ModifierTable = new SpellAbilityModifierTable();
            ModifierTable.InitializeTable();
            AbilityBonus = ModifierTable.GetModifierByScore(BaseAbility);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="baseAbility">The ability score.  We are not randomly generating it</param>
        /// <param name="creature">The creature that has this ability</param>
        protected AbilityBaseViewModel(int baseAbility, ICreature creature)
            : this(creature)
        {
            Rolls = null;
            BaseAbility = baseAbility;
        }
    }
}
