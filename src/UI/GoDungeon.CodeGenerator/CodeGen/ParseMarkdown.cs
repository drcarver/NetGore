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
    /// <param name="codeGenerationModel">The code generation model for the markdown</param>
    public void ParseMarkdownToHTML(ICodeGen codeGenerationModel)
    {
        // Skip over the file header
        ParseModel parseModel = codeGenerationModel.ParseModel;
        int startPos = 0;

        for (int i = 0; i < parseModel.Markdown.Count; i++)
        {
            if (string.IsNullOrEmpty(parseModel.Markdown[i].Trim())
                || parseModel.Markdown[i].StartsWith("#"))
            {
                startPos = i;
                break;
            }
        }

        // iterate through the rest of the markdown and convert it to .html
        for (int i = startPos; i < parseModel.Markdown.Count; i++)
        {
            bool inBlockQuote = false;
            var line = parseModel.Markdown[i];
            if (string.IsNullOrEmpty(line))
            {
                continue;
            }
            switch (line[0])
            {
                case '#':
                    var header = ParseToHTMLHeader(codeGenerationModel, i);
                    parseModel.Headers.Add(header);
                    break;
                case '>':
                    line = ParseMarkdownToHtmlBold(codeGenerationModel, i, line);
                    if (!inBlockQuote)
                    {
                        parseModel.MarkDownHtml.Add("<blockquote>");
                        inBlockQuote = true;
                    }
                    break;
                case '|':
                    var table = parseModel.MarkDownTableModels.FirstOrDefault(t => t.MarkdownLine == i);
                    if (table != null)
                    {
                        ParseMarkdownToHTMLTable(codeGenerationModel, table);
                        i += table.TableRows.Count;
                    }
                    break;
                default:
                    i = ConvertToHTML(codeGenerationModel, i);
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
            } while (t < parseModel.Markdown.Count);

            // Are we at the end of the file
            if (t == parseModel.Markdown.Count)
            {
                break;
            }

            // Parse the next table in the file
            parseModel.MarkDownTableModels.Add(new MarkDownTableModel());
            parseModel.MarkDownTableModels[parseModel.MarkDownTableModels.Count() - 1].TableCaption = tableCaption;
            parseModel.MarkDownTableModels[parseModel.MarkDownTableModels.Count() - 1].MarkdownLine = t;
            while (t < parseModel.Markdown.Count && parseModel.Markdown[t].StartsWith("|"))
            {
                parseModel.MarkDownTableModels[parseModel.MarkDownTableModels.Count() - 1].TableRows.Add(parseModel.Markdown[t]);
                t++;
            }
        } while (t < parseModel.Markdown.Count);
    }

    /// <summary>
    /// Convert the markdown string to .html
    /// </summary>
    /// <param name="line">The markdown string</param>
    private int ConvertToHTML(ICodeGen codeGenerationModel, int lineNo)
    {
        // Convert the markdown string to .html
        string line =  codeGenerationModel.ParseModel.Markdown[lineNo];
        if (line[0] == '>')
        {
            line = line.Substring(1);
        }
        switch (line[0])
        {
            case '#':
                var header = ParseToHTMLHeader(codeGenerationModel, lineNo);
                codeGenerationModel.ParseModel.Headers.Add(header);
                return lineNo;
            default:
                if (line.Trim() == "- - -" ||
                    line.Trim() == "* * *" ||
                    line.Trim() == "_ _ _")
                {
                    codeGenerationModel.ParseModel.MarkDownHtml.Add("<hr>");
                    return lineNo;
                }
                if (char.IsAsciiDigit(line[0]))
                {
                    lineNo = ParseMarkdownToOrderedHtmlList(codeGenerationModel, lineNo);
                    return lineNo;
                }
                if (line.StartsWith("* ") || line.StartsWith("+ ") || line.StartsWith("- "))
                {
                    lineNo = ParseMarkdownToHtmlUnorderedList(codeGenerationModel, lineNo);
                    return lineNo;
                }
                codeGenerationModel.ParseModel.MarkDownHtml.Add($"<p>{ParseMarkdownToHtmlBold(codeGenerationModel, lineNo, line)}</p>");
                return lineNo;
        }
    }

    /// <summary>
    /// Parse the markdown to a ordered list
    /// </summary>
    /// <param name="parseModel">The model to parse</param>
    /// <param name="i">The line that starts the list</param>
    /// <returns></returns>
    private int ParseMarkdownToOrderedHtmlList(ICodeGen codeGenerationModel, int i)
    {
        var parseModel = codeGenerationModel.ParseModel;
        parseModel.MarkDownHtml.Add("<ol>");
        while (i < parseModel.Markdown.Count)
        {
            string listElement = ParseMarkdownToHtmlBold(codeGenerationModel, i, parseModel.Markdown[i]);
            if (listElement[0] == '>')
            {
                listElement = listElement.Substring(1);
            }
            var space = listElement.IndexOf(" ");
            if (space > 0)
            {
                listElement = listElement.Substring(space);
            }
            parseModel.MarkDownHtml.Add($"<li>{listElement}</li>");
            i++;
            if (string.IsNullOrEmpty(parseModel.Markdown[i].Trim()))
            {
                break;
            }
            if (i >= parseModel.Markdown.Count || !Char.IsAsciiDigit(parseModel.Markdown[i][0]))
            {
                break;
            }
        }
        parseModel.MarkDownHtml.Add("</ol>");
        parseModel.MarkDownHtml.Add("<br>");
        return i;
    }

    /// <summary>
    /// Create a unordered list from the mark down
    /// </summary>
    /// <param name="parseModel">The Parse Model</param>
    /// <param name="i">The line where the list starts</param>
    /// <returns></returns>
    private int ParseMarkdownToHtmlUnorderedList(ICodeGen codeGenerationModel, int i)
    {
        ParseModel parseModel = codeGenerationModel.ParseModel;
        while (i < parseModel.Markdown.Count) 
        {
            string listElement = ParseMarkdownToHtmlBold(codeGenerationModel, i, parseModel.Markdown[i]);
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
            if (i == parseModel.Markdown.Count ||
                string.IsNullOrEmpty(parseModel.Markdown[i].Trim()))
            {
                break;
            }
        }
        parseModel.MarkDownHtml.Add("</ul>");
        parseModel.MarkDownHtml.Add("<br>");
        return i;
    }

    /// <summary>
    /// Parse the markdown table to .html
    /// </summary>
    /// <param name="parseModel">The parse model containing the table</param>
    /// <param name="table">The markdown table to parse to ..html</param>
    private void ParseMarkdownToHTMLTable(ICodeGen codeGenerationModel, MarkDownTableModel table)
    {
        ParseModel parseModel = codeGenerationModel.ParseModel;
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
            var hName = ParseMarkdownToHtmlBold(codeGenerationModel, table.MarkdownLine, header);
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
                var rowHtml = ParseMarkdownToHtmlBold(codeGenerationModel, table.MarkdownLine+i, row);
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
    private string ParseMarkdownToHtmlBold(ICodeGen codeGenerationModel, int lineNo, string line)
    {
        if (line.StartsWith(">"))
        {
            line = line.Substring(1);
        }
        while (line.IndexOf("__*") != -1)
        {
            line = Utilities.ReplaceFirst(line, "__*", "<em><strong>");
            line = Utilities.ReplaceFirst(line, "*__", "</strong></em>");
        }
        while (line.IndexOf("**_") != -1)
        {
            line = Utilities.ReplaceFirst(line, "**_", "<em><strong>");
            line = Utilities.ReplaceFirst(line, "_**", "</strong></em>");
        }
        while (line.IndexOf("***") != -1)
        {
            line = Utilities.ReplaceFirst(line, "***", "<em><strong>");
            line = Utilities.ReplaceFirst(line, "***", "</strong></em>");
        }
        while (line.IndexOf("___") != -1)
        {
            line = Utilities.ReplaceFirst(line, "___", "<em><strong>");
            line = Utilities.ReplaceFirst(line, "___", "</strong></em>");
        }
        while (line.IndexOf("**") != -1)
        {
            line = Utilities.ReplaceFirst(line, "**", "<strong>");
            line = Utilities.ReplaceFirst(line, "**", "</strong>");
        }
        while (line.IndexOf("_") != -1)
        {
            line = Utilities.ReplaceFirst(line, "_", "<em>");
            line = Utilities.ReplaceFirst(line, "_", "</em>");
        }
        if (line.TrimStart().StartsWith("#"))
        {
            var header = ParseToHTMLHeader(codeGenerationModel, lineNo);
            codeGenerationModel.ParseModel.Headers.Add(header);
            line = header.Content;
        }
        if (!string.IsNullOrEmpty(line) && line.IndexOf("](") != -1)
        {
            while (line.IndexOf("](") > -1)
            {
                string link = line.Substring(line.IndexOf("["));
                string anchorString = string.Empty;
                int bracketInt = link.IndexOf("](");
                int rparenInt = link.Substring(bracketInt).IndexOf(")");
                if (bracketInt > -1)
                {
                    try
                    {
                        anchorString = link.Substring(1, bracketInt - 1);
                        string htmlString = link.Substring(bracketInt+2, rparenInt-2);
                        string anchorLink = $"<a href=\"{htmlString}\">{anchorString}</a>";
                        line = Utilities.ReplaceFirst(line, link, anchorLink).Trim();
                    }
                    catch (Exception ex)
                    {
                        break;
                    }
                }
            }
        }
        return line;
    }

    /// <summary>
    /// Parse a markdown header to a .html header
    /// </summary>
    /// <param name="parseModel">The code generation model</param>
    /// <param name="lineNo">The line number in the file</param>
    /// <returns>The header model for the current header</returns></remarks>
    private HeaderModel ParseToHTMLHeader(ICodeGen model, int lineNo)
    {
        string content = model.ParseModel.Markdown[lineNo].TrimStart();
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
            model.ParseModel.MarkDownHtml.Add(header.Content);
            if (level == 1 && !string.IsNullOrEmpty(model.Description))
            {
                model.ParseModel.MarkDownHtml.Add($"<em>{model.Description.Trim()}</em><br>");
                model.ParseModel.MarkDownHtml.Add($"<br>");
            }
        }
        return header;
    }
}
