namespace GoDungeon.CodeGenerator.Interfaces;

public interface IGenerateModel
{
    /// <summary>
    /// Generate the models from the markdown parse files
    /// </summary>
    /// <param name="outputDir">The output directory</param>
    /// <param name="parseMarkdown">The parse models</param>
    void GenerateNetStandardModel(string outputDir, IParseMarkdown parseMarkdown);

    /// <summary>
    /// Generate the xaml for the markdown file
    /// </summary>
    /// <param name="outputDir">The output directory</param>
    /// <param name="parseMarkdown">The parse models</param>
    void GenerateMAUIModel(string outputDir, IParseMarkdown parseMarkdown);
}
