using NetGore.CharacterClasses.Enum;

namespace NetGore.CharacterClasses.Models;

public class ClassFeatureLevelEntry
{
    /// <summary>
    /// The class feature level
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The base proficiency for this level
    /// </summary>
    public int BaseProficiency {  get; set; }

    /// <summary>
    /// The class features
    /// </summary>
    public List<ClassFeatureEnum>? ClassFeatures { get; set; }
}
