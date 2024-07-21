using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.CodeGenerator.ViewModels;

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

        GenerateTableOfContentsColumn(stream, codeGenModel);

        stream.WriteLine("\t\t\t<div id=\"Column2\">");
        for (int i = 0; i < codeGenModel.ParseModel.MarkDownHtml.Count; i++)
        {
            stream.WriteLine($"\t\t\t\t{codeGenModel.ParseModel.MarkDownHtml[i]}");
        }
        stream.WriteLine("\t\t\t</div>");
        stream.WriteLine("\t\t</div>");
        stream.WriteLine("\t\t<div id=\"Content>\"");
        stream.WriteLine("\t\t\t<footer>");
        stream.WriteLine("\t\t\t\t<hr>");
        stream.WriteLine("\t\t\t\t<div style=\"text-align: center; padding-left: 1em; padding-right: 1em;\">");
        stream.WriteLine("\t\t\t\t\t<p>This work includes material taken from the System Reference Document 5.1 (“SRD 5.1”) by Wizards of the Coast LLC which is available <a href=\"https://dnd.wizards.com/resources/systems-reference-document\">here</a>. The SRD 5.1 is licensed under the Creative Commons Attribution 4.0 International License available at <a href=\"https://creativecommons.org/licenses/by/4.0/legalcode\">CC-BY-4.0</a>.</p>");
        stream.WriteLine("\t\t\t\t\t<p>Check out the <a href=\"https://github.com/vitusventure/5thSRD/\">GitHub repo</a> this code is based on.");
        stream.WriteLine("\t\t\t\t</div>");
        stream.WriteLine("\t\t\t</footer>");
        stream.WriteLine("\t\t</div>");
        stream.WriteLine("\t</body>");
        stream.WriteLine("</html>");
    }

    /// <summary>
    /// Generate the section header table
    /// </summary>
    /// <param name="stream">The output text stream</param>
    /// <param name="codeGenModel">The code generation model</param>
    private void GenerateTableOfContentsColumn(TextWriter stream, ICodeGen codeGenModel)
    {
        stream.WriteLine();
        stream.WriteLine("\t\t\t\t<div id=\"Column1\">");

        #region Section Table
        stream.WriteLine("\t\t\t\t\t<div style=\"text-align: left;\" class=\"responsive-table\">");
        stream.WriteLine("\t\t\t\t\t\t\t<h1 style=\"text-align: left;\">5th SRD</h1>");
        stream.WriteLine("\t\t\t\t\t\t<table style=\"text-align: left;\" class=\"pure-table\">");
        stream.WriteLine("\t\t\t\t\t\t\t<thead>");
        stream.WriteLine("\t\t\t\t\t\t\t\t<th style=\"text-align: left;\">Sections</th>");
        stream.WriteLine("\t\t\t\t\t\t\t</thead>");
        stream.WriteLine("\t\t\t\t\t\t\t<tbody>");
        List<string>? dirList = codeGenModel.ParseModel?.Route?.Split("/").Where(d => !string.IsNullOrEmpty(d)).ToList();
        string path = string.Empty;
        switch (dirList.Count)
        {
            case 1:
                path = "./";
                break;
            case 2:
                path = "../";
                break;
            case 3:
                path = "../../";
                break;
            default:
                break;
        }
        stream.WriteLine($"\t\t\t\t\t\t\t\t<tr style=\"text-align: left;\"><td><a href=\"{path}index.html\">Main Menu</a></td></tr>");
        stream.WriteLine($"\t\t\t\t\t\t\t\t<tr style=\"text-align: left;\"><td><a href=\"{path}Adventuring/index.html\">Adventuring</a></td></tr>");
        stream.WriteLine($"\t\t\t\t\t\t\t\t<tr style=\"text-align: left;\"><td><a href=\"{path}character/index.html\">Character</a></td></tr>");
        stream.WriteLine($"\t\t\t\t\t\t\t\t<tr style=\"text-align: left;\"><td><a href=\"{path}combat/index.html\">Combat</a></td></tr>");
        stream.WriteLine($"\t\t\t\t\t\t\t\t<tr style=\"text-align: left;\"><td><a href=\"{path}GameMasterRules/index.html\">Game Master Rules</a></td></tr>");
        stream.WriteLine($"\t\t\t\t\t\t\t\t<tr style=\"text-align: left;\"><td><a href=\"{path}rules/index.html\">Rules</a>");
        stream.WriteLine($"\t\t\t\t\t\t\t\t<tr style=\"text-align: left;\"><td><a href=\"{path}spellcasting/index.html\">Spellcasting</a>");
        stream.WriteLine("\t\t\t\t\t\t\t</tbody>");
        stream.WriteLine("\t\t\t\t\t\t</table>");
        stream.WriteLine("\t\t\t\t\t</div>");
        #endregion

        #region Table of Contents for this page
        if (codeGenModel.ParseModel.Headers.Count(h => h.Level == 2) > 0)
        {
            stream.WriteLine("<br><br>");
            stream.WriteLine("\t\t\t\t\t<div style=\"text-align: left;\" class=\"responsive-table\">");
            stream.WriteLine("\t\t\t\t\t\t<table style=\"text-align: left;\" class=\"pure-table\">");
            stream.WriteLine("\t\t\t\t\t\t\t<thead>");
            stream.WriteLine("\t\t\t\t\t\t\t\t<th style=\"text-align: left;\">Chapters</th>");
            stream.WriteLine("\t\t\t\t\t\t\t<tbody>");

            foreach (var chapter in codeGenModel.ParseModel.Headers.Where(h => h.Level == 2).OrderBy(o => o.LineNumber).ToList())
            {
                var content = chapter.Content.Substring(chapter.Content.IndexOf(">") + 1).Replace("</h2>", string.Empty);
                var tr = $"\t\t\t\t\t\t\t<tr style=\"text-align: left;\"><td><a href=\"#{chapter.Id}\">{content}</td></tr>";
                stream.WriteLine(tr);
            }
            stream.WriteLine("\t\t\t\t\t\t\t</tbody>");
            stream.WriteLine("\t\t\t\t\t\t</table>");
            stream.WriteLine("\t\t\t\t\t</div>");
        }
        #endregion

        stream.WriteLine("\t\t\t\t</div>");
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
        if (codeGenModel.FileHeaders.Count == 4)
        {
            var spellvm = (SpellViewModel)codeGenModel;
            foreach (var caster in spellvm.CharacterClassList)
            {
                spellCasters += caster + ",";
            }
            spellCasters = spellCasters.Substring(0, spellCasters.LastIndexOf(","));
        }
        string description = string.Empty;
        for (var i = 0; i < codeGenModel.FileHeaders.Count; i++) 
        {
            var meta = codeGenModel.FileHeaders[i];
            if (meta.StartsWith("description:"))
            {
                var rulesVM = (RulesViewModel) codeGenModel;
                description = meta.Replace("description:", string.Empty).Trim();
                rulesVM.Description = description;
                codeGenModel.FileHeaders[i] = $"description: {meta}";
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
        stream.WriteLine($"\t\t<meta charset=\"utf-8\" >");
        stream.WriteLine($"\t\t<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" >");
        stream.WriteLine($"\t\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
        stream.WriteLine();
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
        stream.WriteLine("\t\t\t\tborder-collapse: separate;");
        stream.WriteLine("\t\t\t\tborder-spacing: 0;");
        stream.WriteLine("\t\t\t\tempty-cells: show");
        stream.WriteLine("\t\t\t\tborder: 2px solid black");
        stream.WriteLine("\t\t\t}");
        stream.WriteLine();
        stream.WriteLine("\t\t\t.pure-table th");
        stream.WriteLine("\t\t\t{");
        stream.WriteLine("\t\t\t\tborder-style: solid;");
        stream.WriteLine("\t\t\t\tfont-size: inherit;");
        stream.WriteLine("\t\t\t\tmargin: 0;");
        stream.WriteLine("\t\t\t\toverflow: hidden;");
        stream.WriteLine("\t\t\t\tpadding: .5em 1em");
        stream.WriteLine("\t\t\t}");
        stream.WriteLine("\t\t\t.pure-table td");
        stream.WriteLine("\t\t\t{");
        stream.WriteLine("\t\t\t\tborder-style: none;");
        stream.WriteLine("\t\t\t\tborder-bottom: 0 none antiquewhite;");
        stream.WriteLine("\t\t\t\tborder-top: 0 none antiquewhite;");
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

        #region Columns
        stream.WriteLine();
        stream.WriteLine("\t\t\t#Content");
        stream.WriteLine("\t\t\t{");
        stream.WriteLine("\t\t\t\twidth: 100%;");
        stream.WriteLine("\t\t\t}");
        stream.WriteLine();
        stream.WriteLine("\t\t\t#Column1");
        stream.WriteLine("\t\t\t{");
        stream.WriteLine("\t\t\t\twidth: 20%;");
        stream.WriteLine("\t\t\t\tfloat: left;");
        stream.WriteLine("\t\t\t}");
        stream.WriteLine();
        stream.WriteLine("\t\t\t#Column2");
        stream.WriteLine("\t\t\t{");
        stream.WriteLine("\t\t\t\twidth: 80%;");
        stream.WriteLine("\t\t\t\tfloat: left;");
        stream.WriteLine("\t\t\t}");
        #endregion

        stream.WriteLine("\t\t</style>");
    }
}
