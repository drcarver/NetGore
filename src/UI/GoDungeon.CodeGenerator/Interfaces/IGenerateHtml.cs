using GoDungeon.Core.Interfaces;
using GoDungeon.Spells.Interfaces;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IGenerateHtml
{
    /// <summary>
    /// Generate the .html for the for the parse models
    /// </summary>
    /// <param name="outputDir">The output directory</param>
    /// <param name="parseMarkdown">The Parse models</param>
    public void GenerateHtmlFiles(string outputDir, IParseMarkdown parseMarkdown);
}
