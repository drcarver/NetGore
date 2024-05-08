using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Cleric
{
    /// <summary>
    /// Clerics are not merely people of religious faith—they are 
    /// devoted servants who wield true divine power from their 
    /// deities. The particular path that steers a cleric toward 
    /// their faith can mean the difference between a demon-worshiping 
    /// cultist and a lawful harbinger of her deity’s blessed faith.
    /// </summary>
    public class ClericViewModel : CharacterClassBaseViewModel, ICleric
    {
        /// <summary>
        /// Cleric background table
        /// </summary>
        public IClericBackgroundTable ClericBackgroundTable { get; }

        /// <summary>
        /// Cleric level table
        /// </summary>
        public IClericLevelTable ClericLevelTable { get; }

        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character"></param>
        public override void LevelUp(ICharacterClass character)
        {
        }

        //Weapons: Simple weapons
        //Tools:	None
        //Saving  Throws:	Wisdom,	Charisma
        //Skills: Choose two from History, Insight, Medicine,
        //Persuasion, and Religion
        //Equipment
        //You start   with the following equipment,  in	addition
        //to  the equipment   granted by  your background:
        //• (a) a   mace or(b) a warhammer(if	proficient)
        //• (a) scale   mail,	(b) leather armor,	or(c) chain mail
        //(if	proficient)
        //• (a) a   light crossbow    and	20	bolts or(b) any simple
        //weapon
        //• (a) a   priest’s pack    or(b) an explorer’s pack
        //• A shield  and a   holy symbol    
        /// <summary>
        /// Initialize the class
        /// </summary>
        protected override void Initialize(ICharacterClass character)
        {
            base.Initialize(character);

            //Hit Points
            //Hit Dice:	1d8	per cleric  level
            //Hit Points at  1st Level: 8 +	your Constitution modifier
            //Hit Points at  Higher Levels: 1d8	(or 5) + your Constitution
            //  modifier per cleric level   after	1st
            character.HitPoints = new HitPointsViewModel("1d8", character);

            //Saving  Throws:	Wisdom,	Charisma
            SavingThrows = new ObservableCollection<AbilityEnum>
            {
                { AbilityEnum.Wisdom },
                { AbilityEnum.Charisma }
            };

            //Armor: Light armor, medium  armor, shields
            var armorList = ClericBackgroundTable?.Table?.Cast<IEquipmentTableEntry>()
                .Where(cg =>
                       cg.EquipmentCategory == EquipmentCategoryEnum.Shields
                    && cg.EquipmentCategory == EquipmentCategoryEnum.LightArmor
                    && cg.EquipmentCategory == EquipmentCategoryEnum.MediumArmor)
                .ToList();
            if (armorList != null)
            {
                foreach (var item in armorList)
                {
                    if (!character.ArmorProficiency.Contains(item.Equipment))
                    {
                        character.ArmorProficiency.Add(item.Equipment);
                    }
                }
            }

            //// Add any weapon proficiencies
            //foreach (var item in WeaponProficiency)
            //{
            //    if (!character.WeaponProficiency.Contains(item))
            //    {
            //        character.WeaponProficiency.Add(item);
            //    }
            //}

            //// Add any tool proficiencies
            //foreach (var item in ToolProficiency)
            //{
            //    if (!character.ToolProficiency.Contains(item))
            //    {
            //        character.ToolProficiency.Add(item);
            //    }
            //}

            //// Add any saving throws
            //foreach (var item in SavingThrows)
            //{
            //    if (!character.SavingThrows.Contains(item))
            //    {
            //        character.SavingThrows.Add(item);
            //    }
            //}

            //// Add any traits
            //if (Background?.Traits != null)
            //{
            //    foreach (var item in Background.Traits)
            //    {
            //        if (!character.Traits.Contains(item))
            //        {
            //            character.Traits.Add(item);
            //        }
            //    }
            //}

            // Skills are handled by the PC or NPC classes
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public ClericViewModel(
            ILoggerFactory loggerFactory,
            IClericBackgroundTable clericBackgroundTable,
            IClericLevelTable clericLevelTable)
        {
            // Cleric back table and Cleric Level table
            ClericBackgroundTable = clericBackgroundTable;
            ClericLevelTable = clericLevelTable;

            // Cleric back table and Cleric Level table
            ClericLevelTable.InitializeTable();
            ClericBackgroundTable.InitializeTable();

            Name = nameof(ClericViewModel);
            Description =
                "Clerics are not merely people of religious " +
                "faith—they are devoted servants who wield true " +
                "divine power from their deities. The particular " +
                "path that steers a cleric toward her faith can " +
                "mean the difference between a demon-worshiping " +
                "cultist and a lawful harbinger of her deity’s " +
                "blessed faith.";
        }
    }

}
