using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using NetGore.Core;
using NetGore.Core.Abilities;
using NetGore.Core.Data;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data;
using NetGore.Data.Interfaces;
using NetGore.Data.Race;
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
    .AddSingleton<IRaceService, RaceService>()
    .AddSingleton<ICharacterService, CharacterService>()
    .AddSingleton<IClassService, ClassService>()
    .AddSingleton<IPlayerCharacter, PlayerCharacter>()
    .AddDbContextPool<NETGoreDbContext>(options =>
        options.UseSqlite(configuration.GetConnectionString("DefaultConnection")))
    .BuildServiceProvider();

var logger = (services.GetService<ILoggerFactory>() 
        ?? throw new InvalidOperationException())
        .CreateLogger<Program>();

logger?.LogInformation($"Starting application at: {DateTime.Now}");
logger?.LogInformation($"Current Directory={Directory.GetCurrentDirectory()}");

if (logger != null)
{
    var ability = new Strength(logger);
    logger?.LogInformation(new Dice("1d10").ToString());
    logger?.LogInformation(new Dice("1d20").ToString());
}

var gender = GenderData.GetGender();

var raceService = services.GetService<IRaceService>();

var pc = services.GetService<IPlayerCharacter>();


// Try to create each race
var classService = services.GetService<IClassService>();
var characterService = services.GetService<ICharacterService>();
if (characterService != null)
{
    var character = characterService.CreateCharacter();
    classService?.SetClass(character);
    var dwarf = new Dwarf(character);
    dwarf.GenerateRaceBackground(character);

    character = characterService.CreateCharacter();
    classService?.SetClass(character);
    var elf = new Elf(character);
    elf.GenerateRaceBackground(character);

    character = characterService.CreateCharacter();
    classService?.SetClass(character);
    var gnome = new Gnome(character);
    gnome.GenerateRaceBackground(character);

    character = characterService.CreateCharacter();
    classService?.SetClass(character);
    var halfelf = new HalfElf(character);
    halfelf.GenerateRaceBackground(character);

    character = characterService.CreateCharacter();
    classService?.SetClass(character);
    var halfling = new Halfling(character);
    halfling.GenerateRaceBackground(character);

    character = characterService.CreateCharacter();
    classService?.SetClass(character);
    var halforc = new HalfOrc(character);
    halforc.GenerateRaceBackground(character);

    character = characterService.CreateCharacter();
    classService?.SetClass(character);
    var human = new Human(character);
    human.GenerateRaceBackground(character);

    character = characterService.CreateCharacter();
    classService?.SetClass(character);
    var tiefling = new Tiefling(character);
    tiefling.GenerateRaceBackground(character);

}

// Example Service
//var service = services.GetService<IExampleService>();
//    service?.AddExample("Test A");
//    service?.AddExample("Test B");
//    service?.AddExample("Test C");
//    service?.GetExamples();