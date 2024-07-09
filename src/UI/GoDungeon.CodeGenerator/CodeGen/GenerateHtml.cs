using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.CodeGenerator.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.CodeGenerator.CodeGen;

public partial class GenerateHtml : IGenerateHtml
{
    /// <summary>
    /// Generate the .html for the for the parse models
    /// </summary>
    /// <param name="outputDir">The output directory</param>
    /// <param name="parseMarkdown">The Parse models</param>
    public void GenerateHtmlFiles(string outputDir, IParseMarkdown parseMarkdown)
    {
        foreach (var models in parseMarkdown.CodeGenModels.Values)
        {
            foreach (var codeGenModel in models)
            {
                var routeInfo = new FileInfo(codeGenModel.ParseModel.Route);
                var fPath = $@"{outputDir}html/{codeGenModel.ParseModel.Route}.html";
                var fileInfo = new FileInfo(fPath);
                Directory.CreateDirectory(fileInfo.DirectoryName);
                using (var stream = File.CreateText(fPath))
                {
                    GenerateHtmlHeader(stream, codeGenModel);
                    GenerateHtmlBody(stream, codeGenModel);
                }
            }
        }
    }

    /// <summary>
    /// Generate the body of the .html file 
    /// </summary>
    /// <param name="stream">The .html file</param>
    /// <param name="codeGenModel">The code generation model</param>
    private void GenerateHtmlBody(TextWriter stream, ICodeGen codeGenModel)
    {
        stream.WriteLine("\t<body>");
        stream.WriteLine("\t\t<div id=\"page-content\">");
        foreach (var line in codeGenModel.ParseModel.MarkDownHtml)
        {
            stream.WriteLine($"\t\t\t{line}");
        }
        stream.WriteLine("\t\t</div>");
        stream.WriteLine("\t\t<footer>");
        stream.WriteLine("\t\t\t<hr>");
        stream.WriteLine("\t\t\t<div style=\"text-align: center; padding-left: 1em; padding-right: 1em;\">");
        stream.WriteLine("\t\t\t\t<p>This work includes material taken from the System Reference Document 5.1 (“SRD 5.1”) by Wizards of the Coast LLC which is available <a href=\"https://dnd.wizards.com/resources/systems-reference-document\">here</a>. The SRD 5.1 is licensed under the Creative Commons Attribution 4.0 International License available at <a href=\"https://creativecommons.org/licenses/by/4.0/legalcode\">CC-BY-4.0</a>.</p>");
        stream.WriteLine("\t\t\t\t<p>Check out the <a href=\"https://github.com/vitusventure/5thSRD/\">GitHub repo</a> this code is based on.");
        stream.WriteLine("\t\t\t</div>");
        stream.WriteLine("\t\t</footer>");
        stream.WriteLine("\t</body>");
        stream.WriteLine("</html>");
    }

    /// <summary>
    /// The .html header
    /// </summary>
    /// <param name="stream">The .html file</param>
    /// <param name="codeGenModel">The code generation model</param>
    private void GenerateHtmlHeader(TextWriter stream, ICodeGen codeGenModel)
    {
        stream.WriteLine("<!DOCTYPE html>");
        stream.WriteLine("<html lang=\"en\">");
        stream.WriteLine("\t<head>");

        // Meta data links
        var spellCasters = string.Empty;
        if (codeGenModel.ParseModel.FileHeaders.Count == 4)
        {
            var spellvm = (SpellViewModel)codeGenModel;
            foreach (var caster in spellvm.CharacterClassList)
            {
                spellCasters += caster + ",";
            }
            spellCasters = spellCasters.Substring(0, spellCasters.LastIndexOf(","));
        }
        string description = string.Empty;
        for (var i = 0; i < codeGenModel.ParseModel.FileHeaders.Count; i++) 
        {
            var meta = codeGenModel.ParseModel.FileHeaders[i];
            if (meta.StartsWith("description:"))
            {
                var rulesVM = (RulesViewModel) codeGenModel;
                description = meta.Replace("description:", string.Empty).Trim();
                rulesVM.Description = description;
                codeGenModel.ParseModel.FileHeaders[i] = $"description: {meta}";
            }
            stream.Write("\t\t<metadata ");
            if (spellCasters != string.Empty && meta.StartsWith("classes:"))
            {
                stream.Write($"name=\"classses\" ");
                stream.Write($"content=\"{spellCasters}\"");
            }
            else
            {
                stream.Write($"name=\"{meta.Substring(0, meta.IndexOf(":"))}\" ");
                stream.Write($"content=\"{meta.Substring(meta.IndexOf(":") + 1).Trim()}\"");
            }
            stream.WriteLine(">");
        }
        stream.WriteLine();
        stream.WriteLine($"\t\t<meta name=\"og:title\" content=\"{codeGenModel.ProperName.Trim()}\">");
        stream.WriteLine($"\t\t<meta name=\"og:url\" content=\"{codeGenModel.ParseModel.Route.Replace("md", "html").Trim()}\">");
        if (description != string.Empty)
        {
            stream.WriteLine($"\t\t<meta name=\"og:description\" content=\"{description}\">");
        }
        if (codeGenModel is MagicItemViewModel)
        {
            stream.WriteLine($"\t\t<meta name=\"og:type\" content=\"{((MagicItemViewModel)codeGenModel).ItemType}\">");
        }
        stream.WriteLine();
        stream.WriteLine($"\t\t<title>{codeGenModel.ProperName.Trim()}</title>");
        stream.WriteLine();
        GenerateHtmlStyle(stream);
        stream.WriteLine("\t</head>");
    }

