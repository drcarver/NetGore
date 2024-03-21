using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Barbarian
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="creature"></param>
    public Barbarian(Creature creature, 
        RandomTableEntry classEntry)
    {
        creature.ClassInformation.Add(
            new ClassInformation
            {
                Name = classEntry.Name,
                Description = classEntry.Description,
                HitDice = "1d12",
                Class = ClassEnum.Barbarian,
                Level = 1,
            });

            creature.Wealth = new Dice("3d6").Total * 10;
    }
}
