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
        ISpellTableEntry? spell = null;
        foreach (var line in markDown)
        {
            if (line.StartsWith("**Casting Time:**"))
            {
                spell = new SpellTableEntryViewModel();
            }
        }
        if (spell == null)
        {
            return null;
        }
        GetSpellInfo(markDown, spell);
        spell.CastingTime = GetSpellDuration(markDown, spell);
        spell.SpellRange = GetSpellRange(markDown, spell);
        SpellInfoList.Add(spell);
        return spell;
    }

    /// <summary>
    /// Compute the range of the spell
    /// </summary>
    /// <returns>The height (range) of the spell</returns>
    private ISpellRange GetSpellRange(List<string> markDown, ISpellTableEntry spell)
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
    private ICastingTime GetSpellDuration(List<string> markDown, ISpellTableEntry? spell)
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
    /// <param name="spell">The spellInfo</param>
    private void GetSpellInfo(List<string> markDown, ISpellTableEntry? spell)
    {
        for (int i = 0; i < markDown.Count; i++)
        {
            if (markDown[i].StartsWith("name:"))
            {
                var name = markDown[i].Replace("name:", string.Empty).Trim();
                spell.ProperName = name;
                spell.Name = Utilities.CleanupForCSharp(name);
            }
            if (markDown[i].StartsWith("level:"))
            {
                var level = markDown[i].Replace("level:", string.Empty).Trim();
                int levelnum = 0;
                int.TryParse(level, out levelnum);
                spell.Level = levelnum;
            }
            if (markDown[i].StartsWith("school:"))
            {
                var school = markDown[i].Replace("school:", string.Empty).Trim();
                MagicSchoolEnum magicEnum;
                if (!Enum.TryParse<MagicSchoolEnum>(school, true, out magicEnum))
                {
                    Debug.WriteLine($"Magic School is {school}");
                }
            }
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
                }
                while (!markDown[i].Trim().StartsWith("**Casting Time:**"));
                break;
            }
        }
        int j = 0;
        do
        {
            if (markDown[0].Trim().StartsWith("**Casting Time:**"))
            {
                break;
            }
            markDown.RemoveAt(0);
            j++;
        } while (j < markDown.Count());
    }
}
