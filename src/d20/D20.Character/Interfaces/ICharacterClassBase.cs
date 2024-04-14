using D20.Character.Models;
using D20.Core.Enum;
using D20.Goods.Enum;

namespace D20.Character.Interfaces;
public interface ICharacterClassBase
{
    List<EquipmentEnum> Armor { get; set; }
    List<EquipmentCategoryEnum> ArmorProficiency { get; set; }
    List<ClassPrerequisite> ClassPrerequisites { get; set; }
    List<EquipmentEnum> Equipment { get; set; }
    string? HitDice { get; set; }
    List<AbilityEnum> SavingThrows { get; set; }
    List<SkillEnum> Skills { get; set; }
    List<ToolProficiencyEnum> ToolProficiency { get; set; }
    List<WeaponProficiencyEnum> WeaponProficiency { get; set; }
}