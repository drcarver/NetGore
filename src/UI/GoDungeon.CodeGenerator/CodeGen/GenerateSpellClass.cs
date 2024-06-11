using System.Collections.ObjectModel;
using System.Reflection.Metadata;
using System.Xml.Linq;

using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Spells.Enum;
using GoDungeon.Spells.Interfaces;
using GoDungeon.Spells.ViewModels;

namespace GoDungeon.CodeGenerator.CodeGen;

public partial class GenerateModel : IGenerateModel
{
    /// <summary>
    /// Generate the .cs class for the spell
    /// </summary>
    /// <param name="stream">The  file stream</param>
    /// <param name="creature">The spell to generate</param>
    public void GenerateSpellClass(TextWriter stream, ISpellTableEntry spell, string rootdir)
    {
        GenerateSpellModel(stream, spell);
        GenerateSpellInterfaceFile(stream, spell, rootdir);
    }

    /// <summary>
    /// Generate the spell model file
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="creature"></param>
    private void GenerateSpellModel(TextWriter stream, ISpellTableEntry spell)
    {
    }

    /// <summary>
    /// Generate the associated enum and lists from the full spell lists
    /// </summary>
    /// <param name="spellInfoList">The spell info list</param>
    /// <param name="rootdir">The root dir</param>
    public void GenerateSpellLists(List<ISpellTableEntry> spellInfoList, string rootdir)
    {
        GenerateSpellEnum(spellInfoList, rootdir);
        GenerateSpellInfoList(spellInfoList, rootdir);
    }

