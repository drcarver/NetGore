using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.CodeGenerator.CodeGen;

public partial class GenerateHtml : IGenerateHtml
{
    /// <summary>
    /// Generate the .html for the class
    /// </summary>
    /// <param name="writer">The StreamWriter stream</param>
    /// <param name="creature">The creature</param>
    public void GenerateMonsterHtmlFiles(StreamWriter writer, ICreature creature)
    {
        // Convert the MarkDown file to .html
        GenerateMonsterHtmlHeader(writer, creature);
        GenerateMonsterHtmlBody(writer, creature);
        GenerateMonsterHtmlEnd(writer, creature);
    }

    /// <summary>
    /// Write the end of the .html file
    /// </summary>
    /// <param name="stream">The output stream</param>
    private void GenerateMonsterHtmlEnd(TextWriter stream, ICreature creature)
    {
        stream.WriteLine("</HTML>");
    }

    /// <summary>
    /// Generate the body of the .html file 
    /// </summary>
    /// <param name="stream">The .html file</param>
    /// <param name="stream">The creature</param>
    private void GenerateMonsterHtmlBody(TextWriter stream, ICreature creature)
    {
        stream.WriteLine("\t<BODY>");
        stream.WriteLine($"\t<h1>{creature.ProperName}</h1>");
        GenerateMonsterOverview(stream, creature);
        GenerateMonsterMainStats(stream, creature);
        GenerateMonsterAbilities(stream, creature);
        stream.WriteLine("\t</BODY>");
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
    /// The .html header
    /// </summary>
    /// <param name="stream">The TextWriter</param>
    private void GenerateMonsterHtmlHeader(TextWriter stream, ICreature creature)
    {
        stream.WriteLine("<!DOCTYPE html>");
        stream.WriteLine("<html>");
        stream.WriteLine("<head>");
        stream.WriteLine($"\t<title>{creature.ProperName}</title>");
        stream.WriteLine();
        stream.WriteLine($"\t<style>");
        stream.WriteLine($"\t/* Separate border for the table */");
        stream.WriteLine("\ttable {");
        stream.WriteLine($"\t\tborder-collapse: separate; /* Separate borders */");
        stream.WriteLine("\t}");
        stream.WriteLine();
        stream.WriteLine("\tth, td {");
        stream.WriteLine("\t\tborder-color: black;");
        stream.WriteLine("\t\tbackground-color: bisque;");
        stream.WriteLine("\t}");
        stream.WriteLine();
        stream.WriteLine("\tbody {");
        stream.WriteLine("\t\tbackground-color: antiquewhite;");
        stream.WriteLine("\t}");
        stream.WriteLine("\t</style>");
        stream.WriteLine("</head>");
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
