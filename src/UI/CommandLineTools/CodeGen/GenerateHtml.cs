
using GoDungeon.Character.PC.Bard;
using GoDungeon.Core.Abilities;

using Syncfusion.DocIO.DLS;

namespace GoDungeon.CommandLineTools.CodeGen;

internal static class GenerateHtml
{
    /// <summary>
    /// Generate the .html for the class
    /// </summary>
    /// <param name="markDown">The markdown file as a series of strings</param>
    /// <param name="writer">The StreamWriter stream</param>
    /// <param name="classInfo">The ClassInfo file</param>
    internal static void GenerateHtmlFile(StreamWriter writer)
    {
        // Convert the MarkDown file to .html
        GenerateHtmlHeader(writer);
        GenerateHtmlBody(writer);
        GenerateHtmlEnd(writer);
    }

    /// <summary>
    /// Write the end of the .html file
    /// </summary>
    /// <param name="stream">The output stream</param>
    private static void GenerateHtmlEnd(TextWriter stream)
    {
        stream.WriteLine("</HTML>");
    }

    /// <summary>
    /// Generate the body of the .html file 
    /// </summary>
    /// <param name="htmlFile"></param>
    /// <param name="markdown"></param>
    /// <param name="stream"></param>
    private static void GenerateHtmlBody(TextWriter stream)
    {
        stream.WriteLine("\t<BODY>");
        stream.WriteLine($"\t<h1>{Program.Creature.ProperName}</h1>");
        GenerateAbilities(stream);
        stream.WriteLine("\t</BODY>");
    }

    /// <summary>
    /// The .html header
    /// </summary>
    /// <param name="stream">The TextWriter</param>
    private static void GenerateHtmlHeader(TextWriter stream)
    {
        stream.WriteLine("<!DOCTYPE html>");
        stream.WriteLine("<html>");
        stream.WriteLine("<head>");
        stream.WriteLine($"\t<title>{Program.Creature.ProperName}</title>");
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
        stream.WriteLine("\t\ttext-align: center;");
        stream.WriteLine("\t}");
        stream.WriteLine();
        stream.WriteLine("\tbody {");
        stream.WriteLine("\t\tbackground-color: antiquewhite;");
        stream.WriteLine("\t}");
        stream.WriteLine("\t</style>");
        stream.WriteLine("</head>");
    }

    /// <summary>
    /// Generate a .html header if the line is a header
    /// </summary>
    /// <param name="markdownLine">The markdown line</param>
    /// <param name="writer">The TextWriter</param>
    //private static void GenerateHtmlHeader(string markdownLine, TextWriter writer)
    //{
    //    if (string.IsNullOrEmpty(markdownLine) || !markdownLine.TrimStart().StartsWith("#"))
    //    {
    //        return;
    //    }

    //    char[] charArray = markdownLine.TrimStart().ToCharArray();
    //    if (markdownLine.TrimStart().StartsWith("######"))
    //    {
    //        var h6 = markdownLine.Replace("######", string.Empty).Trim();
    //        writer.WriteLine($"\t\t<h6>{h6}</h6>");
    //    }
    //    else if (markdownLine.TrimStart().StartsWith("#####"))
    //    {
    //        var h5 = markdownLine.Replace("#####", string.Empty).Trim();
    //        writer.WriteLine($"\t\t<h5>{h5}</h5>");
    //    }
    //    else if (markdownLine.TrimStart().StartsWith("####"))
    //    {
    //        var h4 = markdownLine.Replace("####", string.Empty).Trim();
    //        writer.WriteLine($"\t\t<h4>{h4}</h4>");
    //    }
    //    else if (markdownLine.TrimStart().StartsWith("###"))
    //    {
    //        var h3 = markdownLine.Replace("###", string.Empty).Trim();
    //        writer.WriteLine($"\t\t<h3>{h3}</h3>");
    //    }
    //    else if (markdownLine.TrimStart().StartsWith("##"))
    //    {
    //        var h2 = markdownLine.Replace("##", string.Empty).Trim();
    //        writer.WriteLine($"\t\t<h2>{h2}</h2>");
    //    }
    //    else if (markdownLine.TrimStart().StartsWith("#"))
    //    {
    //        Program.Creature.ProperName = markdownLine.Replace("#", string.Empty).Trim();
    //        writer.WriteLine($"\t\t<h1>{Program.Creature.ProperName}</h1>");
    //    }
    //}

