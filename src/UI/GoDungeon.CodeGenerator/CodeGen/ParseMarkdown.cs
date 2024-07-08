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
        int startPos = 0;
        for (int i = 0; i < parseModel.Markdown.Length; i++)
        {
            if (string.IsNullOrEmpty(parseModel.Markdown[i].Trim()))
            {
                startPos = i+1;
                break;
            }
        }

        for (int i = startPos; i < parseModel.Markdown.Length; i++)
        {
            if (parseModel.Markdown[i].Trim() == string.Empty)
            {
                continue;
            }
            switch (parseModel.Markdown[i][0])
            {
                case '#':
                    ParseToHTMLHeader(parseModel, i);
                    break;
                case '|':
                    var table = parseModel.MarkDownTableModels.FirstOrDefault(t => t.MarkdownLine == i);
                    if (table != null)
                    {
                        ParseMarkdownToHTMLTable(parseModel, table);
                        i += table.TableRows.Count;
                    }
                    break;
                default:
                    if (parseModel.Markdown[i].Trim() =="- - -" ||
                        parseModel.Markdown[i].Trim() == "* * *" ||
                        parseModel.Markdown[i].Trim() == "_ _ _")
                    {
                        parseModel.MarkDownHtml.Add("<hr>");
                        break;
                    }
                    if (char.IsAsciiDigit(parseModel.Markdown[i][0]))
                    {
                        i = ParseMarkdownToOrderedHtmlList(parseModel, i);
                        break;
                    }
                    if (parseModel.Markdown[i].StartsWith("* ") ||
                        parseModel.Markdown[i].StartsWith("+ ") ||
                        parseModel.Markdown[i].StartsWith("- "))
                    {
                        i = ParseMarkdownToHtmlUnorderedList(parseModel, i);
                        break;
                    }
                    parseModel.MarkDownHtml.Add($"<p>{ParseMarkdownToHtmlBold(parseModel.Markdown[i])}</p>");
                    break;
            }
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
            string listElement = parseModel.Markdown[i].Substring(parseModel.Markdown[i].IndexOf(" "));
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
            string listElement = string.Empty;
            if (parseModel.Markdown[i].StartsWith("* "))
            {
                listElement = parseModel.Markdown[i].Replace("* ", string.Empty);
            }
            if (parseModel.Markdown[i].StartsWith("+ "))
            {
                listElement = parseModel.Markdown[i].Replace("+ ", string.Empty);
            }
            if (parseModel.Markdown[i].StartsWith("- "))
            {
                listElement = parseModel.Markdown[i].Replace("- ", string.Empty);
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
        parseModel.MarkDownHtml.Add("<div class=\"responsive-table\"><table class=\"pure-table\">");
        //parseModel.MarkDownHtml.Add($"\t<caption>{table.TableCaption}</caption>");

        // Now the table header
        parseModel.MarkDownHtml.Add($"\t<thead>");
        parseModel.MarkDownHtml.Add($"\t\t<tr>");
        var headers = table.TableRows[0].Split("|");
        foreach (var header in headers)
        {
            if (header.Trim() == "|" || header.Trim() == string.Empty)
            {
                continue; 
            }
            var hName = header.Replace("|", string.Empty).Trim();
            parseModel.MarkDownHtml.Add($"\t\t\t<th>{hName}</th>");
        }
        parseModel.MarkDownHtml.Add($"\t\t</tr>");
        parseModel.MarkDownHtml.Add($"\t</thead>");

        // Next the table body
        parseModel.MarkDownHtml.Add($"\t<tbody>");
        for (int i = 2; i < table.TableRows.Count; i++)
        {
            parseModel.MarkDownHtml.Add($"\t\t<tr>");
            foreach (var row in table.TableRows[i].Split("|"))
            {
                if (row.Trim() == "|" || row.Trim() == string.Empty)
                {
                    continue;
                }
                parseModel.MarkDownHtml.Add($"\t\t\t<td>{row.Replace("|", string.Empty).Trim()}</td>");
            }
            parseModel.MarkDownHtml.Add($"\t\t</tr>");
        }
        parseModel.MarkDownHtml.Add($"\t</tbody>");

        // close out the table
        parseModel.MarkDownHtml.Add($"</table>");
    }

    /// <summary>
    /// Parse the bold and italic in a markdown line
    /// </summary>
    /// <param name="line">The line to parse</param>
    /// <returns>The line with bold and italics added</returns>
    private string ParseMarkdownToHtmlBold(string line)
    {
        if (line.IndexOf("__*") != -1)
        {
            line = ReplaceFirst(line, "__*", "<em><strong>");
            line = ReplaceFirst(line, "*__", "</strong></em>");
        }
        if (line.IndexOf("**_") != -1)
        {
            line = ReplaceFirst(line, "**_", "<em><strong>");
            line = ReplaceFirst(line, "_**", "</strong></em>");
        }
        if (line.IndexOf("***") != -1)
        {
            line = ReplaceFirst(line, "***", "<em><strong>");
            line = ReplaceFirst(line, "***", "</strong></em>");
        }
        if (line.IndexOf("__") != -1)
        {
            line = ReplaceFirst(line, "___", "<em><strong>");
            line = ReplaceFirst(line, "___", "</strong></em>");
        }
        if (line.IndexOf("**") != -1)
        {
            line = ReplaceFirst(line, "**", "<strong>");
            line = ReplaceFirst(line, "**", "</strong>");
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
    private void ParseToHTMLHeader(ParseModel parseModel, int lineNo)
    {
        string content = parseModel.Markdown[lineNo];
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
            LineNumber = lineNo,
            Id = Utilities.CleanupForCSharp(content)
        };
        header.Content = $"<h{header.Level} id=\"{header.Id}\">{content}</h{header.Level}>";
        parseModel.Headers.Add(header);
        parseModel.MarkDownHtml.Add(header.Content);
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
}
