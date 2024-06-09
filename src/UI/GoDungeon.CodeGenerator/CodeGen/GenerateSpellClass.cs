using GoDungeon.CodeGenerator.Interfaces;
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
    public void GenerateSpellClass(TextWriter stream, ISpell spell, string rootdir)
    {
        GenerateSpellModel(stream, spell);
        GenerateSpellInterfaceFile(stream, spell, rootdir);
    }

    /// <summary>
    /// Generate the spell model file
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="creature"></param>
    private void GenerateSpellModel(TextWriter stream, ISpell spell)
    {
    }

    /// <summary>
    /// Generate the associated enum and lists from the full spell lists
    /// </summary>
    /// <param name="spellInfoList">The spell info list</param>
    /// <param name="rootdir">The rootdir</param>
    public void GenerateSpellLists(List<SpellInfoViewModel> spellInfoList, string rootdir)
    {
        GenerateSpellEnum(spellInfoList, rootdir);
    }

    /// <summary>
    /// Generate the Spell interface files
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="creature"></param>
    private void GenerateSpellInterfaceFile(TextWriter stream, ISpell spell, string rootdir)
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
    private void GenerateSpellEnum(List<SpellInfoViewModel> spellInfoList, string rootdir)
    {
        // Convert the monster list to a .cs enum
        var spellEnumFile = $@"{rootdir}enum/spells/SpellEnum.cs";
        using (StreamWriter writer = File.CreateText(spellEnumFile))
        {
            writer.WriteLine("//");
            writer.WriteLine($"// The spell enumeration");
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