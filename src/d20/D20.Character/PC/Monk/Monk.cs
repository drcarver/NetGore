using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core;
using D20.Core.Enum;
using D20.Goods.Enum;
using D20.Goods.Models;

using Microsoft.Extensions.Logging;

namespace D20.Character.PC.Monk;

public class Monk : CharacterClassBase
{
    /// <summary>
    /// The DI service provider
    /// </summary>
    private readonly IServiceProvider serviceProvider;

    /// <summary>
    /// Level up the character with this class
    /// </summary>
    /// <param name="character"></param>
    public override void LevelUp(ICharacter character)
    {
        var MonkLevelTable = serviceProvider.GetService<IMonkLevelTable>();

        ////Skills: Choose two
        //int newSkillCount = 0;
        //for (int i = 0; i < Skills.Count; i++)
        //{
        //    var dice = new Dice($"1d{Skills.Count}").Total;
        //    if (!character.Skills.Contains(Skills[dice]))
        //    {
        //        newSkillCount++;
        //        if (newSkillCount > 2)
        //        {
        //            break;
        //        }
        //        character.Skills.Add(Skills[dice]);
        //    }
        //}

        //character.Equipment.Add(new Ammunition( )
        //Equipment
        //You start   with the following equipment,  in	addition
        //to  the equipment   granted by  your background:
        //• (a) a   shortsword or(b) any simple  weapon
        //• (a) a   dungeoneer’s pack    or(b) an explorer’s pack
        //• 10	darts
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Monk(
        IServiceProvider services,
        ILoggerFactory loggerFactory)
        : base(loggerFactory)
    {
        serviceProvider = services;
        Name = nameof(Monk);
        Description =
            "Monks excel at overcoming even the most daunting " +
            "perils, striking where it’s least expected, and " +
            "taking advantage of enemy vulnerabilities. Fleet " +
            "of foot and skilled in combat, monks can navigate " +
            "any battlefield with ease, aiding allies wherever " +
            "they are needed most.";
    }
}

