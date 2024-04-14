using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Character.Tables;
using D20.Core.Abilities;
using D20.Core.Enum;
using D20.Core.Models;

using Microsoft.Extensions.Logging;

namespace NetGore.Data.NPC;

public class Commoner : D20Character
{
    /// <summary>
    /// The hit dice for this class
    /// </summary>
    private const string HitDice = "1d8";

    /// <summary>
    /// The constructor
    /// </summary>
    /// <param name="loggerFactory"></param>
    [SetsRequiredMembers]
    public Commoner(ILoggerFactory loggerFactory,
        IClassService classService)
        //IRaceService raceService) 
        : base(loggerFactory)
    {
        //RaceService = raceService;
        Initialize();
    }

    /// <summary>
    /// The commoner's profession
    /// </summary>
    public BackgroundTableEntry Profession { get; private set; }
    
    /// <summary>
    /// The race Service
    /// </summary>
    //public IRaceService RaceService { get; }

    /// <summary>
    /// Initialize the class 
    /// </summary>
    private void Initialize()
    {
        Name = "Commoner";
        Description =
            "Commoners include peasants, serfs, slaves, " +
            "servants, pilgrims, merchants, artisans,";

        // The Abilities
        Strength = new Strength(10, this);
        Intelligence = new Intelligence(10, this);
        Wisdom = new Wisdom(10, this);
        Dexterity = new Dexterity(10, this);
        Constitution = new Constitution(10, this);
        Charisma = new Charisma(10, this);
        
        // The rest of the NPC values
        HitPoints = new HitPoints(HitDice, this);
        Size = SizeEnum.Medium;
        Speed = 30;
        //IRaceService.SetRace(this);

        // The commoner profession
        Profession = (BackgroundTableEntry) new ProfessionTable().GetRandomEntry();

        //Commoner
        //Medium humanoid(any race),	any alignment
        //Senses passive	Perception	10
        //Challenge	0	(10	XP)
        //Actions
        //Club.	Melee	Weapon	Attack: +2  to hit, reach	5	ft., one	
        //target.	Hit:	2(1d4)   bludgeoning damage.
        //

    }
}
