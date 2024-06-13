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
    /// The table header
    /// </summary>
    public List<string> TableHeader { get; set; } = new List<string>();

    /// <summary>
    /// The table rows
    /// </summary>
    public List<string> TableRows { get;  } = new List<string>();
}
