using GoDungeon.CodeGenerator.Models;
using GoDungeon.CodeGenerator.ViewModels;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IParseMarkdown
{
    /// <summary>
    /// The parse models for all the markdown models
    /// </summary>
    public List<ICodeGen> CodeGenModels { get; }

    /// <summary>
    /// Get the tables in the markdown file
    /// </summary>
    void ParseMarkDownTable(ParseModel markDown);

    /// <summary>
    /// Parse the markdown to .html
    /// </summary>
    /// <param name="parseModel">The parse model for the markdown</param>
    void ParseMarkdownToHTML(ParseModel parseModel);
}
