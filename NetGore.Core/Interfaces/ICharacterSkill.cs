using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterSkill
{
    Character Character { get; set; }
    Skill Skill { get; set; }
    DateTime TimeAdded { get; set; }
}