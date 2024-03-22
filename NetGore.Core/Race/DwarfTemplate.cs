//using System.Diagnostics.CodeAnalysis;

//using NetGore.Core.Enum;

//namespace NetGore.Core.Race;

///// <summary>
///// Your dwarf character has an assortment of 
///// inborn abilities, part and parcel of dwarven 
///// nature.
///// </summary>
//public class DwarfTemplate : RaceTemplate
//{
//    /// <summary>
//    /// Dwarf
//    /// </summary>
//    Name = "Dwarf";

//    /// <summary>
//    /// The race description
//    /// </summary>
//    public override string Description { get; set; } =
//        "Your dwarf character has an assortment of " +
//        "inborn abilities, part and parcel of " +
//        "dwarven nature.";

//    /// <summary>
//    /// Ability scores and their increases
//    /// </summary>
//    public override Dictionary<string, int>? AbilityScoreIncrease { get; set; } = new()
//    {
//        { "CON", 2 }  // Your Constitution score increases by 2.
//    };

//    /// <summary>
//    /// Dwarves mature at the same rate as humans, but 
//    /// they’re considered young until they reach 
//    /// the age of 50. On average, they live about 
//    /// 350 years.
//    /// </summary>
//    public override int Age { get; set; }

//    /// <summary>
//    /// Most dwarves are lawful, believing firmly 
//    /// in the benefits of a well ordered society. 
//    /// They tend toward good as well, with a strong 
//    /// sense of fair play and a belief that everyone 
//    /// deserves to share in the benefits of a just 
//    /// order.
//    /// </summary>
//    public override AlignmentEnum[]? Alignments { get; set; } =
//    {

//    };

//    /// <summary>
//    /// Dwarves stand between 4 and 5 feet tall and 
//    /// average about 150 pounds. Your size is Medium.
//    /// </summary>
//    public override SizeEnum Size { get; set; } = SizeEnum.Medium;

//    /// <summary>
//    ///  Your base walking speed is 25 feet. Your 
//    ///  speed is not reduced by wearing heavy armor.
//    /// </summary>
//    public override int Speed { get; set; } = 25;

//    /// <summary>
//    /// You can speak, read, and write Common and 
//    /// Dwarvish. Dwarvish is full of hard consonants 
//    /// and guttural sounds, and those characteristics 
//    /// spill over into whatever other language a 
//    /// dwarf might speak.
//    /// </summary>
//    public override LanguageEnum[]? Language { get; set; } =
//    {
//        LanguageEnum.Common,
//        LanguageEnum.Dwarvish
//    };

//    public override RaceTemplate[]? SubRaces { get; set; } =
//    {
//    {   new 
//    }
//    };
//    public override TraitEnum[]? Traits { get; set; }

//    /// <summary>
//    /// Constructor
//    /// </summary>
//    [SetsRequiredMembers]
//    public Dwarf()
//    {
//    }
//}
