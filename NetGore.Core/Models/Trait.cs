using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;

namespace NetGore.Core.Models;

public class Trait : DataObject
{
    //public List<SavingThrowPenality> Effect { get; set; }

    public string ProperName { get; set; }

    //URL,
    public Uri URL { get; set; }

    //Type,
    public string TraitType { get; set; }

    //Category,
    public string Category { get; set; }

    //Source
    public string Source { get; set; }

    [SetsRequiredMembers]
    public Trait()
    {
    }
}