    /// <summary>
    /// Generate the abilities table
    /// </summary>
    /// <param name="stream"></param>
    private static void GenerateAbilities(TextWriter stream)
    {
        stream.WriteLine();
        stream.WriteLine("\t\t<!-- Abilities Table --->");
        stream.WriteLine("\t\t<h3>Abilities</h3>");
        stream.WriteLine("\t\t<table>");
        stream.WriteLine("\t\t\t<col />");
        stream.WriteLine("\t\t\t<colgroup span=\"2\"></colgroup>");
        stream.WriteLine("\t\t\t<tr>");
        stream.WriteLine($"\t\t\t<th colspan=\"2\" scope=\"colgroup\">{Program.Creature.Strength.Name}</th>");
        stream.WriteLine($"\t\t\t<th colspan=\"2\" scope=\"colgroup\">{Program.Creature.Intelligence.Name}</th>");
        stream.WriteLine($"\t\t\t<th colspan=\"2\" scope=\"colgroup\">{Program.Creature.Wisdom.Name}</th>");
        stream.WriteLine($"\t\t\t<th colspan=\"2\" scope=\"colgroup\">{Program.Creature.Dexterity.Name} </th>");
        stream.WriteLine($"\t\t\t<th colspan=\"2\" scope=\"colgroup\">{Program.Creature.Constitution.Name} </th>");
        stream.WriteLine($"\t\t\t<th colspan=\"2\" scope=\"colgroup\">{Program.Creature.Charisma.Name} </th>");
        stream.WriteLine("\t\t\t</tr>");
        stream.WriteLine("\t\t\t<tr>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Score</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Score</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Score</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Score</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Score</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Score</th>");
        stream.WriteLine("\t\t\t<th scope=\"col\">Modifier</th>");
        stream.WriteLine("\t\t\t</tr>");
        stream.WriteLine("\t\t\t<tr>");
        var plusSign = Program.Creature.Strength.AbilityBonus > 0 ? "+" : "-";
        stream.WriteLine($"\t\t\t<td>{Program.Creature.Strength.Score}</td>");
        stream.WriteLine($"\t\t\t<td>{plusSign}{Program.Creature.Strength.AbilityBonus}</td>");
        plusSign = Program.Creature.Intelligence.AbilityBonus > 0 ? "+" : "-";
        stream.WriteLine($"\t\t\t<td>{Program.Creature.Intelligence.Score}</td>");
        stream.WriteLine($"\t\t\t<td>{plusSign}{Program.Creature.Intelligence.AbilityBonus}</td>");
        plusSign = Program.Creature.Wisdom.AbilityBonus > 0 ? "+" : "-";
        stream.WriteLine($"\t\t\t<td>{Program.Creature.Wisdom.Score}</td>");
        stream.WriteLine($"\t\t\t<td>{plusSign}{Program.Creature.Wisdom.AbilityBonus}</td>");
        plusSign = Program.Creature.Dexterity.AbilityBonus > 0 ? "+" : "-";
        stream.WriteLine($"\t\t\t<td>{Program.Creature.Dexterity.Score}</td>");
        stream.WriteLine($"\t\t\t<td>{plusSign}{Program.Creature.Dexterity.AbilityBonus}</td>");
        plusSign = Program.Creature.Constitution.AbilityBonus > 0 ? "+" : "-";
        stream.WriteLine($"\t\t\t<td>{Program.Creature.Constitution.Score}</td>");
        stream.WriteLine($"\t\t\t<td>{plusSign}{Program.Creature.Constitution.AbilityBonus}</td>");
        plusSign = Program.Creature.Charisma.AbilityBonus > 0 ? "+" : "-";
        stream.WriteLine($"\t\t\t<td>{Program.Creature.Charisma.Score}</td>");
        stream.WriteLine($"\t\t\t<td>{plusSign}{Program.Creature.Charisma.AbilityBonus}</td>");
        stream.WriteLine("\t\t\t</tr>");
        stream.WriteLine("\t\t</table>");
    }
}
