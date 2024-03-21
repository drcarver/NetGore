using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Rogue
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="creature"></param>
    public Rogue(Creature creature, RandomTableEntry entry)
    {
        creature.ClassInformation.Add(
            new ClassInformation
            {
                Name = entry.Name,
                Description = entry.Description,
                HitDice = "1d8",
                Class = ClassEnum.Rogue,
                Level = 1,
            });

            creature.Wealth = new Dice("4d6").Total * 10;
    }
}