    /// <summary>
    /// Generate the table heading
    /// </summary>
    /// <param name="tableName">The name of the table</param>
    /// <param name="tableDescription">The description of the table</param>
    /// <param name="properName">The proper name of the table</param>
    private void GenerateTableHeading(TextWriter stream, string tableName, string tableDescription, string properName)
    {
        stream.WriteLine("//");
        stream.WriteLine($"// {tableDescription}");
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
        stream.WriteLine("namespace GoDungeon.Spells.Tables;");
        stream.WriteLine();
        stream.WriteLine("/// <summary>");
        stream.WriteLine($"/// {tableDescription}");
        stream.WriteLine("/// </summary>");
        stream.WriteLine($"public partial class {tableName} : NamedTable, I{tableName}");
        stream.WriteLine("{");
        stream.WriteLine("\t/// <summary>");
        stream.WriteLine("\t/// Constructor");
        stream.WriteLine("\t/// </summary>");
        stream.WriteLine($"\tpublic {tableName}()");
        stream.WriteLine("\t{");
        stream.WriteLine($"\t\tName = nameof({tableName});");
        stream.WriteLine($"\t\tProperName = \"{properName}\";");
        stream.WriteLine($"\t\tTableType = TableTypeEnum.SpellTable;");
        stream.WriteLine($"\t\tDescription = \"{tableDescription}\";");
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
    /// Generate the spell info list
    /// </summary>
    /// <param name="spellInfoList"></param>
    /// <param name="rootdir"></param>
    private void GenerateSpellInfoList(List<ISpellTableEntry> spellInfoList, string rootdir)
    {
        // Convert the file to a .cs interface
        var tableFileName = $@"{rootdir}tables/spells/SpellInformationTable.cs";
        using (StreamWriter stream = File.CreateText(tableFileName))
        {
            GenerateTableHeading(stream, "SpellInfoTable", "The Spell Information Table", "Spell Information Table");
            stream.WriteLine($"\t\t\tTable = new ObservableCollection<IGameTableEntry>");
            stream.WriteLine("\t\t\t{");
            foreach (var spell in spellInfoList)
            {
                if (String.IsNullOrEmpty(spell.Name.Trim()))
                {
                    continue;
                }
                stream.WriteLine($"\t\t\t\t#region {spell.ProperName}");
                stream.WriteLine($"\t\t\t\tnew SpellTableEntryViewModel");
                stream.WriteLine("\t\t\t\t{");
                stream.WriteLine($"\t\t\t\t\tName=nameof(SpellNameEnum.{spell.Name}),");
                stream.WriteLine($"\t\t\t\t\tProperName=\"{spell.ProperName}\",");
                stream.WriteLine($"\t\t\t\t\tSpellType=SpellNameEnum.{spell.Name},");
                stream.WriteLine($"\t\t\t\t\tLevel = {spell.Level},");
                stream.WriteLine($"\t\t\t\t\tMagicSchool = MagicSchoolEnum.{spell.MagicSchool},");
                stream.WriteLine($"\t\t\t\t\tCastingTime = new CastingTimeViewModel({spell.CastingTime.CastingTime}, DurationEnum.{spell.CastingTime.Duration}),");
                stream.WriteLine($"\t\t\t\t\tSpellRange = new SpellRangeViewModel");
                stream.WriteLine("\t\t\t\t\t{");
                stream.WriteLine($"\t\t\t\t\t\tUnit = {spell.SpellRange.Unit},");
                stream.WriteLine($"\t\t\t\t\t\tDistanceType = SpellDistanceEnum.{spell.SpellRange.DistanceType},");
                stream.WriteLine($"\t\t\t\t\t\tSpellEffectType = SpellEffectTypeEnum.{spell.SpellRange.SpellEffectType},");
                stream.WriteLine($"\t\t\t\t\t\tRangeType = SpellDistanceTypeEnum.{spell.SpellRange.RangeType}");
                stream.WriteLine("\t\t\t\t\t},");
                stream.WriteLine($"\t\t\t\t\tSpellComponents = new ObservableCollection<string>(),");
                stream.Write($"\t\t\t\t\tCasters = new ObservableCollection<ClassEnum> {{");
                foreach (var caster in spell.Casters)
                {
                    stream.Write($"ClassEnum.{caster}, ");
                }
                stream.WriteLine(" },");
                stream.WriteLine("\t\t\t\t},");
                stream.WriteLine("\t\t\t\t#endregion");
                stream.WriteLine();
            }
            stream.WriteLine("\t\t\t};");
            stream.WriteLine("\t\t}");
            stream.WriteLine("\t}");
            stream.WriteLine("}");
        }
    }

    /// <summary>
    /// Generate the Spell interface files
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="creature"></param>
    private void GenerateSpellInterfaceFile(TextWriter stream, ISpellTableEntry spell, string rootdir)
    {
        // Convert the file to a .cs interface
        var interfaceFile = $@"{rootdir}Interfaces/spells/I{spell.Name}.cs";
        using (StreamWriter writer = File.CreateText(interfaceFile))
        {
            writer.WriteLine("//");
            writer.WriteLine($"// {spell.ProperName}.");
            writer.WriteLine("//");
            writer.WriteLine("using GoDungeon.Core.Interfaces;");
            writer.WriteLine();
            writer.WriteLine("namespace GoDungeon.Spells.Interfaces");
            writer.WriteLine("{");
            writer.WriteLine("\t/// <summary>");
            writer.WriteLine($"\t/// {spell.ProperName}.");
            writer.WriteLine($"\t/// </summary>");
            writer.WriteLine($"\tpublic interface I{spell.Name} : ISpell");
            writer.WriteLine("\t{");
            writer.WriteLine("\t}");
            writer.WriteLine("}");
        }
    }

    /// <summary>
    /// Generate the Spell Enum
    /// </summary>
    private void GenerateSpellEnum(List<ISpellTableEntry> spellInfoList, string rootdir)
    {
        // Convert the monster list to a .cs enum
        var spellEnumFile = $@"{rootdir}enum/spells/SpellEnum.cs";
        using (StreamWriter writer = File.CreateText(spellEnumFile))
        {
            writer.WriteLine("//");
            writer.WriteLine("// The spell enumeration");
            writer.WriteLine("//");
            writer.WriteLine();
            writer.WriteLine("namespace GoDungeon.Spells.Enum");
            writer.WriteLine("{");
            writer.WriteLine();
            writer.WriteLine("public enum SpellEnum : int");
            writer.WriteLine("{");
            for (int i = 0; i < spellInfoList.Count(); i++)
            {
                writer.WriteLine($"\t{spellInfoList[i].Name} = {i},");
            }
            writer.WriteLine("}");
        }
    }
}
