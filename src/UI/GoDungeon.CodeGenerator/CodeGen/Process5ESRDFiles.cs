using GoDungeon.CodeGenerator.Interfaces;

namespace GoDungeon.CodeGenerator.CodeGen;

public class Process5ESRDFiles : IProcess5ESRDFiles
{
    /// <summary>
    /// Process the 5th edition SRD files
    /// </summary>
    /// <param name="parseMonsterMarkdown">The parser file</param>
    /// <param name="generateMonster">The class generator</param>
    /// <param name="generateHtml">The .html generator</param>
    public Process5ESRDFiles
    (
        IParseMarkdown parseMarkdown,
        IGenerateModel generateMonster,
        IGenerateHtml generateHtml
    )
    {
        ParseMarkdown = parseMarkdown;
        GenerateModel = generateMonster;
        GenerateHtml = generateHtml;
    }

    /// <summary>
    /// the list of MarkDownTables.
    /// </summary>
    public List<IMarkDownTableModel> MarkDownTableModels = new List<IMarkDownTableModel>();

    /// <summary>
    /// Process monster files from the SRD
    /// </summary>
    public IParseMarkdown ParseMarkdown { get; }

    /// <summary>
    /// Generate the C# files for the monster
    /// </summary>
    public IGenerateModel GenerateModel { get; }

    /// <summary>
    /// Generate the .html file for the monster
    /// </summary>
    public IGenerateHtml GenerateHtml { get; }

    /// <summary>
    /// The root directory to generate the .html and class files in
    /// </summary>
    public string? RootDirectory { get; set; }

    /// <summary>
    /// Process a directory
    /// </summary>
    /// <param name="rootDir">The root directory</param>
    public void ProcessDirectory(string inputDir, string outputdir)
    {
        ProcessDirectoryRecursive(inputDir, outputdir);
    }

    /// <summary>
    /// Process a directory recursively
    /// </summary>
    /// <param name="rootDir">The root directory</param>
    private void ProcessDirectoryRecursive(string inputDir, string outputdir)
    {
        RootDirectory = inputDir;
        foreach (var dir in Directory.EnumerateDirectories(inputDir))
        {
            ProcessDirectoryRecursive(dir, outputdir);
        }

        foreach (string filePath in Directory.EnumerateFiles(inputDir))
        {
            ProcessTables(filePath);

            //if (filePath.Contains("spells") && filePath.EndsWith(".md"))
            //{
            //    ProcessSpellFile(filePath, outputdir);
            //}

            //if (filePath.Contains("monsters") && filePath.EndsWith(".md"))
            //{
            //    ProcessMonsterFile(filePath, outputdir);
            //}
        }
    }

    /// <summary>
    /// Process tables in the file
    /// </summary>
    /// <param name="filePath">The filePath to create the file</param>
    private void ProcessTables(string filePath)
    {
        var markDown = File.ReadAllLines(filePath).ToList();
        
        IMarkDownTableModel model = ParseMarkdown?.ParseMarkDownTable(markDown);

        if (model != null && model.TableCaption.Any())
        {
            model.FilePath = filePath;
            MarkDownTableModels.Add(model);
        }
    }

    /// <summary>
    /// Process a spell file
    /// </summary>
    /// <param name="filePath">The filePath to create the file</param>
    private void ProcessSpellFile(string filePath, string outputDir)
    {
        var markDown = File.ReadAllLines(filePath).ToList();

        // Convert the file to .html
        if (markDown.Count >= 3)
        {
            var spell = ParseMarkdown?.ParseSpell(markDown);
            if (spell == null || string.IsNullOrEmpty(spell.Name))
            {
                Console.WriteLine($"Skipping file {filePath}");
                return;
            }

            // Convert the file to .html
            var htmlFile = $@"{outputDir}html\spells\{spell.Name}.html";
            Console.WriteLine($"Generating .html spell file {htmlFile}");
            using (StreamWriter writer = File.CreateText(htmlFile))
            {
                GenerateHtml.GenerateSpellHtmlFiles(writer, spell);
            }

            // Convert the file to a .cs interface
            var classFile = $@"{outputDir}models\spells\{spell.Name}.cs";
            using (StreamWriter writer = File.CreateText(classFile))
            {
                GenerateModel.GenerateSpellClass(writer, spell, outputDir);
            }
        }
    }

    /// <summary>
    /// Process a monster file
    /// </summary>
    /// <param name="filePath">The filePath to create the file</param>
    private void ProcessMonsterFile(string filePath, string outputDir)
    {
        var markDown = File.ReadAllLines(filePath).ToList();

        // Convert the file to .html
        if (markDown.Count >= 3)
        {
            var creature = ParseMarkdown.ParseMonster(markDown);
            if (creature == null || string.IsNullOrEmpty(creature.Name))
            {
                Console.WriteLine($"Skipping file {filePath}");
                return;
            }

            // Convert the file to .html
            var htmlFile = $@"{outputDir}Html\monsters\{creature.Name}.html";
            Console.WriteLine($"Generating .html file {htmlFile}");
            using (StreamWriter writer = File.CreateText(htmlFile))
            {
                GenerateHtml.GenerateMonsterHtmlFiles(writer, creature);
            }

            // Convert the file to a .cs interface
            var classFile = $@"{outputDir}Models\monsters\{creature.Name}.cs";
            using (StreamWriter writer = File.CreateText(classFile))
            {
                GenerateModel.GenerateMonsterClass(writer, creature, outputDir);
            }
        }
    }
}
