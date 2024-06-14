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
    /// The table caption
    /// </summary>
    public List<string>? TableCaption { get; set; } = new List<string>();

    /// <summary>
    /// The table rows
    /// </summary>
    public List<List<string>> TableRows { get;  } = new List<List<string>>();

    /// <summary>
    /// The markdown file that contains the table
    /// </summary>
    public string? FilePath { get; set; }
}
