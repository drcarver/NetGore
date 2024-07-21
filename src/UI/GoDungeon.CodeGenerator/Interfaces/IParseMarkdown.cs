using GoDungeon.CodeGenerator.Models;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IParseMarkdown
{
    /// <summary>
    /// The parse models for all the markdown models
    /// </summary>
    Dictionary<string, List<ICodeGen>> CodeGenModels { get; }

    /// <summary>
    /// Get the tables in the markdown file
    /// </summary>
    void ParseMarkDownTable(ParseModel markDown);

    /// <summary>
    /// Parse the markdown to .html
    /// </summary>
    /// <param name="codeGen">The code generation model for the markdown</param>
    void ParseMarkdownToHTML(ICodeGen codeGen);
}
