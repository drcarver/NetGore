using GoDungeon.CodeGenerator.Interfaces;

namespace GoDungeon.CodeGenerator.CodeGen;

public partial class GenerateModel : IGenerateModel
{
    /// <summary>
    /// Generate the .cs class for the spell
    /// </summary>
    /// <param name="dirPath">The directory for the table</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="properties">The list of properties for the view model</param>
    /// <param name="rows">The rows for the table</param>
    /// <param name="nameSpace">The namespace for the table</param>
    public void GenerateTable(string dirPath, string tableName, List<string> properties, List<string> rows, string nameSpace)
    {
        var dirName = @$"{dirPath}/{nameSpace}/table";
        Directory.CreateDirectory(dirName);
        string fileName = $"{dirName}/{Utilities.CleanupForCSharp(tableName)}Table.cs";
        using (var stream = File.CreateText(fileName))
        {
            GenerateTableHeading(stream, tableName, rows, nameSpace);
        }
    }

    /// <summary>
    /// Generate the table heading
    /// </summary>
    /// <param name="tableName">The name of the table</param>
    /// <param name="tableDescription">The description of the table</param>
    /// <param name="rows">The rows in the table</param>
    private void GenerateTableHeading(TextWriter stream, string tableName, List<string> rows, string nameSpace)
    {
        var csName = Utilities.CleanupForCSharp(tableName);

        stream.WriteLine("//");
        stream.WriteLine($"// {tableName}");
        stream.WriteLine("//");
        stream.WriteLine("using System.Collections.ObjectModel;");
        stream.WriteLine();
        stream.WriteLine("using GoDungeon.Core.Enum;");
        stream.WriteLine("using GoDungeon.Core.Interfaces;");
        stream.WriteLine("using GoDungeon.Core.Tables;");
        stream.WriteLine("using GoDungeon.Core.ViewModels;");
        stream.WriteLine();
        stream.WriteLine("using GoDungeon.Spells.Enum;");
        stream.WriteLine("using GoDungeon.Spells.Interfaces;");
        stream.WriteLine("using GoDungeon.Spells.ViewModels;");
        stream.WriteLine();
        stream.WriteLine("using Microsoft.Extensions.Logging;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.{nameSpace}.Tables;");
        stream.WriteLine();
        stream.WriteLine("/// <summary>");
        stream.WriteLine($"/// {tableName}");
        stream.WriteLine("/// </summary>");
        stream.WriteLine($"public partial class {csName}Table : NamedTable, I{csName}");
        stream.WriteLine("{");
        stream.WriteLine("\t/// <summary>");
        stream.WriteLine("\t/// Constructor");
        stream.WriteLine("\t/// </summary>");
        stream.WriteLine($"\tpublic {csName}Table()");
        stream.WriteLine("\t{");
        stream.WriteLine($"\t\tName = nameof({csName}Table);");
        stream.WriteLine($"\t\tProperName = \"{tableName} Table\";");
        stream.WriteLine($"\t\tTableType = TableTypeEnum.GamingTable;");
        stream.WriteLine($"\t\tDescription = \"{tableName}\";");
        stream.WriteLine("\t}");
        stream.WriteLine();
        stream.WriteLine("\t/// <summary>");
        stream.WriteLine("\t/// Initialize the table.  This is a separate method so");
        stream.WriteLine("\t/// we can create a game table for it's meta properties");
        stream.WriteLine("\t/// with out creating the actual table values.  A bit of");
        stream.WriteLine("\t/// optimization to conserve memory on big tables");
        stream.WriteLine("\t/// </summary>");
        stream.WriteLine("\tpublic override void InitializeTable()");
        stream.WriteLine("\t{");
        stream.WriteLine("\t\tif (Table == null || Table.Count == 0)");
        stream.WriteLine("\t\t{");
    }

    /// <summary>
    /// Generate the table enum
    /// </summary>
    /// <param name="rows">THe table rows for the enumeration</param>
    /// <param name="rows">THe table name enumeration</param>
    private void GenerateTableEnum(List<string> rows, string tableName, string rootDir)
    {
        // Convert the monster list to a .cs enum
        var csName = Utilities.CleanupForCSharp(tableName);
        var EnumFile = $@"{rootDir}tables/enum]/{csName}Enum.cs";
        using (StreamWriter writer = File.CreateText(EnumFile))
        {
            writer.WriteLine("//");
            writer.WriteLine($"// The {tableName} enumeration");
            writer.WriteLine("//");
            writer.WriteLine();
            writer.WriteLine("namespace GoDungeon.Tables.Enum");
            writer.WriteLine("{");
            writer.WriteLine();
            writer.WriteLine($"public enum {csName} Enum : int");
            writer.WriteLine("{");
            for (int i = 0; i < rows.Count(); i++)
            {
                writer.WriteLine($"\t{Utilities.CleanupForCSharp(rows[i].Trim())} = {i},");
            }
            writer.WriteLine("}");
        }
    }
}