    /// <summary>
    /// Generate the style for the web page
    /// </summary>
    /// <param name="stream">Generate the style block for the header</param>
    private void GenerateHtmlStyle(TextWriter stream)
    {
        stream.WriteLine("\t\t<style>");

        #region Table Styles
        stream.WriteLine("\t\t\t.pure-table");
        stream.WriteLine("\t\t\t{");
        stream.WriteLine("\t\t\t\tborder-collapse: collapse;");
        stream.WriteLine("\t\t\t\tborder-spacing: 0;");
        stream.WriteLine("\t\t\t\tempty-cells: hide");
        stream.WriteLine("\t\t\t\tborder: 1px solid #cbcbcb");
        stream.WriteLine("\t\t\t}");
        stream.WriteLine();
        stream.WriteLine("\t\t\t.pure-table td, .pure-table th");
        stream.WriteLine("\t\t\t{");
        stream.WriteLine("\t\t\t\tborder-left: 1px solid #cbcbcb;");
        stream.WriteLine("\t\t\t\tborder-width: 0 0 0 1px;");
        stream.WriteLine("\t\t\t\tfont-size: inherit;");
        stream.WriteLine("\t\t\t\tmargin: 0;");
        stream.WriteLine("\t\t\t\toverflow: hidden;");
        stream.WriteLine("\t\t\t\tpadding: .5em 1em");
        stream.WriteLine("\t\t\t}");
        stream.WriteLine();
        stream.WriteLine("\t\t\t.pure-table thead ");
        stream.WriteLine("\t\t\t{");
        stream.WriteLine("\t\t\t\tbackground-color: #e0e0e0;");
        stream.WriteLine("\t\t\t\tcolor: #000;");
        stream.WriteLine("\t\t\t\ttext-align: left;");
        stream.WriteLine("\t\t\t\tvertical-align: bottom");
        stream.WriteLine("\t\t\t}");
        stream.WriteLine();
        stream.WriteLine("\t\t\t.pure-table td");
        stream.WriteLine("\t\t\t{");
        stream.WriteLine("\t\t\t\tbackground-color: antiquewhite");
        stream.WriteLine("\t\t\t}");
        #endregion

        #region Body Styles
        stream.WriteLine();
        stream.WriteLine("\t\t\tbody");
        stream.WriteLine("\t\t\t{");
        stream.WriteLine("\t\t\t\tmargin: 0");
        stream.WriteLine("\t\t\tbackground-color: antiquewhite;");
        stream.WriteLine("\t\t\t}");
        stream.WriteLine();
        stream.WriteLine("\t\t\thtml");
        stream.WriteLine("\t\t\t{");
        stream.WriteLine("\t\t\t\tline-height: 1.15;");
        stream.WriteLine("\t\t\t\tbackground-color: antiquewhite;");
        stream.WriteLine("\t\t\t\t-webkit-text-size-adjust: 100%");
        stream.WriteLine("\t\t\t}");
        #endregion

        stream.WriteLine("\t\t</style>");
    }

