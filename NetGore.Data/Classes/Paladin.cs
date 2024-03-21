using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Paladin
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="creature"></param>
    public Paladin(Creature creature, RandomTableEntry entry)
    {
        creature.ClassInformation.Add(
            new ClassInformation
            {
                Name = entry.Name,
                Description = entry.Description,
                HitDice = "1d10",
                Class = ClassEnum.Paladin,
                Level = 1,
            });

            creature.Wealth = new Dice("5d6").Total * 10;
    }
}
