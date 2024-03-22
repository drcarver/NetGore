using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;

namespace NetGore.Core.Race;

/// <summary>
/// The description of each race includes racial 
/// traits that are common to members of that race. 
/// The following entries appear among the traits 
/// of most races.
/// </summary>
public class RaceTemplate
{
    /// <summary>
    /// The race name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The race description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Every race increases one or more of a 
    /// character’s ability scores.
    /// </summary>
    public Dictionary<string, int>? AbilityScoreIncrease { get; set; }

    /// <summary>
    /// The age entry notes the age when a member of
    /// the race is considered an adult, as well as 
    /// the race’s expected lifespan.This information
    /// can help you decide how old your character 
    /// is at the start of the game.You can choose 
    /// any age for your character, which could 
    /// provide an explanation for some of your 
    /// ability scores.For example, if you play 
    /// a young or very old character, your age 
    /// could explain a particularly low Strength 
    /// or Constitution score, while advanced age 
    /// could account for a high Intelligence or 
    /// Wisdom.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Most races have tendencies toward certain 
    /// alignments, described in this entry. These 
    /// are not binding for player characters, but 
    /// considering why your dwarf is chaotic, 
    /// for example, in defiance of lawful dwarf 
    /// society can help you better define your 
    /// character.
    /// </summary>
    public AlignmentEnum[]? Alignments { get; set; }

    /// <summary>
    /// Characters of most races are Medium, a size 
    /// category including creatures that are 
    /// roughly 4 to 8 feet tall.Members of a few 
    /// races are Small (between 2 and 4 feet tall), 
    /// which means that certain rules of the game 
    /// affect them differently.The most important 
    /// of these rules is that Small characters have 
    /// trouble wielding heavy weapons, as explained 
    /// in “Equipment.”
    /// </summary>
    public SizeEnum Size { get; set; }

    /// <summary>
    /// Your speed determines how far you can move 
    /// when traveling ( “Adventuring”) and fighting 
    /// (“Combat”).
    /// </summary>
    public int Speed { get; set; }

    /// <summary>
    /// By virtue of your race, your character can 
    /// speak, read, and write certain languages.
    /// </summary>
    public LanguageEnum[]? Language { get; set; }

    /// <summary>
    /// Some races have subraces.Members of a subrace 
    /// have the traits of the parent race in addition 
    /// to the traits specified for their subrace. 
    /// Relationships among subraces vary significantly
    /// from race to race and world to world.
    /// </summary>
    public RaceTemplate[]? SubRaces { get; set; }

    /// <summary>
    /// Additional Ratial Traits
    /// </summary>
    public TraitEnum[]? Traits { get; set; }

    /// <summary>
    /// Contructor
    /// </summary>
    [SetsRequiredMembers]
    public RaceTemplate()
    {
    }
}
