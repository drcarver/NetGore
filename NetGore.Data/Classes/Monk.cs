using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Monk
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="creature"></param>
    public Monk(Creature creature, RandomTableEntry entry)
    {
        creature.ClassInformation.Add(
            new ClassInformation
            {
                Name = entry.Name,
                Description = entry.Description,
                HitDice = "1d8",
                Class = ClassEnum.Monk,
                Level = 1,
            });

            creature.Wealth = new Dice("1d6").Total * 10;
    }
}