    private void GenerateMonsterMainStats(TextWriter stream, ICreature creature)
    {
        stream.WriteLine("\t\t<p>");
        stream.WriteLine("\t\t<table>");
        stream.WriteLine($"\t\t\t<tr><td style=\"text-align: left;\"><b>Armor Class</td><td>{creature.ArmorClass.AC(Core.Enum.AttackTypeEnum.Mele)}<b></td></tr>");
        stream.WriteLine($"\t\t\t<tr><td style=\"text-align: left;\"><b>Hit Points</td><td>{creature.HitPoints.HP()} ({creature.HitPoints.HitDice})<b></td></tr>");
        stream.Write($"\t\t\t<tr><td style=\"text-align: left;\"><b>Speed</td><td>");
        for (int i = 0; i < creature.Speed.Count(); i++)
        {
            if (creature.Speed[i].MovementType != MovementEnum.Normal)
            {
                stream.Write($"{creature.Speed[i].MovementType} ");
            }
            stream.Write($"{creature.Speed[i].Speed} {creature.Speed[i].MovementRate} ");
            if (creature.Speed[i].MovementModifier != string.Empty)
            {
                stream.Write($"{creature.Speed[i].MovementModifier}");
            }
            if (i != creature.Speed.Count() - 1)
            {
                stream.Write(", ");
            }
        }
        stream.WriteLine($"</td></tr>");
        stream.WriteLine("\t\t</table>");
        stream.WriteLine("\t\t</p>");
    }

    /// <summary>
    /// Generate the abilities table
    /// </summary>
    /// <param name="stream"></param>
    private void GenerateMonsterAbilities(TextWriter stream, ICreature creature)
    {
        stream.WriteLine();
        stream.WriteLine("\t\t<!-- Abilities Table --->");
        stream.WriteLine("\t\t<h3>Abilities</h3>");
        stream.WriteLine("\t\t<table>");
        stream.WriteLine("\t\t\t<col />");
        stream.WriteLine("\t\t\t<colgroup colspan=\"2\"></colgroup>");
        stream.WriteLine("\t\t\t<tr>");
        stream.WriteLine($"\t\t\t<th style=\"text-align: center;\" colspan=\"2\" scope=\"colgroup\">{creature.Strength.Name}</th>");
        stream.WriteLine($"\t\t\t<th style=\"text-align: center;\" colspan=\"2\" scope=\"colgroup\">{creature.Intelligence.Name}</th>");
        stream.WriteLine($"\t\t\t<th style=\"text-align: center;\" colspan=\"2\" scope=\"colgroup\">{creature.Wisdom.Name}</th>");
        stream.WriteLine($"\t\t\t<th style=\"text-align: center;\" colspan=\"2\" scope=\"colgroup\">{creature.Dexterity.Name}</th>");
        stream.WriteLine($"\t\t\t<th style=\"text-align: center;\" colspan=\"2\" scope=\"colgroup\">{creature.Constitution.Name}</th>");
        stream.WriteLine($"\t\t\t<th style=\"text-align: center;\" colspan=\"2\" scope=\"colgroup\">{creature.Charisma.Name}</th>");
        stream.WriteLine("\t\t\t</tr>");
        stream.WriteLine("\t\t\t<tr>");
        stream.WriteLine("\t\t\t<th style=\"text-align: center;\"scope=\" col\">Score</th>");
        stream.WriteLine("\t\t\t<th style=\"text-align: center;\" scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t<th style=\"text-align: center;\" scope=\"col\">Score</th>");
        stream.WriteLine("\t\t\t<th style=\"text-align: center;\" scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t<th style=\"text-align: center;\" scope=\"col\">Score</th>");
        stream.WriteLine("\t\t\t<th style=\"text-align: center;\" scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t<th style=\"text-align: center;\" scope=\"col\">Score</th>");
        stream.WriteLine("\t\t\t<th style=\"text-align: center;\" scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t<th style=\"text-align: center;\" scope=\"col\">Score</th>");
        stream.WriteLine("\t\t\t<th style=\"text-align: center;\" scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t<th style=\"text-align: center;\" scope=\"col\">Score</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t</tr>");
        stream.WriteLine("\t\t\t<tr>");
        var plusSign = creature.Strength.AbilityBonus > 0 ? "+" : string.Empty;
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{creature.Strength.Score}</td>");
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{plusSign}{creature.Strength.AbilityBonus}</td>");
        plusSign = creature.Intelligence.AbilityBonus > 0 ? "+" : string.Empty;
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{creature.Intelligence.Score}</td>");
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{plusSign}{creature.Intelligence.AbilityBonus}</td>");
        plusSign = creature.Wisdom.AbilityBonus > 0 ? "+" : string.Empty;
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{creature.Wisdom.Score}</td>");
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{plusSign}{creature.Wisdom.AbilityBonus}</td>");
        plusSign = creature.Dexterity.AbilityBonus > 0 ? "+" : string.Empty;
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{creature.Dexterity.Score}</td>");
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{plusSign}{creature.Dexterity.AbilityBonus}</td>");
        plusSign = creature.Constitution.AbilityBonus > 0 ? "+" : string.Empty;
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{creature.Constitution.Score}</td>");
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{plusSign}{creature.Constitution.AbilityBonus}</td>");
        plusSign = creature.Charisma.AbilityBonus > 0 ? "+" : string.Empty;
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{creature.Charisma.Score}</td>");
        stream.WriteLine($"\t\t\t<td style=\"text-align: center;\">{plusSign}{creature.Charisma.AbilityBonus}</td>");
        stream.WriteLine("\t\t\t</tr>");
        stream.WriteLine("\t\t</table>");
    }

