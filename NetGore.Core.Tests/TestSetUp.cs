using Microsoft.Extensions.Logging;

namespace NetGore.Core.Tests;

[SetUpFixture]
public class TestSetUp
{
    public static ILoggerFactory Logger { get; set; }

    /// <summary>
    /// Initializes the <see cref="EngineSettings"/> for tests that require it.
    /// </summary>
    [OneTimeSetUp]
    public void SetUpCoreSettings()
    {
        Logger = LoggerFactory.Create(builder =>
        {
            builder.AddFilter("Microsoft", LogLevel.Warning)
                   .AddFilter("System", LogLevel.Warning)
                   .AddDebug();
        });
    }

    [OneTimeTearDown]
    public void TearDownCoreSettings()
    {
        Logger?.Dispose();
    }
}
