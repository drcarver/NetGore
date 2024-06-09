using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.Spells.Interfaces;

namespace GoDungeon.CodeGenerator.CodeGen;

public partial class GenerateHtml : IGenerateHtml
{
    /// <summary>
    /// Generate the .html for the class
    /// </summary>
    /// <param name="writer">The StreamWriter stream</param>
    /// <param name="spell">The spell info file</param>
    public void GenerateSpellHtmlFiles(StreamWriter writer, ISpell spell)
    {
        // Convert the MarkDown file to .html
        GenerateSpellHtmlHeader(writer, spell);
        GenerateSpellHtmlBody(writer, spell);
        GenerateSpellHtmlEnd(writer, spell);
    }

    /// <summary>
    /// Write the end of the .html file
    /// </summary>
    /// <param name="stream">The output stream</param>
    private void GenerateSpellHtmlEnd(TextWriter stream, ISpell spell)
    {
        stream.WriteLine("</HTML>");
    }

    /// <summary>
    /// Generate the body of the .html file 
    /// </summary>
    /// <param name="stream">The .html file</param>
    /// <param name="stream">The creature</param>
    private void GenerateSpellHtmlBody(TextWriter stream, ISpell spell)
    {
        stream.WriteLine("\t<BODY>");
        stream.WriteLine($"\t<h1>{spell.ProperName}</h1>");
        GenerateSpellOverview(stream, spell);
        GenerateSpellMainStats(stream, spell);
        stream.WriteLine("\t</BODY>");
    }

    /// <summary>
    /// The spell 
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="spell"></param>
    private void GenerateSpellMainStats(TextWriter stream, ISpell spell)
    {
        stream.WriteLine("\t\t<p>");
        stream.WriteLine("\t\t<table>");
        stream.WriteLine($"<tr>");
        stream.WriteLine($"</tr>");
        stream.WriteLine("\t\t</table>");
        stream.WriteLine("\t\t</p>");
    }

    /// <summary>
    /// The .html header
    /// </summary>
    /// <param name="stream">The TextWriter</param>
    private void GenerateSpellHtmlHeader(TextWriter stream, ISpell spell)
    {
        stream.WriteLine("<!DOCTYPE html>");
        stream.WriteLine("<html>");
        stream.WriteLine("<head>");
        stream.WriteLine($"\t<title>{spell.ProperName}</title>");
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
    /// Generate the overview section at the top of the file
    /// </summary>
    /// <param name="stream"></param>
    private void GenerateSpellOverview(TextWriter stream, ISpell spell)
    {
    }
}
