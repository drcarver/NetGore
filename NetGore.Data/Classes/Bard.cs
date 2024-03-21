using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Bard
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="creature"></param>
    public Bard(Creature creature, RandomTableEntry entry)
    {
        creature.ClassInformation.Add(
            new ClassInformation
            {
                Name = entry.Name,
                Description = entry.Description,
                HitDice = "1d8",
                Class = ClassEnum.Bard,
                Level = 1,
            });

            creature.Wealth = new Dice("3d6").Total * 10;
    }
}
