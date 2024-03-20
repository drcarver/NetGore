using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NetGore.Core.Models;

namespace NetGore.Data.Race;

internal class Dwarf
{
    public Dwarf(Character character, RandomTableEntry race)
    {
        character.RaceName = race.Name;
        character.Description = race.Description;
    }
}
