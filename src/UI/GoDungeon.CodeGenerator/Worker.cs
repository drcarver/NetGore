using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.Equipment.Tables;
using GoDungeon.MagicItems.Enum;

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

        for (int level = 1; level <= 20; level++)
        {
            var commonTotal = 100 - ((level - 1) * ((int)ItemAvailabilityEnum.Common));// - (level * ((int)ItemAvailabilityEnum.Common));
            _logger.LogInformation($"level {level}: {ItemAvailabilityEnum.Common.ToString()} = {commonTotal}");
            //var uncommonTotal = (((int)ItemAvailabilityEnum.Uncommon) * (level - 1)); // - (level * ((int)ItemAvailabilityEnum.Uncommon));
            //_logger.LogInformation($"level {level}: {ItemAvailabilityEnum.Uncommon.ToString()} = {uncommonTotal}");
            //var rareTotal = (((int)ItemAvailabilityEnum.Rare) * (level - 1)); // - (level * ((int)ItemAvailabilityEnum.Rare));
            //_logger.LogInformation($"level {level}: {ItemAvailabilityEnum.Rare.ToString()} = {rareTotal}");
            //var veryRareTotal = (((int)ItemAvailabilityEnum.VeryRare) * (level - 1)); // - (level * ((int)ItemAvailabilityEnum.VeryRare));
            //_logger.LogInformation($"level {level}: {ItemAvailabilityEnum.VeryRare.ToString()} = {veryRareTotal}");
            //var artifactTotal = (((int)ItemAvailabilityEnum.Artifact) * (level - 1)); // - (level * ((int)ItemAvailabilityEnum.Artifact));
            //_logger.LogInformation($"level {level}: {ItemAvailabilityEnum.Artifact.ToString()} = {artifactTotal}");
            //_logger.LogInformation($"level Total {commonTotal + uncommonTotal + rareTotal + veryRareTotal + artifactTotal}");
        }

        process5ESRDFiles.ParseMarkdownDirectory(inputDir);
        process5ESRDFiles.GenerateModel.GenerateNetStandardModel(outputDir, process5ESRDFiles.ParseMarkdown);
        process5ESRDFiles.GenerateModel.GenerateMAUIModel(outputDir, process5ESRDFiles.ParseMarkdown);
        process5ESRDFiles.GenerateHtml.GenerateHtmlFiles(outputDir, process5ESRDFiles.ParseMarkdown);

        //var table = new AdventuringGearTable();
        //table.InitializeTable();
        //var json = Newtonsoft.Json.JsonConvert.SerializeObject(table);
        //File.WriteAllText($"{outputDir}/AdventuringGearTable.json", json);
    }
}
