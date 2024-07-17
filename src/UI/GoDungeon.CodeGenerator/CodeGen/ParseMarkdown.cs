using GoDungeon.CodeGenerator.CodeGen;
using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;

namespace GoDungeon.CommandLineTools.CodeGen;

public partial class ParseMarkdown : IParseMarkdown
{
    /// <summary>
    /// The logger
    /// </summary>
    private readonly ILogger<ParseMarkdown> logger;

    /// <summary>
    /// The rules files (text only)
    /// </summary>
    public Dictionary<string, List<ICodeGen>> CodeGenModels { get; } = [];

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="loggerFactory">The logger factory</param>
    public ParseMarkdown(ILoggerFactory loggerFactory)
    {
        logger = loggerFactory.CreateLogger<ParseMarkdown>();
    }

    /// <summary>
    /// Parse the markdown to .html
    /// </summary>
    /// <param name="parseModel">The parse model for the markdown</param>
    public void ParseMarkdownToHTML(ParseModel parseModel)
    {
        // Skip over the file header
        int startPos = 0;
        for (int i = 0; i < parseModel.Markdown.Length; i++)
        {
            if (string.IsNullOrEmpty(parseModel.Markdown[i].Trim())
                || !parseModel.Markdown[i].Contains(":"))
            {
                startPos = i+1;
                break;
            }
        }

        // iterate through the rest of the markdown and convert it to .html
        for (int i = startPos; i < parseModel.Markdown.Length; i++)
        {
            bool inBlockQuote = false;
            var line = parseModel.Markdown[i];
            if (line.Trim() == string.Empty)
            {
                continue;
            }
            if (line.StartsWith(">"))
            {
                line = ParseMarkdownToHtmlBold(parseModel, line.Substring(1));
                if (!inBlockQuote)
                {
                    parseModel.MarkDownHtml.Add("<blockquote>");
                    inBlockQuote = true;
                }
            }
            switch (line[0])
            {
                case '|':
                    var table = parseModel.MarkDownTableModels.FirstOrDefault(t => t.MarkdownLine == i);
                    if (table != null)
                    {
                        ParseMarkdownToHTMLTable(parseModel, table);
                        i += table.TableRows.Count;
                    }
                    break;
                default:
                    i = ConvertToHTML(parseModel, i);
                    break;
            }
            if (inBlockQuote)
            {
                parseModel.MarkDownHtml.Add("</blockquote>");
                inBlockQuote = false;
            }
        }
    }

    /// <summary>
    /// Parse any tables
    /// </summary>
    /// <param name="parseModel">The parse model for the file</param>
    public void ParseMarkDownTable(ParseModel parseModel)
    {
        // Are there any tables in the file
        if (!parseModel.Markdown.Any(m => m.TrimStart().StartsWith("|")))
        {
            return;
        }

        var markDownTableModel = new MarkDownTableModel();
        int t = 0;
        int tableCount = 0;
        do
        {
            // Get the caption for the table
            var tableCaption = string.Empty;
            do
            {
                if (parseModel.Markdown[t].StartsWith("#"))
                {
                    tableCaption = parseModel.Markdown[t].Replace("#", string.Empty).Trim();
                }
                if (parseModel.Markdown[t].StartsWith('|'))
                {
                    break;
                }
                t++;
            } while (t < parseModel.Markdown.Length);

            // Are we at the end of the file
            if (t == parseModel.Markdown.Length)
            {
                break;
            }

            // Parse the next table in the file
            parseModel.MarkDownTableModels.Add(new MarkDownTableModel());
            parseModel.MarkDownTableModels[parseModel.MarkDownTableModels.Count() - 1].TableCaption = tableCaption;
            parseModel.MarkDownTableModels[parseModel.MarkDownTableModels.Count() - 1].MarkdownLine = t;
            while (t < parseModel.Markdown.Length && parseModel.Markdown[t].StartsWith("|"))
            {
                parseModel.MarkDownTableModels[parseModel.MarkDownTableModels.Count() - 1].TableRows.Add(parseModel.Markdown[t]);
                t++;
            }
        } while (t < parseModel.Markdown.Length);
    }