    /// <summary>
    /// Generate the overview section at the top of the file
    /// </summary>
    /// <param name="stream"></param>
    private void GenerateMonsterOverview(TextWriter stream, ICreature creature)
    {
        stream.WriteLine();
        stream.Write($"<i>{creature.Size}");
        stream.Write($" {creature.RaceType}");
        if (creature.RaceSubType != null && creature.RaceSubType.Any())
        {
            stream.Write($" (");
            string rawRaceSubtype = string.Empty;
            foreach (var raceSubType in creature.RaceSubType)
            {
                if (rawRaceSubtype != string.Empty)
                {
                    rawRaceSubtype += ", ";
                }
                rawRaceSubtype += raceSubType.ToString();
            }
            stream.Write($"{rawRaceSubtype})");
        }
        switch (creature.Alignment)
        {
            case Core.Enum.AlignmentEnum.UnAligned:
                stream.Write($", Unaligned");
                break;
            case Core.Enum.AlignmentEnum.NonAligned:
                stream.Write($", Non aligned");
                break;
            case Core.Enum.AlignmentEnum.Any:
                stream.Write($", Any Alignment");
                break;
            case Core.Enum.AlignmentEnum.AnyChaotic:
                stream.Write($", Any chaotic");
                break;
            case Core.Enum.AlignmentEnum.AnyEvil:
                stream.Write($", Any evil");
                break;
            case Core.Enum.AlignmentEnum.AnyLawful:
                stream.Write($", Any lawful");
                break;
            case Core.Enum.AlignmentEnum.AnyNonGood:
                stream.Write($", Any non good");
                break;
            case Core.Enum.AlignmentEnum.AnyNonLawful:
                stream.Write($", Any non lawful");
                break;
            case Core.Enum.AlignmentEnum.NeutralGoodOrNeutralEvil:
                stream.Write($", Neutral good (50%) or Neutral Evil (50%)");
                break;
            case Core.Enum.AlignmentEnum.NeutralEvil:
                stream.Write($", Neutral Evil (NE)");
                break;
            case Core.Enum.AlignmentEnum.ChaoticEvil:
                stream.Write($", Chaotic Evil (CE)");
                break;
            case Core.Enum.AlignmentEnum.LawfulEvil:
                stream.Write($", Lawful Evil (LE)");
                break;
            case Core.Enum.AlignmentEnum.ChaoticNeutral:
                stream.Write($", Chaotic Neutral (CN)");
                break;
            case Core.Enum.AlignmentEnum.LawfulNeutral:
                stream.Write($", Lawful Neutral (LN)");
                break;
            case Core.Enum.AlignmentEnum.Neutral:
                stream.Write($", Neutral (N)");
                break;
            case Core.Enum.AlignmentEnum.ChaoticGood:
                stream.Write($", Chaotic Good (CG)");
                break;
            case Core.Enum.AlignmentEnum.LawfulGood:
                stream.Write($", Lawful Good (LG)");
                break;
            case Core.Enum.AlignmentEnum.NeutralGood:
                stream.Write($", Neutral Good (NG)");
                break;
        }
        stream.WriteLine("</i>");
    }
}
