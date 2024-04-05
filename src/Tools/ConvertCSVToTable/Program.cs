using ConvertCSVToTable.Maps;

using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace ConvertCSVToTable;

internal class Program
{
    const string traitfilename = @"C:\Users\drcarver\Desktop\NetGore\Tools\ConvertCSVToTable\Traits.json";
    const string traitcsvfile = @"C:\Users\drcarver\Desktop\netgore\documents\Traits.csv";
    const string traitlistfile = @"C:\Users\drcarver\Desktop\NetGore\Tools\ConvertCSVToTable\TraitList.cs";
    const string traitenumfile = @"C:\Users\drcarver\Desktop\NetGore\Tools\ConvertCSVToTable\TraitEnum.cs";
    const string traitcategoryenumfile = @"C:\Users\drcarver\Desktop\NetGore\Tools\ConvertCSVToTable\TraitCategoryEnum.cs";
    const string traitplaceenumfile = @"C:\Users\drcarver\Desktop\NetGore\Tools\ConvertCSVToTable\TerrainEnum.cs";

    static void Main(string[] args)
    {
        var csv = new CSVServices();
        var traitlist = csv.ReadTraitFile(traitcsvfile);

        //var traitfield = new List<string>();
        //foreach (var trait in traitlist)
        //{
        //    if (!traitfield.Contains(trait.ReqPlace))
        //    {
        //        Console.WriteLine(trait.ReqPlace);
        //        traitfield.Add(trait.ReqPlace);
        //    }
        //}

        //string json = JsonConvert.SerializeObject(traitlist.ToArray());

        ////serialize object into file stream
        //File.WriteAllText(traitfilename, json);
        //CreateTraitEnumFile(traitenumfile);
        //CreateTraitCategoryEnumFile(traitcategoryenumfile);
        //CreateTraitPlaceEnumFile(traitplaceenumfile);
        CreateTraitListFile(traitlistfile);
    }

