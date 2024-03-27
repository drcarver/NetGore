using CsvHelper.Configuration;

namespace ConvertCSVToTable.Maps;

internal sealed class TraitMap : ClassMap<TraitCSV>
{
    internal TraitMap()
    {
        // URL,Name-Original,Type,Category,Name,Name,Req-Race1,Req-Race2,Req-Class,Req-Align,Req-Other,Req-Faith,Req-Place,Description,Source
        Map(x => x.URL).Index(0);
        Map(x => x.OriginalName).Index(1);
        Map(x => x.TraitType).Index(2);
        Map(x => x.Category).Index(3);
        Map(x => x.Name).Index(4);
        Map(x => x.Name2).Index(5);
        Map(x => x.ReqRace1).Index(6);
        Map(x => x.ReqRace2).Index(7);
        Map(x => x.ReqClass).Index(8);
        Map(x => x.ReqAlign).Index(9);
        Map(x => x.ReqOther).Index(10);
        Map(x => x.ReqFaith).Index(11);
        Map(x => x.ReqPlace).Index(12);
        Map(x => x.Description).Index(13);
        Map(x => x.Source).Index(14);
    }
}
