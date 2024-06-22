using GoDungeon.CodeGenerator.Models;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IProcess5ESRDFiles
{
    /// <summary>
    /// The root directory to the input markdown files
    /// </summary>
    string? RootMarkDownDirectory { get; set; }

    /// <summary>
    /// The root directory to generate the .html and class files in
    /// </summary>
    string? RootOutputDirectory { get; set; }

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
    /// Process a directory
    /// </summary>
    /// <param name="rootDir">The root directory</param>
    /// <param name="outputDir">The output directory</param>
    void ProcessDirectory(string rootDir, string outputDir);
}
