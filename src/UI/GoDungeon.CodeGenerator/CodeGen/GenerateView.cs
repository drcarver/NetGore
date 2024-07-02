using System.Diagnostics;
using System.Reflection.Emit;
using System.Text;

using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;

namespace GoDungeon.CodeGenerator.CodeGen;

public partial class GenerateModel : IGenerateModel
{
    /// <summary>
    /// Given a markdown file, generate the equivalent xaml
    /// <param name="outputDir">The output directory root</param>
    /// <param name="markDown">The list of markdown files</param>
    /// <param name="inputDir">The input directory root</param>
    /// </summary>
    public void GenerateXAMLFromMarkdown(string outputDir, List<string> markDown, string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        //GenerateMarkDownViewModel(markDown, outputDir, fileInfo);
    }

    /// <summary>
    /// Generate the .xaml.cs file for the files
    /// </summary>
    /// <param name="markdown"></param>
    /// <param name="outputDir"></param>
    /// <param name="filePath"></param>
    private void GenerateMarkDownViewModel(List<string> markDown, string outputDir, FileInfo fileInfo)
    {
        string lastDir = fileInfo.DirectoryName.Split('\\').Last();
        string nameSpace = char.ToUpper(lastDir[0]) + lastDir.Substring(1);
        StringBuilder formattedText = new StringBuilder();
        foreach (var line in markDown)
        {
            if (line.StartsWith("# "))
            {
                formattedText.AppendLine();
            }
        }
        //var route = filePath.Replace()
        //foreach (var file in fileList)
        //{

        //}
    }

    /// <summary>
    /// Generate the .xaml file for the table
    /// </summary>
    /// <param name="stream">The test file stream</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="nameSpace">The namespace for the table</param>
    private void GenerateTableViewXAML(StreamWriter stream, string tableName, List<PropertyModel> properties, List<List<string>> rows, string nameSpace)
    {
        var csName = Utilities.CleanupForCSharp(tableName);
        stream.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
        stream.WriteLine("<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"");
        stream.WriteLine("\t\txmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"");
        stream.WriteLine($"\t\tx:Class=\"GoDungeon.MAUI.{nameSpace}.Views.{csName}Page\"");
        stream.WriteLine($"\t\txmlns:{nameSpace}viewmodel=\"clr-namespace:GoDungeon.{nameSpace}.ViewModels;assembly=GoDungeon.{nameSpace}\"");
        stream.WriteLine($"\t\txmlns:tables=\"clr-namespace:GoDungeon.{nameSpace}.Tables;assembly=GoDungeon.Equipment\"");
        stream.WriteLine($"\t\txmlns:toolkit=\"http://schemas.microsoft.com/dotnet/2022/maui/toolkit\"");
        stream.WriteLine($"\t\tx:DataType=\"tables:{tableName}\"");
        stream.WriteLine($"\t\tTitle=\"{{Binding ProperName}}\">");
        stream.WriteLine();
        stream.WriteLine($"\t<CollectionView ItemsSource=\"{{Binding Table}}\" SelectionMode=\"None\">");
        stream.WriteLine($"\t\t<CollectionView.Header>");
        stream.WriteLine($"\t\t</CollectionView.Header>");
        stream.WriteLine($"\t\t<!--This footer is for 5E SRD Content-->");
        stream.WriteLine($"\t\t<CollectionView.Footer>");
        stream.WriteLine($"\t\t\t<Grid RowDefinitions=\"Auto,Auto,Auto\">");
        stream.WriteLine($"\t\t\t\t<Label Grid.Row=\"0\" Text=\"\" Margin=\"10,10,0,0\" />");
        stream.WriteLine($"\t\t\t\t<Label Grid.Row=\"1\" Text=\"This work includes material taken from the System Reference Document 5.1 (“SRD 5.1”) by Wizards of the Coast LLC which is available from the URL below. The SRD 5.1 is licensed under the Creative Commons Attribution 4.0\" Margin=\"10,10,0,0\" />");
        stream.WriteLine($"\t\t\t\t<Label Grid.Row=\"2\" Text=\"https://dnd.wizards.com/resources/systems-reference-document\" Margin=\"10,10,0,0\" />");
        stream.WriteLine($"\t\t\t</Grid>");
        stream.WriteLine($"\t\t</CollectionView.Footer>");
        stream.WriteLine($"\t\t<CollectionView.ItemTemplate>");
        stream.WriteLine($"\t\t</CollectionView.ItemTemplate>");
        stream.WriteLine($"\t</CollectionView>");
        stream.WriteLine($"</ContentPage>");
    }
}
