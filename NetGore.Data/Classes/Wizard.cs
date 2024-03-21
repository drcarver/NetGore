using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Wizard
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="creature"></param>
    public Wizard(Creature creature, RandomTableEntry entry)
    {
        creature.ClassInformation.Add(
            new ClassInformation
            {
                Name = entry.Name,
                Description = entry.Description,
                HitDice = "1d6",
                Class = ClassEnum.Wizard,
                Level = 1,
            });

            creature.Wealth = new Dice("2d6").Total * 10;
    }
}
