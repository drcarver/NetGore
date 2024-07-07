using GoDungeon.Character.Models;
using GoDungeon.Character.PC.Cleric;
using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Druid
{
    /// <summary>
    /// Druids come by their primal power in various ways. One 
    /// druid might receive her power from an elemental creature, 
    /// and another might learn it from a beast or the fey. 
    /// </summary>
    public class DruidViewModel : CharacterClassBaseViewModel, IDruid
    {
        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character"></param>
        public override void LevelUp(ICharacterRace character)
        {
            base.LevelUp(character);
            if (Level == 0)
            {
                Initialize(character);
            }
        }

        /// <summary>
        /// Initialize the class
        /// </summary>
        protected void Initialize(ICharacter character)
        {
            base.Initialize(character);

            //Hit Points
            //Hit Dice:	1d8	per cleric  level
            //Hit Points at  1st Level: 8 +	your Constitution modifier
            //Hit Points at  Higher Levels: 1d8	(or 5) + your Constitution
            //  modifier per cleric level   after	1st
            character.HitPoints = new HitPointsViewModel("1d8", character);

            //Saving  Throws:	Wisdom,	Charisma
            SavingThrows.Add(new SavingThrowViewModel(character.Wisdom));
            SavingThrows.Add(new SavingThrowViewModel(character.Charisma));

            //Armor: Light armor, medium  armor, shields
            //var armorList = DruidBackgroundTable?.Table?.Cast<IEquipmentTableEntry>()
            //    .Where(cg =>
            //           cg.EquipmentCategory == EquipmentCategoryEnum.Shields
            //        && cg.EquipmentCategory == EquipmentCategoryEnum.LightArmor
            //        && cg.EquipmentCategory == EquipmentCategoryEnum.MediumArmor)
            //    .ToList();
            //if (armorList != null)
            //{
            //    foreach (var item in armorList)
            //    {
            //        if (!character.ArmorProficiency.Contains((int)item.Equipment))
            //        {
            //            character.ArmorProficiency.Add(item.Equipment);
            //        }
            //    }
            //}

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
        public DruidViewModel(
            ILoggerFactory loggerFactory,
            IDruidBackgroundTable backgroundTable)
        {
            ClassEnum = Core.Enum.ClassEnum.Druid;
            Name = nameof(Core.Enum.ClassEnum.Druid);
            Description =
                "Druids come by their primal power in various " +
                "ways. One druid might receive her power from " +
                "an elemental creature, and another might learn " +
                "it from a beast or the fey.";

            classPrerequisites.Add(
                new ClassPrerequisiteModel
                {
                    Ability = AbilityEnum.Wisdom,
                    Score = 13,
                });
        }
    }
}
