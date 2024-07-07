using System.Collections.ObjectModel;
using System.Diagnostics;

using GoDungeon.CodeGenerator.CodeGen;
using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.Core.Enum;
using GoDungeon.Spells.Enum;
using GoDungeon.Spells.Interfaces;
using GoDungeon.Spells.ViewModels;

namespace GoDungeon.CommandLineTools.CodeGen;

public partial class ParseMarkdown : IParseMarkdown
{
    /// <summary>
    /// The spell list
    /// </summary>
    public List<ISpellTableEntry> SpellInfoList { get; set; } = new List<ISpellTableEntry>();

    /// <summary>
    /// The input root directory
    /// </summary>
    public string? RootDirectory { get; set; }

    /// <summary>
    /// Get the spell from the markDown file
    /// </summary>
    public ISpellTableEntry? ParseSpell(List<string> markDown)
    {
        ISpellTableEntry? spell = GetSpellInfo(markDown);
        spell.CastingTime = GetSpellCastingTime(markDown);
        spell.SpellRange = GetSpellRange(markDown);
        spell.SpellComponents = GetSpellComponents(markDown);
        spell.SpellDuration = GetSpellDuration(markDown);
        spell.SpellDescriptions = GetSpellDescriptions(markDown);
        SpellInfoList.Add(spell);
        return spell;
    }

    /// <summary>
    /// The descriptions of the spell
    /// </summary>
    /// <param name="markDown">The markdown rows</param>
    /// <returns>The collection spell description</returns>
    private ObservableCollection<string> GetSpellDescriptions(List<string> markDown)
    {
        ObservableCollection<string> spellDescriptions = new ObservableCollection<string>();
        foreach (string line in markDown)
        {
            if (string.IsNullOrEmpty(line.Trim()))
            {
                continue;   
            }
            while (line.Trim().Contains("**"))
            {

            }

            spellDescriptions.Add(line.Trim());
        }
        return spellDescriptions;
    }

    /// <summary>
    /// Get the spell duration
    /// </summary>
    /// <param name="markDown">The markdown rows</param>
    /// <returns>return the spell duration</returns>
    private ISpellDuration GetSpellDuration(List<string> markDown)
    {
        ISpellDuration spellDuration = new SpellDurationViewModel();
        foreach (var line in markDown)
        {
            if (line.StartsWith("**Duration:**"))
            {
                var cleanedString = line.Replace("**Duration:**", string.Empty).ToLower().Trim();
                if (cleanedString.StartsWith("concentration,"))
                {
                    spellDuration.Concentration = true;
                    cleanedString = cleanedString.Replace("concentration,", string.Empty).Trim();
                }
                if (cleanedString.Contains("up to"))
                {
                    spellDuration.UpToo = true;
                    cleanedString = cleanedString.Replace("up to", string.Empty).Trim();
                }
                switch (cleanedString.Trim())
                {
                    case "instantaneous":
                        spellDuration.SpellDurationUnits = SpellDurationUnitsEnum.Instantaneous;
                        break;
                    case "until dispelled":
                        spellDuration.SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelled;
                        break;
                    case "until dispelled or triggered":
                        spellDuration.SpellDurationUnits = SpellDurationUnitsEnum.UntilDispelledorTriggered;
                        break;
                    case "special":
                        spellDuration.SpellDurationUnits = SpellDurationUnitsEnum.Special;
                        break;
                    default:
                        string[] hours = cleanedString.Split(' ');
                        if (hours.Length != 2)
                        {
                            break;
                        }
                        int timescale;
                        if (int.TryParse(hours[0], out timescale))
                        {
                            spellDuration.SpellDuration = timescale;
                        }
                        SpellDurationUnitsEnum duration;
                        if (Enum.TryParse(hours[1], true, out duration))
                        {
                            spellDuration.SpellDurationUnits = duration;
                        }
                        else
                        {
                            Debug.WriteLine($"Unknown duration unit {hours[1]}");
                        }
                        break;
                }
                markDown.RemoveAt(0);
                break;
            }
        }
        return spellDuration;
    }

    /// <summary>
    /// Get the spell component
    /// </summary>
    /// <param name="markDown">The markdown rows</param>
    /// <returns>return the spell component</returns>
    private ISpellComponent? GetSpellComponents(List<string> markDown)
    {
        ISpellComponent? spellComponent = new SpellComponentViewModel();
        foreach (var line in markDown)
        {
            if (line.StartsWith("**Components:**"))
            {
                var cleanedString = line.Replace("**Components:**", string.Empty).Trim();
                int lParen = cleanedString.IndexOf('(');
                int rParen = cleanedString.IndexOf(')');
                string[] rawSpellComponent;
                if (lParen > 0)
                {
                    var substring = cleanedString.Substring(0, lParen);
                    rawSpellComponent = substring.Split(',');
                }
                else
                {
                    rawSpellComponent = line.Replace("**Components:**", string.Empty).Trim().Split(',');
                }
                for (int i = 0; i < rawSpellComponent.Length; i++)
                {
                    switch (rawSpellComponent[i].Trim())
                    {
                        case "V":
                            spellComponent.Verbal = true;
                            break;
                        case "S":
                            spellComponent.Somatic = true;
                            break;
                        case "M":
                            spellComponent.Material = true;
                            if (lParen >= 0 && rParen >= 0)
                            {
                                spellComponent.MaterialComponents = cleanedString.Substring(lParen + 1, rParen - lParen - 1).Trim();
                            }
                            break;
                    }
                }
                markDown.RemoveAt(0);
            }
            break;
        }
        return spellComponent;
    }

