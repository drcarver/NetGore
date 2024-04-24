using System.Collections.Generic;

using D20.Core.Abilities;
using D20.Core.Base;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Tables;

namespace D20.Core.Models
{
    public class Creature : DataObject, ICreature
    {
        private int speed;

        ///// <summary>
        /// The creatures gender
        /// </summary>
        public GenderEnum Gender { get; set; }

        /// <summary>
        /// The character's race
        /// </summary>
        public RaceEnum Race { get; set; }

        /// <summary>
        /// Race Type
        /// </summary>
        public RaceType RaceType { get; set; }

        /// <summary>
        /// Race Sub Type
        /// </summary>
        public List<RaceSubTypeEnum> RaceSubType { get; set; } = new List<RaceSubTypeEnum>();

        /// <summary>
        /// The languages the creature speaks
        /// </summary>
        public List<LanguageEnum> Languages { get; set; } = new List<LanguageEnum>();

        /// <summary>
        /// Strength measures bodily power, athletic 
        /// training, and the extent to which you can 
        /// exert raw physical force.
        /// </summary>
        public Strength Strength { get; set; }

        /// <summary>
        /// Intelligence measures mental acuity, accuracy 
        /// of recall, and the ability to reason.
        /// </summary>
        public Intelligence Intelligence { get; set; }

        /// <summary>
        /// Wisdom reflects how attuned you are to the 
        /// world around you and represents perceptiveness 
        /// and intuition.
        /// </summary>
        public Wisdom Wisdom { get; set; }

        /// <summary>
        /// Dexterity measures agility, reflexes, and 
        /// balance.
        /// </summary>
        public Dexterity Dexterity { get; set; }

        /// <summary>
        /// Constitution measures health, stamina, and 
        /// vital force.
        /// </summary>
        public Constitution Constitution { get; set; }

        /// <summary>
        /// Charisma measures your ability to interact 
        /// effectively with others. It includes such 
        /// factors as confidence and eloquence, and 
        /// it can represent a charming or commanding 
        /// personality.
        /// </summary>
        public Charisma Charisma { get; set; }

        /// <summary>
        /// The size of the creature
        /// </summary>
        public SizeEnum Size { get; set; }

        /// <summary>
        /// The height of the creature in feet and inches
        /// </summary>
        public Height Height { get; set; }

        /// <summary>
        /// The weight of the creature in pounds
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// The age of the creature
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// The weight in lbs being dragged
        /// </summary>
        public float DragOrPushWeight { get; set; } = 0;

        /// <summary>
        /// The creature's speed in feet
        /// </summary>
        public int Speed
        {
            get
            {
                if (DragOrPushWeight > CarryingCapacity)
                {
                    return 5;
                }
                return speed;
            }
            set => speed = value;
        }

        /// <summary>
        /// Wealth in gold pieces
        /// </summary>
        public int Wealth { get; set; }

        /// <summary>
        /// Creature alignment
        /// </summary>
        public AlignmentEnum Alignment { get; set; } = AlignmentEnum.NonAligned;

        /// <summary>
        /// The base armor class of the creature
        /// </summary>
        public ArmorClass ArmorClass { get; set; } = new ArmorClass();

        /// <summary>
        /// The hit points for the character
        /// </summary>
        public HitPoints HitPoints { get; set; }

        /// <summary>
        /// These saves reflect your resistance to mental 
        /// influence as well as many magical effects. 
        /// Apply your Wisdom modifier to your Will saving 
        /// throws.
        /// </summary>
        public WillSave WillSave { get; set; }

        /// <summary>
        /// These saves measure your ability to stand up 
        /// to physical punishment or attacks against your 
        /// vitality and health. Apply your Constitution 
        /// modifier to your Fortitude saving throws.
        /// </summary>
        public FortitudeSave FortitudeSave { get; set; }

        /// <summary>
        /// These saves test your ability to dodge area 
        /// attacks and unexpected situations. Apply 
        /// your Dexterity modifier to your Reflex saving 
        /// throws
        /// </summary>
        public ReflexSave ReflexSave { get; set; }

        /// <summary>
        /// The creature skills
        /// </summary>
        public List<SkillEnum> Skills { get; set; } = new List<SkillEnum>();

        /// <summary>
        /// The challenge rating of the creature
        /// </summary>
        public decimal ChallengeRating { get; set; }

        /// <summary>
        /// THe experience points for killing the creature
        /// </summary>
        public int ExperiencePoints { get; set; }

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
        public float CanDrag => Capacity(30);

        /// <summary>
        /// Your carrying capacity is your Strength score 
        /// multiplied by 15. This is the weight (in pounds) that 
        /// you can carry, which is high enough that most characters 
        /// don’t usually have to worry about it.
        /// </summary>
        public float CarryingCapacity => Capacity(15);

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
                    return Strength.Score() * (multiplier * 16);
                case SizeEnum.Colossal:
                    return Strength.Score() * (multiplier * 8);
                case SizeEnum.Huge:
                    return Strength.Score() * (multiplier * 4);
                case SizeEnum.Large:
                    return Strength.Score() * (multiplier * 2);
                case SizeEnum.Medium:
                    return Strength.Score() * multiplier;
                case SizeEnum.Small:
                    return Strength.Score() * (multiplier / 2);
                case SizeEnum.Tiny:
                    return Strength.Score() * (multiplier / 4);
                case SizeEnum.Diminutive:
                    return Strength.Score() * (multiplier / 8);
                case SizeEnum.Fine:
                    return Strength.Score() * (multiplier / 16);
            }
            return Strength.Score() * multiplier;
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
        /// Constructor
        /// </summary>
        public Creature()
        {
            // Setup some required values
            HitPoints = new HitPoints(this);
       
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
            WillSave = new WillSave(this);
            FortitudeSave = new FortitudeSave(this);
            ReflexSave = new ReflexSave(this);

            var alignmenttable = new RandomAlignmentTable();
            alignmenttable.InitializeTable();
            Alignment = ((AlignmentTableEntry)alignmenttable.GetRandomRangeEntry()).Alignment;
        }
    }
}
