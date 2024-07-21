namespace GoDungeon.CodeGenerator.Interfaces;

public interface IProcess5ESRDFiles
{
    /// <summary>
    /// The root directory to the input markdown files
    /// </summary>
    string? RootMarkDownDirectory { get; set; }

    /// <summary>
    /// Process monster files from the SRD
    /// </summary>
    IParseMarkdown ParseMarkdown { get; }

    /// <summary>
    /// Generate the C# files for the monster
    /// </summary>
    IGenerateModel GenerateModel { get; }

    /// <summary>
    /// Generate the .html file for the monster
    /// </summary>
    IGenerateHtml GenerateHtml { get; }

    /// <summary>
    /// Parse a markdown directory into a parse model
    /// </summary>
    /// <param name="rootDir">The root directory for the markdown files</param>
    void ParseMarkdownDirectory(string inputDir);
}