    /// <summary>
    /// Compute the range of the spell
    /// </summary>
    /// <returns>The range of the spell</returns>
    private ISpellRange GetSpellRange(List<string> markDown)
    {
        int i = 0;
        var spellRange = new SpellRangeViewModel();
        foreach (var line in markDown)
        {
            if (line.StartsWith("**Range:**"))
            {
                var rawSpellRange = line.Replace("**Range:**", string.Empty).Trim();
                spellRange.RangeType = SpellDistanceTypeEnum.Ranged;
                switch (rawSpellRange.Trim())
                {
                    case "Self (10-foot radius)":
                        spellRange.Unit = 10;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Radius;
                        break;
                    case "Self (10-foot-radius sphere)":
                        spellRange.Unit = 10;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Sphere;
                        break;
                    case "Self (15-foot cone)":
                        spellRange.Unit = 15;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Cone;
                        break;
                    case "Self (60-foot cone)":
                        spellRange.Unit = 60;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Cone;
                        break;
                    case "Self (30-foot cone)":
                        spellRange.Unit = 30;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Cone;
                        break;
                    case "Self (5-mile radius)":
                        spellRange.Unit = 5;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Mile;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Radius;
                        break;
                    case "Self (30-foot radius)":
                        spellRange.Unit = 30;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Radius;
                        break;
                    case "Self (15-foot radius)":
                        spellRange.Unit = 15;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Radius;
                        break;
                    case "Self (60-foot line)":
                        spellRange.Unit = 60;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Line;
                        break;
                    case "Self (100-foot line)":
                        spellRange.Unit = 100;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Line;
                        break;
                    case "Self (15-foot cube)":
                        spellRange.Unit = 15;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Cube;
                        break;
                    case "Self (10-foot-radius hemisphere)":
                        spellRange.Unit = 10;
                        spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Hemisphere;
                        break;
                    case "Special":
                        spellRange.Unit = 0;
                        spellRange.RangeType = SpellDistanceTypeEnum.Special;
                        spellRange.DistanceType = SpellDistanceEnum.Special;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Special;
                        break;
                    case "Sight":
                        spellRange.Unit = 0;
                        spellRange.RangeType = SpellDistanceTypeEnum.Sight;
                        spellRange.DistanceType = SpellDistanceEnum.Sight;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Sight;
                        break;
                    case "Unlimited":
                        spellRange.Unit = 0;
                        spellRange.RangeType = SpellDistanceTypeEnum.Unlimited;
                        spellRange.DistanceType = SpellDistanceEnum.Unlimited;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Unlimited;
                        break;
                    case "Self":
                    case "Touch":
                        spellRange.Unit = 0;
                        if (rawSpellRange == "Touch")
                        {
                            spellRange.RangeType = SpellDistanceTypeEnum.Touch;
                        }
                        else
                        {
                            spellRange.RangeType = SpellDistanceTypeEnum.Self;
                        }
                        spellRange.DistanceType = SpellDistanceEnum.Feet;
                        spellRange.SpellEffectType = SpellEffectTypeEnum.Creature;
                        break;
                    default:
                        int unit;
                        string[] spellRangeSplit = rawSpellRange.Split(' ');
                        if (spellRangeSplit.Length == 2)
                        {
                            if (int.TryParse(spellRangeSplit[0], out unit))
                            {
                                spellRange.Unit = unit;
                            }
                            SpellDistanceEnum spellDistance;
                            if (Enum.TryParse(spellRangeSplit[1], true, out spellDistance))
                            {
                                spellRange.DistanceType = spellDistance;
                            }
                            spellRange.SpellEffectType = SpellEffectTypeEnum.Location;
                            spellRange.DistanceType = SpellDistanceEnum.Feet;
                        }
                        break;
                }
                break;
            }
            i++;
        }
        if (i < markDown.Count())
        {
            markDown.RemoveAt(i);
        }
        else
        {
            Debug.WriteLine($"Invalid markDown position");
        }
        return spellRange;
    }

