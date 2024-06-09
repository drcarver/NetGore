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
    public List<SpellInfoViewModel> SpellInfoList { get; set; } = new List<SpellInfoViewModel>();

    /// <summary>
    /// The input root directory
    /// </summary>
    public string? RootDirectory { get; set; }

    /// <summary>
    /// Get the spell from the markDown file
    /// </summary>
    public ISpell ParseSpell(List<string> markDown)
    {
        var spell = new SpellInfoViewModel();
        GetSpellInfo(markDown, spell);
        SpellInfoList.Add(spell);
        return spell;
    }

    /// <summary>
    /// Get Spell Info
    /// </summary>
    /// <param name="markDown">The markDown file for the spell</param>
    /// <param name="spell">The spellInfo</param>
    private void GetSpellInfo(List<string> markDown, SpellInfoViewModel spell)
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
            if (markDown[i].StartsWith("classes:"))
            {
                markDown[i] = markDown[i].Replace("classes:", string.Empty).Trim();
                ClassEnum classEnum;
                do
                {
                    var classes = markDown[i].Trim();
                    if (!string.IsNullOrEmpty(classes))
                    {
                        break;
                    }
                    if (!Enum.TryParse<ClassEnum>(classes, true, out classEnum))
                    {
                        Debug.WriteLine($"Class is {classes}");
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