    /// <summary>
    /// Create a trait list cs file
    /// </summary>
    /// <param name="filename">the file to create</param>
    static void CreateTraitListFile(string filename)
    {
        var csv = new CSVServices();
        var traitlist = csv.ReadTraitFile(traitcsvfile);

        // Get the race enum as a string
        var racelist = new List<string>();
        foreach (var race in Enum.GetValues(typeof(RaceEnum)))
        {
            racelist.Add(race.ToString());
        }

        // Get the terrain enum as a string
        var terrainlist = new List<string>();
        foreach (var terrain in Enum.GetValues(typeof(TerrainEnum)))
        {
            terrainlist.Add(terrain.ToString());
        }

        using (StreamWriter writer = File.CreateText(filename))
        {
            writer.WriteLine("using NetGore.Core.Enum;");
            writer.WriteLine("using NetGore.Core.Models;");
            writer.WriteLine();
            writer.WriteLine("namespace NetGore.Core.Data;");
            writer.WriteLine();
            writer.WriteLine($"public class Traits");
            writer.WriteLine("{");
            writer.WriteLine("\tpublic static List<Trait> TraitList { get; set; } = new List<Trait>()");
            writer.WriteLine("\t{");

            foreach (var traittype in Enum.GetValues(typeof(TraitTypeEnum)))
            {
                writer.WriteLine($"\t\t#region {traittype.ToString()}");
                writer.WriteLine();
                foreach (var trait in traitlist.Where(t => t.TraitType.Trim() == traittype.ToString()).OrderBy(o => Cleanup(o.Name)))
                {
                    if (IncludeTrait(trait, racelist, terrainlist))
                    {
                        writer.WriteLine($"\t\t#region {trait.Name}");
                        writer.WriteLine("\t\tnew Trait");
                        writer.WriteLine("\t\t{");
                        writer.WriteLine($"\t\t\tName = nameof(TraitEnum.{Cleanup(trait.Name)}),");
                        writer.WriteLine($"\t\t\tProperName = \"{trait.Name.Replace("'", string.Empty).Replace("\n", " ").Trim()}\",");
                        if (!string.IsNullOrEmpty(Cleanup(trait.Category)))
                        {
                            writer.WriteLine($"\t\t\tCategory = TraitCategoryEnum.{Cleanup(trait.Category)},");
                        }
                        writer.WriteLine($"\t\t\tTraitType = TraitTypeEnum.Basic,");
                        if (!string.IsNullOrEmpty(trait.ReqClass))
                        {
                            writer.WriteLine($"\t\t\tCharacterClass = ClassEnum.{trait?.ReqClass},");
                        }
                        if (!string.IsNullOrEmpty(trait.ReqRace1)
                            && !racelist.Contains(Cleanup(trait.ReqRace1)))
                        {
                            writer.WriteLine($"\t\t\tRace = RaceEnum.{trait?.ReqRace1},");
                        }
                        if (!string.IsNullOrEmpty(trait.ReqPlace)
                            && terrainlist.Contains(Cleanup(trait.ReqPlace)))
                        {
                            writer.WriteLine($"\t\t\tTerrain = TerrainEnum.{Cleanup(trait?.ReqPlace)},");
                        }
                        if (! string.IsNullOrEmpty(trait?.URL.Trim()))
                        {
                            writer.WriteLine($"\t\t\tURL = new Uri(\"{trait?.URL.Trim()}\"),");
                        }
                        writer.WriteLine($"\t\t\tDescription = \"{trait.Description.Replace("\"", "'").Replace("\n", " ").Trim()})\",");
                        writer.WriteLine("\t\t},");
                        writer.WriteLine("\t\t#endregion");
                        writer.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Ignoring {trait.Name} - Race={trait.ReqRace1} - Terrain={trait.ReqPlace}");
                    }
                }
                writer.WriteLine();
                writer.WriteLine($"\t\t#endregion");
                writer.WriteLine();
            }
            writer.WriteLine("\t};");
            writer.WriteLine("}");
            writer.Flush();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="trait"></param>
    /// <param name="racelist"></param>
    /// <param name="terrainlist"></param>
    /// <returns></returns>
    static bool IncludeTrait(TraitCSV trait, List<string> racelist,
        List<string> terrainlist)
    {
        var cleanrace = Cleanup(trait.ReqRace1);
        var cleanplace = Cleanup(trait.ReqPlace);
        if ((racelist.Contains(cleanrace) || string.IsNullOrEmpty(cleanrace))
            && (terrainlist.Contains(cleanplace) || string.IsNullOrEmpty(cleanplace))
            && Cleanup(trait.Name) != "PAGEMISSING")
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// Create a trait enum cs file
    /// </summary>
    /// <param name="filename">the file to create</param>
    static void CreateTraitEnumFile(string filename)
    {
        var csv = new CSVServices();
        var traitlist = csv.ReadTraitFile(traitcsvfile);

        var enums = new List<string>();
        using (StreamWriter writer = File.CreateText(filename))
        {
            writer.WriteLine("namespace NetGore.Core.Enum;");
            writer.WriteLine();
            writer.WriteLine($"public enum TraitEnum");
            writer.WriteLine("{");

            // Basic Region
            writer.WriteLine($"\t#region Basic");
            writer.WriteLine();
            int counter = 0;
            foreach (var trait in traitlist.Where(t => t.TraitType.Trim() == "Basic").OrderBy(o => Cleanup(o.Name)))
            {
                var name = Cleanup(trait.Name);
                if (!enums.Contains(name))
                {
                    writer.WriteLine($"\t{name} = {counter},");
                    enums.Add(name);
                    counter++;
                }
            }
            writer.WriteLine();
            writer.WriteLine($"\t#endregion");
            writer.WriteLine();

            // Campaign Region
            writer.WriteLine($"\t#region Campaign");
            writer.WriteLine();
            foreach (var trait in traitlist.Where(t => t.TraitType.Trim() == "Campaign").OrderBy(o => Cleanup(o.Name)))
            {
                var name = Cleanup(trait.Name);
                if (!enums.Contains(name))
                {
                    writer.WriteLine($"\t{name} = {counter},");
                    enums.Add(name);
                    counter++;
                }
            }
            writer.WriteLine();
            writer.WriteLine($"\t#endregion");
            writer.WriteLine();

            // Campaign Region
            writer.WriteLine($"\t#region Equipment");
            writer.WriteLine();
            foreach (var trait in traitlist.Where(t => t.TraitType.Trim() == "Equipment").OrderBy(o => Cleanup(o.Name)))
            {
                var name = Cleanup(trait.Name);
                if (!enums.Contains(name))
                {
                    writer.WriteLine($"\t{name} = {counter},");
                    enums.Add(name);
                    counter++;
                }
            }
            writer.WriteLine();
            writer.WriteLine($"\t#endregion");
            writer.WriteLine();

            // Faction Region
            writer.WriteLine($"\t#region Faction");
            writer.WriteLine();
            foreach (var trait in traitlist.Where(t => t.TraitType.Trim() == "Faction").OrderBy(o => Cleanup(o.Name)))
            {
                var name = Cleanup(trait.Name);
                if (!enums.Contains(name))
                {
                    writer.WriteLine($"\t{name} = {counter},");
                    enums.Add(name);
                    counter++;
                }
            }
            writer.WriteLine();
            writer.WriteLine($"\t#endregion");
            writer.WriteLine();

            // Race Region
            writer.WriteLine($"\t#region Race");
            writer.WriteLine();
            foreach (var trait in traitlist.Where(t => t.TraitType.Trim() == "Race").OrderBy(o => Cleanup(o.Name)))
            {
                var name = Cleanup(trait.Name);
                if (!enums.Contains(name))
                {
                    writer.WriteLine($"\t{name} = {counter},");
                    enums.Add(name);
                    counter++;
                }
            }
            writer.WriteLine();
            writer.WriteLine($"\t#endregion");
            writer.WriteLine();

            // Regional Region
            writer.WriteLine($"\t#region Regional");
            writer.WriteLine();
            foreach (var trait in traitlist.Where(t => t.TraitType.Trim() == "Regional").OrderBy(o => Cleanup(o.Name)))
            {
                var name = Cleanup(trait.Name);
                if (!enums.Contains(name))
                {
                    writer.WriteLine($"\t{name} = {counter},");
                    enums.Add(name);
                    counter++;
                }
            }
            writer.WriteLine();
            writer.WriteLine($"\t#endregion");
            writer.WriteLine();

            // Religion Region
            writer.WriteLine($"\t#region Religion");
            writer.WriteLine();
            foreach (var trait in traitlist.Where(t => t.TraitType.Trim() == "Religion").OrderBy(o => Cleanup(o.Name)))
            {
                var name = Cleanup(trait.Name);
                if (!enums.Contains(name))
                {
                    writer.WriteLine($"\t{name} = {counter},");
                    enums.Add(name);
                    counter++;
                }
            }
            writer.WriteLine();
            writer.WriteLine($"\t#endregion");
            writer.WriteLine();

            // Social Region
            writer.WriteLine($"\t#region Social");
            writer.WriteLine();
            foreach (var trait in traitlist.Where(t => t.TraitType.Trim() == "Social").OrderBy(o => Cleanup(o.Name)))
            {
                var name = Cleanup(trait.Name);
                if (!enums.Contains(name))
                {
                    writer.WriteLine($"\t{name} = {counter},");
                    enums.Add(name);
                    counter++;
                }
            }
            writer.WriteLine();
            writer.WriteLine($"\t#endregion");
            writer.WriteLine();

            writer.WriteLine("}");
            writer.Flush();
        }
    }

    /// <summary>
    /// Create a trait category enum cs file
    /// </summary>
    /// <param name="filename">the file to create</param>
    static void CreateTraitCategoryEnumFile(string filename)
    {
        var csv = new CSVServices();
        var traitlist = csv.ReadTraitFile(traitcsvfile);

        var enumlist = new List<string>();
        using (StreamWriter writer = File.CreateText(filename))
        {
            foreach (var trait in traitlist.OrderBy(o => o.Category))
            {
                if (!enumlist.Contains(Cleanup(trait.Category))
                    && !string.IsNullOrEmpty(trait.Category))
                {
                    enumlist.Add(Cleanup(trait.Category));
                }
            }
            writer.WriteLine("namespace NetGore.Core.Enum;");
            writer.WriteLine();
            writer.WriteLine($"public enum TraitCategoryEnum");
            writer.WriteLine("{");

            int counter = 0;
            foreach (var traitenum in enumlist)
            {
                writer.WriteLine($"\t{traitenum} = {counter},");
                counter++;
            }

            writer.WriteLine("}");
            writer.Flush();
        }
    }

    /// <summary>
    /// Create a trait place (terrain?) enum cs file
    /// </summary>
    /// <param name="filename">the file to create</param>
    static void CreateTraitPlaceEnumFile(string filename)
    {
        var csv = new CSVServices();
        var traitlist = csv.ReadTraitFile(traitcsvfile);

        var enumlist = new List<string>();
        using (StreamWriter writer = File.CreateText(filename))
        {
            foreach (var trait in traitlist.OrderBy(o => o.ReqPlace))
            {
                if (!enumlist.Contains(Cleanup(trait.ReqPlace))
                    && !string.IsNullOrEmpty(trait.ReqPlace))
                {
                    enumlist.Add(Cleanup(trait.ReqPlace));
                }
            }
            writer.WriteLine("namespace NetGore.Core.Enum;");
            writer.WriteLine();
            writer.WriteLine($"public enum TerrainEnum");
            writer.WriteLine("{");

            int counter = 0;
            foreach (var traitenum in enumlist)
            {
                if (string.IsNullOrEmpty(traitenum))
                {
                    writer.WriteLine($"\tAny = {counter},");
                }
                if (traitenum != "Forest"
                    || traitenum != "Mountain"
                    || traitenum != "Desert")
                {
                    writer.WriteLine($"\t{traitenum} = {counter},");
                }
                counter++;
            }

            writer.WriteLine("}");
            writer.Flush();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    static string Cleanup(string name)
    {
        return name
        .Replace(" ", string.Empty)
        .Replace("'", string.Empty)
        .Replace("\n", string.Empty)
        .Replace("/", string.Empty)
        .Replace("-", string.Empty)
        .Replace("’", string.Empty)
        .Replace(",", string.Empty)
        .Replace("&", string.Empty)
        .Replace("(", string.Empty)
        .Replace(")", string.Empty)
        .Replace("[", string.Empty)
        .Replace("]", string.Empty)
        .Trim();
    }
}