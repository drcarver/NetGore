using GoDungeon.CodeGenerator.Interfaces;

namespace GoDungeon.CodeGenerator;

public class Worker : BackgroundService
{
    /// <summary>
    /// The logger
    /// </summary>
    private readonly ILogger<Worker> _logger;

    /// <summary>
    /// The 5e SRD parser
    /// </summary>
    private readonly IProcess5ESRDFiles process5ESRDFiles;

    /// <summary>
    /// Const for the monster directory
    /// </summary>
    public const string outputDir = $@"C:\Users\drcarver\Desktop\Srd5E\";

    /// <summary>
    /// Const for the monster directory
    /// </summary>
    public const string inputDir = $@"C:\Users\drcarver\Desktop\NetGore\src\UI\GoDungeon.CodeGenerator\docs";

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger">The logger</param>
    public Worker(ILogger<Worker> logger, IProcess5ESRDFiles process5ESRDFiles)
    {
        _logger = logger;
        this.process5ESRDFiles = process5ESRDFiles;
    }

    /// <summary>
    /// The task background task
    /// </summary>
    /// <param name="stoppingToken">The token for stopping the task</param>
    /// <returns>The task</returns>
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (_logger.IsEnabled(LogLevel.Information))
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        }
        process5ESRDFiles.ProcessDirectory(inputDir, outputDir);

        // process the GoDungeon files
        foreach (var model in process5ESRDFiles.GenerateModel.GoDungeonModelList)
        {
            using (var stream = File.CreateText(model.FileName))
            {
                process5ESRDFiles.GenerateModel.GenerateServicesCollectionExtension(stream, model);
            }
        }

        //var table = new AdventuringGearTable();
        //table.InitializeTable();
        //var json = Newtonsoft.Json.JsonConvert.SerializeObject(table);
        //File.WriteAllText($"{outputDir}/AdventuringGearTable.json", json);

        //process5ESRDFiles.GenerateModel.GenerateSpellLists(
        //    process5ESRDFiles.ParseMarkdown.SpellInfoList, outputDir); 
    }
}