    /// <summary>
    /// Get Spell duration
    /// </summary>
    /// <param name="markDown">The markDown file for the spell</param>
    /// <param name="spell">The spellInfo</param>
    private ICastingTime GetSpellCastingTime(List<string> markDown)
    {
        int i = 0;
        CastingTimeViewModel castingTimeVM = new CastingTimeViewModel();
        foreach (var line in markDown)
        {
            if (line.StartsWith("**Casting Time:**"))
            {
                var fullDuration = line.Replace("**Casting Time:**", string.Empty).Trim().Split(' ');
                if (fullDuration.Length == 2)
                {
                    int time;
                    if (!int.TryParse(fullDuration[0], out time))
                    {
                        Debug.WriteLine($"Invalid casting time={fullDuration[0]}");
                    }
                    else
                    {
                        castingTimeVM.CastingTime = time;
                    }
                    DurationEnum durationType;
                    if (!Enum.TryParse<DurationEnum>(fullDuration[1], true, out durationType))
                    {
                        Debug.WriteLine($"Invalid casting duration={fullDuration[1]}");
                    }
                    else
                    {
                        castingTimeVM.Duration = durationType;
                    }
                }
                break;
            }
            i++;
        }
        if (i < markDown.Count())
        {
            markDown.RemoveAt(i);
        }
        else
        {
            Debug.WriteLine($"Invalid markDown position");
        }
        return castingTimeVM;
    }

    /// <summary>
    /// Get Spell Info
    /// </summary>
    /// <param name="markDown">The markDown file for the spell</param>
    private ISpellTableEntry GetSpellInfo(List<string> markDown)
    {
        var spell = new SpellTableEntryViewModel();
        GetSpellName(markDown, spell);
        GetSpellLevel(markDown, spell);
        GetSpellSchool(markDown, spell);
        GetSpellLevel(markDown, spell);
        GetSpellClasses(markDown, spell);

        // Skip forward to the casting time
        do
        {
            if (markDown[0].StartsWith("**Casting Time:**"))
            {
                break;
            }
            markDown.RemoveAt(0);
        } while (markDown.Count() > 0);

        return spell;
    }

    /// <summary>
    /// Get the Spell school
    /// </summary>
    /// <param name="markDown">The markdown file</param>
    /// <param name="spell">The spell view model</param>
    private void GetSpellClasses(List<string> markDown, SpellTableEntryViewModel spell)
    {
        int i = 0;
        if (markDown[i].StartsWith("classes: "))
        {
            markDown[i] = markDown[i].Replace("classes:", string.Empty).Trim();
            ClassEnum classEnum;
            do
            {
                var classes = markDown[i].Trim();
                if (string.IsNullOrEmpty(classes))
                {
                    break;
                }
                if (!Enum.TryParse<ClassEnum>(classes, true, out classEnum))
                {
                    Debug.WriteLine($"Class is {classes}");
                }
                else
                {
                    spell.Casters.Add(classEnum);
                }
                i++;
                markDown.RemoveAt(0);
            }
            while (!markDown[i].Trim().StartsWith("**Casting Time:**"));
        }
    }

    /// <summary>
    /// Get the Spell school
    /// </summary>
    /// <param name="markDown">The markdown file</param>
    /// <param name="spell">The spell view model</param>
    private void GetSpellSchool(List<string> markDown, SpellTableEntryViewModel spell)
    {
        int i = 0;
        do
        {
            if (markDown[i].StartsWith("school:"))
            {
                var school = markDown[i].Replace("school:", string.Empty).Trim();
                MagicSchoolEnum magicEnum;
                if (!Enum.TryParse<MagicSchoolEnum>(school, true, out magicEnum))
                {
                    Debug.WriteLine($"Magic School is {school}");
                }
                markDown.RemoveAt(i);
                return;
            }
            i++;
        }
        while (i < markDown.Count());
    }

    /// <summary>
    /// Get the Spell Level
    /// </summary>
    /// <param name="markDown">The markdown file</param>
    /// <param name="spell">The spell view model</param>
    private void GetSpellLevel(List<string> markDown, SpellTableEntryViewModel spell)
    {
        int i = 0;
        do
        {
            if (markDown[i].StartsWith("level:"))
            {
                var level = markDown[i].Replace("level:", string.Empty).Trim();
                int intLevel;
                if (int.TryParse(level, out intLevel))
                {
                    spell.Level = intLevel;
                }
                markDown.RemoveAt(i);
                return;
            }
            i++;
        }
        while (i < markDown.Count());
    }

    /// <summary>
    /// Get the Spell Name
    /// </summary>
    /// <param name="markDown">The markdown file</param>
    /// <param name="spell">The spell view model</param>
    private void GetSpellName(List<string> markDown, SpellTableEntryViewModel spell)
    {
        int i = 0;
        do
        {
            if (markDown[i].StartsWith("name:"))
            {
                var name = markDown[i].Replace("name:", string.Empty).Trim();
                spell.ProperName = name;
                spell.Name = Utilities.CleanupForCSharp(name);
                markDown.RemoveAt(i);
                return;
            }
            i++;
        }
        while (i < markDown.Count());
    }
}
