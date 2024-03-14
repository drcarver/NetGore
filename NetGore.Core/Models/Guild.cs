using System.ComponentModel;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Guild : BaseObject, IGuild
{
    /// <summary>
    /// When this guild was created.
    /// </summary>
    [Description("When this guild was created.")]
    [Comment("When this guild was created.")]
    public DateTime Created { get; set; }
}