namespace GoDungeon.CodeGenerator.Interfaces;

public interface IProcess5ESRDFiles
{
    /// <summary>
    /// The root directory to generate the .html and class files in
    /// </summary>
    public string? MonsterRootDirectory { get; set; }

    /// <summary>
    /// Process a directory
    /// </summary>
    /// <param name="rootDir">The root directory</param>
    /// <param name="outputDir">The output directory</param>
    public void ProcessDirectory(string rootDir, string outputDir);
}
