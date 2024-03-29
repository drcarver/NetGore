using System.Diagnostics;

using CsvHelper.Configuration;

namespace ConvertCSVToTable.Maps;

internal sealed class FeatMap : ClassMap<FeatsCSV>
{
    internal FeatMap()
    {
        Map(x => x.Id).Name("id");
        Map(x => x.Name).Name("name");
        Map(x => x.FeatType).Name("type");
        Map(x => x.Description).Name("description");
        Map(x => x.Prerequisites).Name("prerequisites");
        Map(x => x.PrerequisiteFeats).Name("prerequisite_feats");
        Map(x => x.Benefit).Name("benefit");
        Map(x => x.Normal).Name("normal");
        Map(x => x.Special).Name("special");
        Map(x => x.Source).Name("source");
        Map(x => x.fulltext).Name("fulltext");
        Map(x => x.teamwork).Name("teamwork");
        Map(x => x.critical).Name("critical");
        Map(x => x.grit).Name("grit");
        Map(x => x.style).Name("style");
        Map(x => x.performance).Name("performance");
        Map(x => x.racial).Name("racial");
        Map(x => x.companion_familiar).Name("companion_familiar");
        Map(x => x.race_name).Name("race_name");
        Map(x => x.note).Name("note");
        Map(x => x.goal).Name("goal");
        Map(x => x.completion_benefit).Name("completion_benefit");
        Map(x => x.multiples).Name("multiples");
        Map(x => x.suggested_traits).Name("suggested_traits");
        Map(x => x.prerequisite_skills).Name("prerequisite_skills");
        Map(x => x.panache).Name("panache");
        Map(x => x.betrayal).Name("betrayal");
        Map(x => x.targeting).Name("targeting");
        Map(x => x.esoteric).Name("esoteric");
        Map(x => x.stare).Name("stare");
        Map(x => x.weapon_mastery).Name("weapon_mastery");
        Map(x => x.item_mastery).Name("item_mastery");
        Map(x => x.armor_mastery).Name("armor_mastery");
        Map(x => x.shield_mastery).Name("shield_mastery");
        Map(x => x.blood_hex).Name("blood_hex");
        Map(x => x.trick).Name("trick");
    }
}
