using System;

using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.Equipment.Enum;

using Syncfusion.DocIO.DLS;

namespace GoDungeon.CodeGenerator.CodeGen;

public partial class GenerateModel : IGenerateModel
{
    /// <summary>
    /// Generate the .cs model class for the table
    /// </summary>
    /// <param name="dirPath">The directory for the table</param>
    /// <param name="filePath">The path to the markdown file</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="properties">The list of properties for the view model</param>
    /// <param name="rows">The rows for the table</param>
    /// <param name="nameSpace">The namespace for the table</param>
    public void GenerateTable(string dirPath, string filePath, string tableName, List<PropertyModel> properties, List<List<string>> rows, string nameSpace)
    {
        int sides = 0;
        string dirName;
        nameSpace = char.ToUpper(nameSpace[0]) + nameSpace.Substring(1);
        if (string.IsNullOrEmpty(properties[0].Name))
        {
            return;
        }
        if (properties[0].Name.Trim().StartsWith("d", StringComparison.OrdinalIgnoreCase))
        {
            switch (properties[0].Name)
            {
                case "d100":
                case "d20":
                case "d12":
                case "d10":
                case "d8":
                case "d6":
                case "d4":
                    sides = Convert.ToInt32(properties[0].Name.ToLower().Replace("d", string.Empty));
                    properties[0].Name = "Range";
                    properties[0].Value = "Range";
                    break;
                default:
                    sides = 0;
                    break;
            }
        }

        // The directory and file name
        dirName = @$"{dirPath}/{nameSpace}/Tables";
        Directory.CreateDirectory(dirName);
        string fileName = $"{dirName}/{Utilities.CleanupForCSharp(tableName)}Table.cs";
        using (var stream = File.CreateText(fileName))
        {
            GenerateTableHeading(stream, filePath, tableName, nameSpace, sides);
            GenerateTableBody(stream, tableName, properties, rows, sides);
        }

        // The directory and file name
        dirName = @$"{dirPath}/{nameSpace}/Enum";
        Directory.CreateDirectory(dirName);
        fileName = $"{dirName}/{Utilities.CleanupForCSharp(tableName)}Enum.cs";
        using (var stream = File.CreateText(fileName))
        {
            GenerateTableEnum(stream, tableName, properties, rows, nameSpace);
        }

        // The directory and file name
        dirName = @$"{dirPath}/{nameSpace}/Interfaces";
        Directory.CreateDirectory(dirName);
        fileName = $"{dirName}/I{Utilities.CleanupForCSharp(tableName)}Table.cs";
        using (var stream = File.CreateText(fileName))
        {
            GenerateTableInterface(stream, tableName, nameSpace, sides);
        }

        // The directory and file name
        dirName = @$"{dirPath}/{nameSpace}/ViewModels";
        Directory.CreateDirectory(dirName);
        fileName = $"{dirName}/{Utilities.CleanupForCSharp(tableName)}TableEntryViewModel.cs";
        using (var stream = File.CreateText(fileName))
        {
            GenerateTableEntryViewModel(stream, tableName, nameSpace, properties, sides);
        }

        // The directory and file name
        dirName = @$"{dirPath}/{nameSpace}/Interfaces";
        Directory.CreateDirectory(dirName);
        fileName = $"{dirName}/I{Utilities.CleanupForCSharp(tableName)}TableEntry.cs";
        using (var stream = File.CreateText(fileName))
        {
            GenerateTableEntryViewModelInterface(stream, tableName, nameSpace, properties, sides);
        }

        // The directory and file name
        dirName = @$"{dirPath}/{nameSpace}/Tests";
        Directory.CreateDirectory(dirName);
        fileName = $"{dirName}/{Utilities.CleanupForCSharp(tableName)}TableTest.cs";
        using (var stream = File.CreateText(fileName))
        {
            GenerateTableTest(stream, tableName, nameSpace, properties, rows, sides);
        }
    }

