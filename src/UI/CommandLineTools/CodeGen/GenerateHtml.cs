namespace GoDungeon.CommandLineTools.CodeGen;

internal static class GenerateHtml
{
    /// <summary>
    /// Generate the .html for the class
    /// </summary>
    /// <param name="markDown">The markdown file as a series of strings</param>
    /// <param name="writer">The StreamWriter stream</param>
    /// <param name="classInfo">The ClassInfo file</param>
    internal static void GenerateHtmlFile(List<string> markDown, StreamWriter writer)
    {
        // Convert the MarkDown file to .html
        GenerateHtmlHeader(writer);
        GenerateHtmlBody(markDown, writer);
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
    private static void GenerateHtmlBody(List<string> markdown, TextWriter stream)
    {
        stream.WriteLine("\t<BODY>");
        int i = 0;
        do
        {
            GenerateHtmlHeader(markdown[i], stream);
            i++;
        } while (i < markdown.Count());
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
        stream.WriteLine("</head>");
    }

    /// <summary>
    /// Generate a .html header if the line is a header
    /// </summary>
    /// <param name="markdownLine">The markdown line</param>
    /// <param name="writer">The TextWriter</param>
    private static void GenerateHtmlHeader(string markdownLine, TextWriter writer)
    {
        if (string.IsNullOrEmpty(markdownLine) || !markdownLine.TrimStart().StartsWith("#"))
        {
            return;
        }

        char[] charArray = markdownLine.TrimStart().ToCharArray();
        if (markdownLine.TrimStart().StartsWith("######"))
        {
            var h6 = markdownLine.Replace("######", string.Empty).Trim();
            writer.WriteLine($"\t\t<h6>{h6}</h6>");
        }
        else if (markdownLine.TrimStart().StartsWith("#####"))
        {
            var h5 = markdownLine.Replace("#####", string.Empty).Trim();
            writer.WriteLine($"\t\t<h5>{h5}</h5>");
        }
        else if (markdownLine.TrimStart().StartsWith("####"))
        {
            var h4 = markdownLine.Replace("####", string.Empty).Trim();
            writer.WriteLine($"\t\t<h4>{h4}</h4>");
        }
        else if (markdownLine.TrimStart().StartsWith("###"))
        {
            var h3 = markdownLine.Replace("###", string.Empty).Trim();
            writer.WriteLine($"\t\t<h3>{h3}</h3>");
        }
        else if (markdownLine.TrimStart().StartsWith("##"))
        {
            var h2 = markdownLine.Replace("##", string.Empty).Trim();
            writer.WriteLine($"\t\t<h2>{h2}</h2>");
        }
        else if (markdownLine.TrimStart().StartsWith("#"))
        {
            Program.Creature.ProperName = markdownLine.Replace("#", string.Empty).Trim();
            writer.WriteLine($"\t\t<h1>{Program.Creature.ProperName}</h1>");
        }
    }
}
