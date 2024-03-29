using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class UnusualHomelandTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.UnusualHomelandTable.Name == "The Unusual Homeland Table");
        ClassicAssert.IsTrue(BackgroundTables.UnusualHomelandTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.UnusualHomelandTable.DiceSides; i++)
        {
            var entry = BackgroundTables.UnusualHomelandTable.GetEntryByNumber(i);
            ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry {i} is incorrect");
        }
    }

    /// <summary>
    /// Verify a random table entry
    /// </summary>
    /// <param name="i">The index for the table</param>
    /// <param name="entry">The random entry</param>
    /// <returns>True if correct</returns>
    private static bool VerifyEntry(int i, RandomTableEntry? entry)
    {
        if (entry == null)
        {
            return false;
        }

        switch (i)
        {
            //01–10	Subterranean
            case int n when (n >= 1 && n <= 10):
                return entry.Name == nameof(UnusualHomelandEnum.Subterranean)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.SurfaceStranger);

            //11–25	Mountains
            case int n when (n >= 11 && n <= 25):
                return entry.Name == nameof(UnusualHomelandEnum.Mountains)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Highlander);

            //26–40	Plains
            case int n when (n >= 26 && n <= 40):
                return entry.Name == nameof(UnusualHomelandEnum.Plains)
                    && entry.Traits.Count == 0;
                    //&& entry.Traits.Contains(TraitEnum.SavannaChild);

            //41–50	Town or Village You gain access to the Militia Veteran regional trait.
            case int n when (n >= 41 && n <= 50):
                return entry.Name == nameof(UnusualHomelandEnum.TownorVillage)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.MilitiaVeteran);

            //51–60	City or Metropolis
            case int n when (n >= 51 && n <= 60):
                return entry.Name == nameof(UnusualHomelandEnum.CityorMetropolis)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Civilized)
                    && entry.Traits.Contains(TraitEnum.VagabondChild);

            //61–70	Forest
            case int n when (n >= 61 && n <= 70):
                return entry.Name == nameof(UnusualHomelandEnum.Forest)
                    && entry.Traits.Count == 0;
                    //&& entry.Traits.Contains(TraitEnum.LogRoller);

            //71–80	River, Swamp, or Wetlands
            case int n when (n >= 71 && n <= 80):
                return entry.Name == nameof(UnusualHomelandEnum.RiverSwamporWetlands)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.RiverRat);

            //81–85	Desert
            case int n when (n >= 81 && n <= 85):
                return entry.Name == nameof(UnusualHomelandEnum.Desert)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.DesertChild);

            //86–90	Sea
            case int n when (n >= 86 && n <= 90):
                return entry.Name == nameof(UnusualHomelandEnum.SeaSouled)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.SeaSouled);

            //91–95	Tundra
            case int n when (n >= 91 && n <= 95):
                return entry.Name == nameof(UnusualHomelandEnum.Tundra)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.TundraChild);

            //96–100 Another Plane
            case int n when (n >= 96 && n <= 100):
                return entry.Name == nameof(UnusualHomelandEnum.AnotherPlane)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.ScholaroftheGreatBeyond);
        }
        return false;
    }
}
