using CsvHelper;

using NetGore.Core.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ConvertCSVToTable;

internal class Program
{
    const string traitfilename = @"C:\Users\drcarver\Desktop\NetGore\Tools\ConvertCSVToTable\Traits.json";
    const string traitcsvfile = @"C:\Users\drcarver\Desktop\netgore\documents\Traits.csv";
    const string traitlistfile = @"C:\Users\drcarver\Desktop\NetGore\Tools\ConvertCSVToTable\TraitList.cs";
    const string traitenumfile = @"C:\Users\drcarver\Desktop\NetGore\Tools\ConvertCSVToTable\TraitEnum.cs";

    static void Main(string[] args)
    {
        var csv = new CSVServices();
        var traitlist = csv.ReadTraitFile(traitcsvfile);

        //var traitcategory = new List<string>();
        //foreach (var trait in traitlist)
        //{
        //    if (!traitcategory.Contains(trait.Category))
        //    {
        //        Console.WriteLine(trait.Category);
        //        traitcategory.Add(trait.Category);
        //    }
        //}

        var traittype = new List<string>();
        foreach (var trait in traitlist)
        {
            if (!traittype.Contains(trait.TraitType))
            {
                Console.WriteLine(trait.TraitType);
                traittype.Add(trait.TraitType);
            }
        }

        //var traitrace1 = new List<string>();
        //foreach (var trait in traitlist)
        //{
        //    if (!traitrace1.Contains(trait.ReqRace1))
        //    {
        //        Console.WriteLine(trait.ReqRace1);
        //        traitrace1.Add(trait.ReqRace1);
        //    }
        //}

        //var traitrace2 = new List<string>();
        //foreach (var trait in traitlist)
        //{
        //    if (!traitrace2.Contains(trait.ReqRace2))
        //    {
        //        Console.WriteLine(trait.ReqRace2);
        //        traitrace2.Add(trait.ReqRace2);
        //    }
        //}

        //var traitalign = new List<string>();
        //foreach (var trait in traitlist)
        //{
        //    if (!traitalign.Contains(trait.ReqAlign))
        //    {
        //        Console.WriteLine(trait.ReqAlign);
        //        traitalign.Add(trait.ReqAlign);
        //    }
        //}

        //var traitclass = new List<string>();
        //foreach (var trait in traitlist)
        //{
        //    if (!traitclass.Contains(trait.ReqClass))
        //    {
        //        Console.WriteLine(trait.ReqClass);
        //        traitclass.Add(trait.ReqClass);
        //    }
        //}

        //string json = JsonConvert.SerializeObject(traitlist.ToArray());

        ////serialize object into file stream
        //File.WriteAllText(traitfilename, json);
        //CreateTraitEnumFile(traitenumfile);
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
            writer.WriteLine($"\t\t#region Basic");
            writer.WriteLine();
            foreach (var trait in traitlist.Where(t => t.TraitType.Trim() == "Basic").OrderBy(o => Cleanup(o.Name)))
            {
                writer.WriteLine($"\t\t#region {trait.Name}");
                writer.WriteLine("\t\tnew Trait");
                writer.WriteLine("\t\t{");
                writer.WriteLine($"\t\t\tName = nameof(TraitEnum.{Cleanup(trait.Name)}),");
                writer.WriteLine($"\t\t\tProperName = \"{trait.Name.Replace("'", string.Empty).Replace("\n", " ").Trim()}\",");
                writer.WriteLine($"\t\t\tURL = new Uri(\"{trait?.URL.Trim()}\"),");
                writer.WriteLine($"\t\t\tDescription = \"{trait.Description.Replace("\"", "'").Replace("\n", " ").Trim()})\",");
                writer.WriteLine("\t\t},");
                writer.WriteLine("\t\t#endregion");
                writer.WriteLine();
            }
            writer.WriteLine();
            writer.WriteLine($"\t\t#endregion");
            writer.WriteLine("\t};");
            writer.WriteLine("}");
        }
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

    private static string Cleanup(string name)
    {
        return name
        .Replace(" ", string.Empty)
        .Replace("'", string.Empty)
        .Replace("\n", string.Empty)
        .Replace("/", string.Empty)
        .Replace("-", string.Empty)
        .Replace("’", string.Empty)
        .Replace(",", string.Empty)
        .Replace("(", string.Empty)
        .Replace(")", string.Empty)
        .Replace("[", string.Empty)
        .Replace("]", string.Empty);
    }
}