    /// <summary>
    /// Convert the markdown string to .html
    /// </summary>
    /// <param name="line">The markdown string</param>
    private int ConvertToHTML(ParseModel model, int lineNo)
    {
        // Convert the markdown string to .html
        string line = model.Markdown[lineNo];
        if (line[0] == '>')
        {
            line = line.Substring(1);
        }
        switch (line[0])
        {
            case '#':
                var header = ParseToHTMLHeader(line);
                model.MarkDownHtml.Add(header.Content);
                model.Headers.Add(header);
                return lineNo;
            default:
                if (line.Trim() == "- - -" ||
                    line.Trim() == "* * *" ||
                    line.Trim() == "_ _ _")
                {
                    model.MarkDownHtml.Add("<hr>");
                    return lineNo;
                }
                if (char.IsAsciiDigit(line[0]))
                {
                    lineNo = ParseMarkdownToOrderedHtmlList(model, lineNo);
                    return lineNo;
                }
                if (line.StartsWith("* ") || line.StartsWith("+ ") || line.StartsWith("- "))
                {
                    lineNo = ParseMarkdownToHtmlUnorderedList(model, lineNo);
                    return lineNo;
                }
                model.MarkDownHtml.Add($"<p>{ParseMarkdownToHtmlBold(model, line)}</p>");
                return lineNo;
        }
    }

    /// <summary>
    /// Parse the markdown to a ordered list
    /// </summary>
    /// <param name="parseModel">The model to parse</param>
    /// <param name="i">The line that starts the list</param>
    /// <returns></returns>
    private int ParseMarkdownToOrderedHtmlList(ParseModel parseModel, int i)
    {
        parseModel.MarkDownHtml.Add("<ol>");
        while (i < parseModel.Markdown.Length)
        {
            string listElement = ParseMarkdownToHtmlBold(parseModel, parseModel.Markdown[i]);
            if (listElement[0] == '>')
            {
                listElement = listElement.Substring(1);
            }
            parseModel.MarkDownHtml.Add($"<li>{listElement}</li>");
            i++;
            if (string.IsNullOrEmpty(parseModel.Markdown[i].Trim()))
            {
                break;
            }
            if (i >= parseModel.Markdown.Length || !Char.IsAsciiDigit(parseModel.Markdown[i][0]))
            {
                break;
            }
        }
        parseModel.MarkDownHtml.Add("</ol>");
        return i;
    }

    /// <summary>
    /// Create a unordered list from the mark down
    /// </summary>
    /// <param name="parseModel">The Parse Model</param>
    /// <param name="i">The line where the list starts</param>
    /// <returns></returns>
    private int ParseMarkdownToHtmlUnorderedList(ParseModel parseModel, int i)
    {
        parseModel.MarkDownHtml.Add("<ul>");
        while (i < parseModel.Markdown.Length) 
        {
            string listElement = ParseMarkdownToHtmlBold(parseModel, parseModel.Markdown[i]);
            if (listElement[0] == '>')
            {
                listElement = listElement.Substring(1);
            }
            if (listElement.StartsWith("*"))
            {
                listElement = listElement.Replace("*", string.Empty);
            }
            if (listElement.StartsWith("+ "))
            {
                listElement = listElement.Replace("+", string.Empty);
            }
            if (listElement.StartsWith("- "))
            {
                listElement = listElement.Replace("-", string.Empty);
            }
            parseModel.MarkDownHtml.Add($"<li>{listElement}</li>");
            i++;
            if (i == parseModel.Markdown.Length ||
                string.IsNullOrEmpty(parseModel.Markdown[i].Trim()))
            {
                break;
            }
        }
        parseModel.MarkDownHtml.Add("</ul>");
        return i;
    }

    /// <summary>
    /// Parse the markdown table to .html
    /// </summary>
    /// <param name="parseModel">The parse model containing the table</param>
    /// <param name="table">The markdown table to parse to ..html</param>
    private void ParseMarkdownToHTMLTable(ParseModel parseModel, MarkDownTableModel table)
    {
        parseModel.MarkDownHtml.Add("<div class=\"responsive-table\">");
        parseModel.MarkDownHtml.Add("\t<table class=\"pure-table\">");

        // Now the table header
        parseModel.MarkDownHtml.Add($"\t\t<thead>");
        parseModel.MarkDownHtml.Add($"\t\t\t<tr>");
        var headers = table.TableRows[0].Split("|");
        foreach (var header in headers)
        {
            if (header.Trim() == "|" || header.Trim() == string.Empty)
            {
                continue; 
            }
            var hName = ParseMarkdownToHtmlBold(parseModel, header);
            parseModel.MarkDownHtml.Add($"\t\t\t\t<th>{hName}</th>");
        }
        parseModel.MarkDownHtml.Add($"\t\t\t</tr>");
        parseModel.MarkDownHtml.Add($"\t\t</thead>");

        // Next the table body
        parseModel.MarkDownHtml.Add($"\t\t<tbody>");
        for (int i = 2; i < table.TableRows.Count; i++)
        {
            parseModel.MarkDownHtml.Add($"\t\t\t<tr>");
            foreach (var row in table.TableRows[i].Split("|"))
            {
                if (row.Trim() == "|" || row.Trim() == string.Empty)
                {
                    continue;
                }
                var rowHtml = ParseMarkdownToHtmlBold(parseModel, row);
                parseModel.MarkDownHtml.Add($"\t\t\t\t<td>{rowHtml}</td>");
            }
            parseModel.MarkDownHtml.Add($"\t\t\t</tr>");
        }
        parseModel.MarkDownHtml.Add($"\t\t</tbody>");

        // close out the table
        parseModel.MarkDownHtml.Add($"\t</table>");
        parseModel.MarkDownHtml.Add($"</div>");
    }

