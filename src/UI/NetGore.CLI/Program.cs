using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using D20.Character;
using D20.Core;
using D20.Goods;
using D20.MagicItems;
using D20.Monsters;
using D20.Spells;

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
    .UseD20Core()
    .UseD20Character()
    //.UseD20Data()
    .UseD20Goods()
    .UseD20MagicItems()
    .UseD20Monsters()
    .UseD20Spells()
    .BuildServiceProvider();

var logger = (services.GetService<ILoggerFactory>() 
        ?? throw new InvalidOperationException())
        .CreateLogger<Program>();

logger?.LogInformation($"Starting application at: {DateTime.Now}");
logger?.LogInformation($"Current Directory={Directory.GetCurrentDirectory()}");

//var gender = Gender.GetGender();

//var raceService = services.GetService<IRaceService>();

//var pc = services.GetService<IPlayerCharacter>();

// Try to create each race
//var classService = services.GetService<IClassService>();
//var characterService = services.GetService<ICharacterService>();
//if (characterService != null)
//{
//    var character = characterService.CreateCharacter();
//    classService?.SetClass(character);
//    var dwarf = new Dwarf(character);
//    dwarf.GenerateRaceBackground(character);

//    character = characterService.CreateCharacter();
//    classService?.SetClass(character);
//    var elf = new Elf(character);
//    elf.GenerateRaceBackground(character);

//    character = characterService.CreateCharacter();
//    classService?.SetClass(character);
//    var gnome = new Gnome(character);
//    gnome.GenerateRaceBackground(character);

//    character = characterService.CreateCharacter();
//    classService?.SetClass(character);
//    var halfelf = new HalfElf(character);
//    halfelf.GenerateRaceBackground(character);

//    character = characterService.CreateCharacter();
//    classService?.SetClass(character);
//    var halfling = new Halfling(character);
//    halfling.GenerateRaceBackground(character);

//    character = characterService.CreateCharacter();
//    classService?.SetClass(character);
//    var halforc = new HalfOrc(character);
//    halforc.GenerateRaceBackground(character);

//    character = characterService.CreateCharacter();
//    classService?.SetClass(character);
//    var human = new Human(character);
//    human.GenerateRaceBackground(character);

//    character = characterService.CreateCharacter();
//    classService?.SetClass(character);
//    var tiefling = new Tiefling(character);
//    tiefling.GenerateRaceBackground(character);

//}