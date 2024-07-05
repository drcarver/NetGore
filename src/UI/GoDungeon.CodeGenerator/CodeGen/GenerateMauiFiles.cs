using GoDungeon.CodeGenerator.Interfaces;

namespace GoDungeon.CodeGenerator.CodeGen;

public partial class GenerateModel : IGenerateModel
{
    /// <summary>
    /// Generate the .xaml file for the table
    /// </summary>
    /// <param name="stream">The test file stream</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="nameSpace">The namespace for the table</param>
    public void GenerateMAUIXAMLFromMarkdown(TextWriter stream, string tableName, string nameSpace)
    {
        var csName = Utilities.CleanupForCSharp(tableName);
        stream.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
        stream.WriteLine("<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"");
        stream.WriteLine("\t\txmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"");
        stream.WriteLine($"\t\tx:Class=\"GoDungeon.MAUI.{nameSpace}.Views.{csName}Page\"");
        stream.WriteLine($"\t\txmlns:{nameSpace}viewmodel=\"clr-namespace:GoDungeon.{nameSpace}.ViewModels;assembly=GoDungeon.{nameSpace}\"");
        stream.WriteLine($"\t\txmlns:tables=\"clr-namespace:GoDungeon.{nameSpace}.Tables;assembly=GoDungeon.Equipment\"");
        stream.WriteLine($"\t\txmlns:toolkit=\"http://schemas.microsoft.com/dotnet/2022/maui/toolkit\"");
        stream.WriteLine($"\t\tx:viewmodel:{tableName}ViewModel\">");
        stream.WriteLine();
        stream.WriteLine($"\t<ScrollView BackgroundColor=\"PapayaWhip\">");
        stream.WriteLine($"\t\t<VerticalStackLayout>");
        stream.WriteLine($"\t\t\t<!--  left, top, right, and bottom --> ");
        stream.WriteLine($"\t\t\t<Label Text=\"{{Binding PageDescription}}\" Margin=\"10,0,0,0\"");
        stream.WriteLine($"\t\t\t\tLineBreakMode=\"WordWrap\" FontAttributes=\"Italic\" />");
        stream.WriteLine($"\t\t\t<Label Text=\"{{Binding FormattedBodyText}}\" Margin=\"10,0,0,0\"");
        stream.WriteLine($"\t\t\t\tLineBreakMode=\"WordWrap\" />");
        stream.WriteLine($"\t\t</VerticalStackLayout>");
        stream.WriteLine($"\t</ScrollView>");
        stream.WriteLine($"</ContentPage>");
    }

    /// <summary>
    /// Generate the .xaml file for the table
    /// </summary>
    /// <param name="stream">The test file stream</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="nameSpace">The namespace for the table</param>
    public void GenerateMAUIXAMLCSFromMarkdown(StreamWriter stream, string tableName, string nameSpace)
    {
        var csName = Utilities.CleanupForCSharp(tableName);
        stream.WriteLine($"using GoDungeon.MAUI.{nameSpace}.Interfaces;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.MAUI.{nameSpace}.Views;");
        stream.WriteLine();
        stream.WriteLine($"public partial class {csName}Page : ContentPage");
        stream.WriteLine("{");
        stream.WriteLine($"\tpublic {csName}Page(I{csName}ViewModel vm)");
        stream.WriteLine("\t{");
        stream.WriteLine("\t\tInitializeComponent();");
        stream.WriteLine();
        stream.WriteLine("\t\tBindingContext = vm;");
        stream.WriteLine("\t}");
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate the .xaml file for the table
    /// </summary>
    /// <param name="stream">The test file stream</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="nameSpace">The namespace for the table</param>
    public void GenerateMAUIInterfaceForViewModel(StreamWriter stream, string tableName, string nameSpace)
    {
        var csName = Utilities.CleanupForCSharp(tableName);
        stream.WriteLine($"using GoDungeon.MAUI.{nameSpace}.ViewModels;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.MAUI.{nameSpace}.Views;");
        stream.WriteLine();
        stream.WriteLine($"public partial class {csName}Page : ContentPage");
        stream.WriteLine("{");
        stream.WriteLine($"\tpublic {csName}Page({csName}ViewModel vm)");
        stream.WriteLine($"\\ttInitializeComponent();");
        stream.WriteLine("\t{");
        stream.WriteLine("\t\tBindingContext = vm;");
        stream.WriteLine("\t}");
        stream.WriteLine("}");
    }
}
