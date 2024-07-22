using GoDungeon.CodeGenerator.Enum;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Enum;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IParseMarkdown
{
    /// <summary>
    /// The parse models for all the markdown models
    /// </summary>
    Dictionary<string, List<ICodeGen>> CodeGenModels { get; }

    /// <summary>
    /// The index models
    /// </summary>
    Dictionary<IndexEnum, List<ICodeGen>> IndexModels { get; }

    /// <summary>
    /// The spell lists
    /// </summary>
    Dictionary<ClassEnum, List<ICodeGen>> SpellLists { get; }

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
