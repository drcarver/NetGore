using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GoDungeon.CodeGenerator.Interfaces;

namespace GoDungeon.CodeGenerator.Models;

public class MarkDownTableModel : IMarkDownTableModel
{
    /// <summary>
    /// The line in the markdown file where the table starts
    /// </summary>
    public int MarkdownLine { get; set; } = 0;

    /// <summary>
    /// The table caption
    /// </summary>
    public string? TableCaption { get; set; }

    /// <summary>
    /// The table rows
    /// </summary>
    public List<string> TableRows { get;  } = [];
}