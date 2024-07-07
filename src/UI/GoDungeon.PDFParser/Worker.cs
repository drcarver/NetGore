using GoDungeon.PDFParser.interfaces;

namespace GoDungeon.PDFParser;

public class Worker : BackgroundService
{
    /// <summary>
    /// The logger
    /// </summary>
    private readonly ILogger<Worker> _logger;

    /// <summary>
    /// The 5e SRD parser
    /// </summary>
    private readonly IProcessPDFFiles ProcessPDFFiles;

    /// <summary>
    /// Const for the monster directory
    /// </summary>
    public const string inputPDF = $@"C:\Users\drcarver\Desktop\NetGore\src\UI\GoDungeon.PDFParser\docs\D&D 5E - Dungeon Master's Guide.pdf";

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger">The logger</param>
    public Worker(ILogger<Worker> logger, IProcessPDFFiles processPDFFiles)
    {
        _logger = logger;
        this.ProcessPDFFiles = processPDFFiles;
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
        ProcessPDFFiles.ExtractTables(inputPDF);
    }
}
