using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ActiveStatusEffect : BaseObject, IActiveStatusEffect
{
    [SetsRequiredMembers]
    public ActiveStatusEffect()
    {
    }
}