    /// <summary>
    /// Generate the .cs test file for the table
    /// </summary>
    /// <param name="stream">The test file stream</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="nameSpace">The namespace for the table</param>
    /// <param name="properties">The properties of the table view model</param>
    /// <param name="rows">The number of rows in the table</param>
    /// <param name="sides">The number of sides to for a dice roll on a random table</param>
    public void GenerateTableTest(TextWriter stream, string tableName, string nameSpace, List<PropertyModel> properties, List<List<string>> rows, int sides)
    {
        if (sides > 0)
        {
            return;
        }

        var csTableName = Utilities.CleanupForCSharp(tableName);

        stream.WriteLine("//");
        stream.WriteLine($"// {tableName} Table tests");
        stream.WriteLine("//");
        stream.WriteLine("using System;");
        stream.WriteLine();
        stream.WriteLine($"using GoDungeon.{nameSpace}.Enum;");
        stream.WriteLine($"using GoDungeon.{nameSpace}.Interfaces;");
        stream.WriteLine($"using GoDungeon.{nameSpace}.Tables;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.Tests.{nameSpace}.Tables;");
        stream.WriteLine();
        stream.WriteLine($"public partial class {nameSpace}TableTests");
        stream.WriteLine("{");
        stream.WriteLine($"\t[TestMethod]");
        stream.WriteLine($"\tpublic void {nameSpace}{csTableName}TableTests()");
        stream.WriteLine("\t{");
        stream.WriteLine($"\t\tI{csTableName}Table testTable = new {csTableName}Table();");
        stream.WriteLine($"\t\ttestTable.InitializeTable();");
        stream.WriteLine($"\t\tAssert.IsTrue(testTable.Name == nameof({csTableName}Table));");
        stream.WriteLine($"\t\tAssert.IsTrue(testTable.ProperName == \"{tableName} Table\");");
        stream.WriteLine($"\t\tAssert.IsTrue(testTable.Description == \"{tableName}\");");
        stream.WriteLine($"\t\tAssert.IsTrue(testTable.Table.Count() == {rows.Count()});");
        stream.WriteLine($"\t\tforeach (var item in System.Enum.GetValues(typeof({tableName}Enum)))");
        stream.WriteLine("\t\t{");
        stream.WriteLine($"\t\t\tI{tableName}TableEntry entry = (I{tableName}TableEntry) testTable.GetEntryByName(item.ToString());");
        stream.WriteLine($"\t\t\tAssert.IsNotNull(entry, $\"The {tableName} table has no entry for {{item.ToString()}}\");");
        stream.WriteLine($"\t\t\tvar verify = Verify{tableName}TableEntry(item.ToString(), entry);");
        stream.WriteLine($"\t\t\tAssert.IsTrue(verify == string.Empty, verify);");
        stream.WriteLine("\t\t}");
        stream.WriteLine("\t}");
        stream.WriteLine();
        stream.WriteLine("\t/// <summary>");
        stream.WriteLine($"\t/// Verify a entry in the I{tableName}Table");
        stream.WriteLine("\t/// </summary>");
        stream.WriteLine("\t/// <param name=\"enumString\">The name of the entry as a string</param>");
        stream.WriteLine($"\t/// <param name=\"entry\">The I{tableName}TableEntry entry</param>");
        stream.WriteLine($"\t/// <returns>Empty when no test fails, otherwise a failure string.</returns>");
        stream.WriteLine($"\tprivate string Verify{tableName}TableEntry(string enumString, I{tableName}TableEntry entry)");
        stream.WriteLine("\t{");
        stream.WriteLine($"\t\t{tableName}Enum enumValue;");
        stream.WriteLine($"\t\tif (!System.Enum.TryParse(enumString, out enumValue))");
        stream.WriteLine("\t\t{");
        stream.WriteLine($"\t\t\treturn $\"Unable to convert {{enumString}} to a {tableName}TableEnum\";");
        stream.WriteLine("\t\t}");
        stream.WriteLine($"\t\tvar testBase = new {tableName}TableEntryViewModel();");
        stream.WriteLine("\t\tswitch (enumValue)");
        stream.WriteLine("\t\t{");
        foreach (var row in rows)
        {
            for (int i = 0; i < properties.Count(); i++)
            {
                stream.WriteLine($"\t\t\ttestBase.Name = {row[i][0]}");
            }
        }
        stream.WriteLine("\t\t\tdefault:");
        stream.WriteLine("\t\t\t\treturn $\"No Case for entry named {entry.Name}\";");
        stream.WriteLine("\t\t}");
        stream.WriteLine("\t}");
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate the .cs class for the table enum
    /// </summary>
    /// <param name="stream">The stream for the enum</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="nameSpace">The namespace for the table</param>
    /// <param name="properties">The properties for the view model</param>
    /// <param name="randomTable">Is it a random table?</param>
    private void GenerateTableEntryViewModelInterface(TextWriter stream, string tableName, string nameSpace, List<PropertyModel> properties, int sides)
    {
        var csName = Utilities.CleanupForCSharp(tableName);

        stream.WriteLine("//");
        stream.WriteLine($"// {tableName} view model interface");
        stream.WriteLine("//");
        stream.WriteLine("using CommunityToolkit.Mvvm.ComponentModel;");
        stream.WriteLine();
        stream.WriteLine("using GoDungeon.Core.Interfaces;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.{nameSpace}.Interfaces;");
        stream.WriteLine();
        stream.WriteLine("/// <summary>");
        stream.WriteLine($"/// I{tableName}");
        stream.WriteLine("/// </summary>");
        if (sides > 0)
        {
            stream.WriteLine($"public interface I{csName}TableEntry : IRandomTableEntry");
        }
        else
        {
            stream.WriteLine($"public interface I{csName}TableEntry : IStandardTableEntry");
        }
        stream.WriteLine("{");
        int propertiesStart = 0;
        if (sides > 0)
        {
            propertiesStart = 1;
        }
        for (int i = propertiesStart; i < properties.Count(); i++)
        {
            stream.WriteLine("\t/// <summary>");
            stream.WriteLine($"\t/// {properties[i].Name}");
            stream.WriteLine("\t/// </summary>");
            stream.WriteLine($"\tpublic {properties[i].Value} {Utilities.CleanupForCSharp(properties[i].Name)} {{ get; set; }}");
            stream.WriteLine();
        }
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate the .cs class for the table enum
    /// </summary>
    /// <param name="stream">The stream for the enum</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="nameSpace">The namespace for the table</param>
    /// <param name="properties">The properties for the view model</param>
    /// <param name="sides">the number of sides to the dice in a random table?</param>
    private void GenerateTableEntryViewModel(TextWriter stream, string tableName, string nameSpace, List<PropertyModel> properties, int sides)
    {
        var csName = Utilities.CleanupForCSharp(tableName);

        stream.WriteLine("//");
        stream.WriteLine($"// {tableName} view model");
        stream.WriteLine("//");
        stream.WriteLine($"using CommunityToolkit.Mvvm.ComponentModel;");
        stream.WriteLine();
        stream.WriteLine($"using GoDungeon.Core.Interfaces;");
        stream.WriteLine($"using GoDungeon.Core.ViewModels;");
        stream.WriteLine();
        stream.WriteLine($"using GoDungeon.{nameSpace}.Interfaces;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.{nameSpace}.ViewModels;");
        stream.WriteLine();
        stream.WriteLine("/// <summary>");
        stream.WriteLine($"/// {tableName}");
        stream.WriteLine("/// </summary>");
        if (sides > 0)
        {
            stream.WriteLine($"public partial class {csName}TableEntryViewModel : RandomTableEntryViewModel, I{csName}TableEntry");
        }
        else
        {
            stream.WriteLine($"public partial class {csName}TableEntryViewModel : StandardTableEntryViewModel, I{csName}TableEntry");
        }
        stream.WriteLine("{");
        int propertiesStart = 0;
        if (sides > 0)
        {
            propertiesStart = 1;
        }
        for (int i = propertiesStart; i < properties.Count(); i++)
        {
            stream.WriteLine("\t/// <summary>");
            stream.WriteLine($"\t/// {properties[i].Name}");
            stream.WriteLine("\t/// </summary>");
            stream.WriteLine("\t[ObservableProperty]");
            string fieldname = Utilities.CleanupForCSharp(properties[i].Name);
            stream.WriteLine($"\tprivate {properties[i].Value} {char.ToLower(fieldname[0]) + fieldname.Substring(1)};");
            stream.WriteLine();
        }
        stream.WriteLine($"\tpublic {csName}TableEntryViewModel");
        stream.WriteLine("\t(");
        for (int i = propertiesStart; i < properties.Count(); i++)
        {
            string paramName = Utilities.CleanupForCSharp(properties[i].Name);
            stream.WriteLine($"\t\t{paramName} {char.ToLower(paramName[0]) + paramName.Substring(1)},");
            stream.WriteLine();
        }
        stream.WriteLine("\t)");
        stream.WriteLine("\t{");
        stream.WriteLine("\t}");
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate the .cs class for the table enum
    /// </summary>
    /// <param name="stream">The stream for the enum</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="nameSpace">The namespace for the table</param>
    /// <param name="randomTable">Is it a random table?</param>
    private void GenerateTableInterface(TextWriter stream, string tableName, string nameSpace, int sides)
    {
        var csName = Utilities.CleanupForCSharp(tableName);

        stream.WriteLine("//");
        stream.WriteLine($"// {tableName}");
        stream.WriteLine("//");
        stream.WriteLine($"using GoDungeon.Core.Interfaces;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.{nameSpace}.Interfaces;");
        stream.WriteLine();
        stream.WriteLine("/// <summary>");
        stream.WriteLine($"/// {tableName} Table Interface");
        stream.WriteLine("/// </summary>");
        if (sides > 0)
        {
            stream.WriteLine($"public interface I{csName}Table : IRandomTable");
        }
        else
        {
            stream.WriteLine($"public interface I{csName}Table : INamedTable");
        }
        stream.WriteLine("{");
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate the .cs class for the table enum
    /// </summary>
    /// <param name="stream">The stream for the enum</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="properties">The properties row</param>
    /// <param name="rows">The rows for the table</param>
    /// <param name="nameSpace">The namespace for the table</param>
    private void GenerateTableEnum(TextWriter stream, string tableName, List<PropertyModel> properties, List<List<string>> rows, string nameSpace)
    {
        // If the first column is a string, convert it to a enum
        var csName = Utilities.CleanupForCSharp(tableName);
        var fieldList = new List<string>();
        for (int i = 0; i < rows.Count(); i++)
        {
            var fieldName = Utilities.CleanupForCSharp(char.ToUpper(rows[i][0][0]) + rows[i][0].Substring(1));
            if (! fieldList.Contains(fieldName))
            {
                fieldList.Add(fieldName);
            }
        }

        stream.WriteLine("//");
        stream.WriteLine($"// {tableName}");
        stream.WriteLine("//");
        stream.WriteLine($"namespace GoDungeon.{nameSpace}.Enum;");
        stream.WriteLine();
        stream.WriteLine("/// <summary>");
        stream.WriteLine($"/// {tableName}");
        stream.WriteLine("/// </summary>");
        stream.WriteLine($"public enum {csName}Enum : int");
        stream.WriteLine("{");
        var sortedList = fieldList.OrderBy(o => o).ToArray();
        for(int i = 0; i < sortedList.Count(); i++)
        {
            stream.WriteLine($"\t{sortedList[i]} = {i},");
        }
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate the rest of the .cs class for the table
    /// </summary>
    /// <param name="stream">The output stream for the table</param>
    /// <param name="tableName">The name of the table</param>
    /// <param name="properties">The property fields to generate</param>
    /// <param name="rows">The rows for the table</param>
    /// <param name="randomTable">Is it a random table?</param>
    private void GenerateTableBody(StreamWriter stream, string tableName, List<PropertyModel> properties, List<List<string>> rows, int sides)
    {
        for (int k = 0;  k < rows.Count(); k++) 
        {
            stream.WriteLine($"\t\t\t\t#region {rows[k][0]}");
            stream.WriteLine($"\t\t\t\tnew {Utilities.CleanupForCSharp(tableName)}TableEntryViewModel");
            stream.WriteLine($"\t\t\t\t{{");
            for (int i = 0; i < properties.Count(); i++)
            {
                // handle range in column 0
                if (i == 0)
                {
                    if (sides > 0)
                    {
                        // get the range
                        var startRange = rows[k][0];
                        var endRange = rows[k][0];
                        if (rows[k][0].Contains("-"))
                        {
                            var fullRange = rows[k][0].Split('-');
                            startRange = fullRange[0];
                            endRange = fullRange[1];
                        }
                        stream.WriteLine($"\t\t\t\t\tRange = new Range({startRange}, {endRange}),");
                        continue;
                    }
                    else
                    {
                        if (properties[0].Value == "string")
                        {
                            var csName = Utilities.CleanupForCSharp(rows[k][i]);
                            stream.WriteLine($"\t\t\t\t\tName = nameof({Utilities.CleanupForCSharp(tableName)}Enum.{csName}),");
                            stream.WriteLine($"\t\t\t\t\tProperName = \"{rows[k][i]}\",");
                        }
                    }
                    continue;
                }
                if (properties[i].Value == "string")
                {
                    stream.WriteLine($"\t\t\t\t\t{properties[i].Name} = \"{rows[k][i]}\",");
                }
                else
                {
                    if (properties[i].Value == "int")
                    {
                        stream.WriteLine($"\t\t\t\t\t{properties[i].Name} = Convert.ToInt32({rows[k][i]}),");
                    }
                    else
                    {
                        stream.WriteLine($"\t\t\t\t\t{properties[i].Name} = Convert.ToDecimal({rows[k][i]}),");
                    }
                }
            }
            stream.WriteLine($"\t\t\t\t}},");
            stream.WriteLine($"\t\t\t\t#endregion");
            stream.WriteLine();
        }
        stream.WriteLine("\t\t\t};");
        stream.WriteLine("\t\t}");
        stream.WriteLine("\t}");
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate the table heading
    /// </summary>
    /// <param name="stream">The output stream for the table</param>
    /// <param name="filePath">The file containing the table</param>
    /// <param name="tableName">The name of the table</param>
    /// <param name="rows">The rows in the table</param>
    /// <param name="nameSpace">The namespace of the table</param>
    /// <param name="randomTable">Is it a random table?</param>
    private void GenerateTableHeading(TextWriter stream, string filePath, string tableName, string nameSpace, int sides)
    {
        var csName = Utilities.CleanupForCSharp(tableName);

        stream.WriteLine("//");
        stream.WriteLine($"// {tableName}");
        stream.WriteLine($"// Containing file {filePath.Replace("C:\\Users\\drcarver\\Desktop\\NetGore\\src\\UI\\GoDungeon.CodeGenerator\\docs\\", string.Empty)}");
        stream.WriteLine("//");
        stream.WriteLine("using System.Collections.ObjectModel;");
        stream.WriteLine();
        stream.WriteLine("using GoDungeon.Core.Interfaces;");
        stream.WriteLine("using GoDungeon.Core.Tables;");
        stream.WriteLine();
        stream.WriteLine($"using GoDungeon.{nameSpace}.Interfaces;");
        stream.WriteLine($"using GoDungeon.{nameSpace}.ViewModels;");
        stream.WriteLine();
        stream.WriteLine("using Microsoft.Extensions.Logging;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.{nameSpace}.Tables;");
        stream.WriteLine();
        stream.WriteLine("/// <summary>");
        stream.WriteLine($"/// {tableName}");
        stream.WriteLine("/// </summary>");
        if (sides > 0)
        {
            stream.WriteLine($"public partial class {csName}Table : RandomTable, I{csName}Table");
        }
        else
        {
            stream.WriteLine($"public partial class {csName}Table : NamedTable, I{csName}Table");
        }
        stream.WriteLine("{");
        stream.WriteLine("\t/// <summary>");
        stream.WriteLine("\t/// Constructor");
        stream.WriteLine("\t/// </summary>");
        stream.WriteLine($"\tpublic {csName}Table()");
        stream.WriteLine("\t{");
        stream.WriteLine($"\t\tName = nameof({csName}Table);");
        stream.WriteLine($"\t\tProperName = \"{tableName} Table\";");
        if (sides > 0)
        {
            stream.WriteLine($"\t\tSides = {sides};");
        }
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
        stream.WriteLine("\t\t\tTable = new ObservableCollection<IGameTableEntry>()");
        stream.WriteLine("\t\t\t{");
    }
}
