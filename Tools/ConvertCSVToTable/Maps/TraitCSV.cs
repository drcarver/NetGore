using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;

namespace ConvertCSVToTable.Maps;

public class TraitCSV : DataObject
{
    //public List<SavingThrowPenality> Effect { get; set; }

    // Name - ignored
    //public string Name2 { get; set; }

    // Name - ignored
    //public string Name3 { get; set; }

    //Name-Original, - ignored
    //public string OriginalName { get; set; }

    //Req-Align, - ignored
    //public string ReqAlign { get; set; }

    //Req-Race2, - ignored
    //public string ReqRace2 { get; set; }

    //Source - ignored
    //public string Source { get; set; }

    //Req-Faith, - ignored
    //public string ReqFaith { get; set; }

    //Req-Other, - ignored
    //public string ReqOther { get; set; }

    //URL,
    public string URL { get; set; }

    //Type,
    public string TraitType { get; set; }

    //Category,
    public string Category { get; set; }

    //Req-Race1,
    public string ReqRace1 { get; set; }

    //Req-Class,
    public string ReqClass { get; set; }

    //Req-Place,
    public string ReqPlace { get; set; }

    [SetsRequiredMembers]
    public TraitCSV()
    {
    }
}
