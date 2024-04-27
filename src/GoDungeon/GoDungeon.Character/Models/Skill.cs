using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Core.Base;

namespace D20.Character.Models;

public class Skill : BaseObject, ISkill
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Skill()
    {
    }
}