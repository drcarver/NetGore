using GoDungeon.CommandLineTools.Models;

namespace GoDungeon.CommandLineTools;

internal static class GenerateHtml
{
    /// <summary>
    /// Generate a .html header if the line is a header
    /// </summary>
    /// <param name="markdownLine">The markdown line</param>
    /// <param name="writer">The TextWriter</param>
    internal static void GenerateHtmlHeader(string markdownLine, TextWriter writer, ClassInfo classInfo)
    {
        if (string.IsNullOrEmpty(markdownLine) || !markdownLine.TrimStart().StartsWith("#"))
        {
            return;
        }

        char[] charArray = markdownLine.TrimStart().ToCharArray();
        if (markdownLine.TrimStart().StartsWith("####"))
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
            classInfo.Name = markdownLine.Replace("#", string.Empty).Trim();
            writer.WriteLine($"\t\t<h1>{classInfo.Name}</h1>");
        }
    }
}