    /// <summary>
    /// Parse the bold and italic in a markdown line
    /// </summary>
    /// <param name="parseModel">The parse model for the markdown</param>
    /// <param name="line">The line to be parsed</param>
    /// <returns>The line with bold and italics added</returns>
    private string ParseMarkdownToHtmlBold(ParseModel model, string line)
    {
        while (line.IndexOf("__*") != -1)
        {
            line = ReplaceFirst(line, "__*", "<em><strong>");
            line = ReplaceFirst(line, "*__", "</strong></em>");
        }
        while (line.IndexOf("**_") != -1)
        {
            line = ReplaceFirst(line, "**_", "<em><strong>");
            line = ReplaceFirst(line, "_**", "</strong></em>");
        }
        while (line.IndexOf("***") != -1)
        {
            line = ReplaceFirst(line, "***", "<em><strong>");
            line = ReplaceFirst(line, "***", "</strong></em>");
        }
        while (line.IndexOf("___") != -1)
        {
            line = ReplaceFirst(line, "___", "<em><strong>");
            line = ReplaceFirst(line, "___", "</strong></em>");
        }
        while (line.IndexOf("**") != -1)
        {
            line = ReplaceFirst(line, "**", "<strong>");
            line = ReplaceFirst(line, "**", "</strong>");
        }
        while (line.IndexOf("_") != -1)
        {
            line = ReplaceFirst(line, "_", "<em>");
            line = ReplaceFirst(line, "_", "</em>");
        }
        if (line.TrimStart().StartsWith("#"))
        {
            var header = ParseToHTMLHeader(line);
            model.Headers.Add(header);
            line = header.Content;
        }
        if (line.IndexOf("[") != -1)
        {
            string linkString = line.Substring(line.IndexOf("["));
            while (linkString.IndexOf("[") > -1)
            {
                int linkStart = linkString.IndexOf("[");
                int linkEnd = linkString.IndexOf(")");
                string link = linkString.Substring(linkStart, linkEnd - linkStart + 1);
                string htmlLink = $"<a href=\"{link.Substring(link.IndexOf("(") + 1).Replace("<em>", string.Empty).Replace("</em>", string.Empty)}\">";
                string anchorLink = $"{htmlLink}{link.Substring(1, link.IndexOf("]")- 1)}</a>";
                line = line.Replace(link, ReplaceFirst(anchorLink, ")", string.Empty)).Trim();
                if (line.IndexOf("[") > -1)
                {
                    linkString = line.Substring(line.IndexOf("["));
                }
                else
                {
                    linkString = string.Empty;
                }
            }
            line = line.Replace("</a>)", "</a>");       
        }
        return line;
    }

    /// <summary>
    /// Replace the first instance of a string
    /// </summary>
    /// <param name="text">The text holding the element to replace</param>
    /// <param name="search">The string to search for</param>
    /// <param name="replace">The string to replace with</param>
    /// <returns>The new string</returns>
    private string ReplaceFirst(string text, string search, string replace)
    {
        int pos = text.IndexOf(search);
        if (pos < 0)
        {
            return text;
        }
        return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
    }

    /// <summary>
    /// Parse a markdown header to a .html header
    /// </summary>
    /// <param name="parseModel">The parse model</param>
    /// <param name="line">The line to parse</param>
    /// <param name="lineNo">The line number in the file</param>
    /// <returns>The header model for the current header</returns></remarks>
    private HeaderModel ParseToHTMLHeader(string line)
    {
        string content = line.TrimStart();
        int level = 0;

        // determine the header level
        while (content.Substring(level).StartsWith("#"))
        {
            level++;
        }

        // build the header model
        content = content.Substring(level).Trim();
        var header = new HeaderModel
        {
            Level = level,
            Id = Utilities.CleanupForCSharp(content),
        };
        if (level > 0)
        {
            header.Content = $"<h{header.Level} id=\"{header.Id}\">{content}</h{header.Level}>";
        }
        return header;
    }
}
