using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using NetGore.Core.Interfaces;
using NetGore.Data;
using NetGore.Data.Services;


// Configuration
var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
var configuration = builder.Build();

// Database
//var optionsBuilder = new DbContextOptionsBuilder<NETGoreDbContext>()
//    .UseSqlite(configuration.GetConnectionString("DefaultConnection"));

//var context = new NETGoreDbContext(optionsBuilder.Options);

//context.Database.EnsureDeleted();
//context.Database.EnsureCreated();

// Services
var services = new ServiceCollection()
    .AddLogging(loggingBuilder =>
    {
        loggingBuilder.AddConsole();
    })
    .AddSingleton(configuration)
    .AddSingleton<IExampleService, ExampleService>()
    .AddDbContextPool<NETGoreDbContext>(options =>
        options.UseSqlite(configuration.GetConnectionString("DefaultConnection")))
    .BuildServiceProvider();

var logger = (services.GetService<ILoggerFactory>() ?? throw new InvalidOperationException())
        .CreateLogger<Program>();

    logger.LogInformation($"Starting application at: {DateTime.Now}");
    logger.LogInformation($"Current Directory={Directory.GetCurrentDirectory()}");

// Example Service
var service = services.GetService<IExampleService>();
    service?.AddExample("Test A");
    service?.AddExample("Test B");
    service?.AddExample("Test C");
    service?.GetExamples();