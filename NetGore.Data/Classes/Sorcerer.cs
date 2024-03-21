using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Sorcerer
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="creature"></param>
    public Sorcerer(Creature creature, RandomTableEntry entry)
    {
        creature.ClassInformation.Add(
            new ClassInformation
            {
                Name = entry.Name,
                Description = entry.Description,
                HitDice = "1d6",
                Class = ClassEnum.Sorcerer,
                Level = 1,
            });

            creature.Wealth = new Dice("2d6").Total * 10;
    }
}
