using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;

namespace ConvertCSVToTable.Maps;

public class TraitCSV : DataObject
{
    //public List<SavingThrowPenality> Effect { get; set; }

    // Name
    public string Name2 { get; set; }

    // Name
    public string Name3 { get; set; }

    //Name-Original,
    public string OriginalName { get; set; }

    //URL,
    public string URL { get; set; }

    //Type,
    public string TraitType { get; set; }

    //Category,
    public string Category { get; set; }

    //Source
    public string Source { get; set; }

    //Req-Race1,
    public string ReqRace1 { get; set; }

    //Req-Race2,
    public string ReqRace2 { get; set; }

    //Req-Class,
    public string ReqClass { get; set; }

    //Req-Align,
    public string ReqAlign { get; set; }

    //Req-Other,
    public string ReqOther { get; set; }

    //Req-Faith,
    public string ReqFaith { get; set; }

    //Req-Place,
    public string ReqPlace { get; set; }

    [SetsRequiredMembers]
    public TraitCSV()
    {
    }
}
