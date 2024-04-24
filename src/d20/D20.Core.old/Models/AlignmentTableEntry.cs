using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using D20.Core.Enum;

namespace D20.Core.Models;

public class AlignmentTableEntry : RandomTableEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AlignmentTableEntry()
    {
    }

    /// <summary>
    /// The alignment as a enum
    /// </summary>
    public AlignmentEnum Alignment { get; set; }
}
