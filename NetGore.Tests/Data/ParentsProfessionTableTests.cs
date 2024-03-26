using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Drawing;

using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;
using NetGore.Data.Classes;

using NUnit.Framework.Legacy;

using Org.BouncyCastle.Asn1.Ocsp;

namespace NetGore.Tests.Data;

[TestFixture]
public class ParentsProfessionTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.ParentsProfessionTable.Name == "Parents’ Profession");
        ClassicAssert.IsTrue(BackgroundTables.ParentsProfessionTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.ParentsProfessionTable.DiceSides; i++)
        {
            var entry = BackgroundTables.ParentsProfessionTable.GetEntryByNumber(i);
            ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry {i} - Name = {entry?.Name} is incorrect");
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
            //01–05	Slaves
            case int n when (n>= 1 && n <= 5):
                return entry.Name == nameof(ProfessionEnum.Slaves)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.LifeofToil);

            //06–25	Serfs/Peasants
            case int n when (n >= 6 && n <= 25):
                return entry.Name == nameof(ProfessionEnum.SerfsPeasants)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.PovertyStricken);

            //26–30	Entertainers
            case int n when (n >= 26 && n <= 30):
                return entry.Name == nameof(ProfessionEnum.Entertainers)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Talented);

            //31–34	Soldiers
            case int n when (n >= 31 && n <= 34):
                return entry.Name == nameof(ProfessionEnum.Soldiers)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Tactician);

            //35–37	Sailors
            case int n when (n >= 35 && n <= 37):
                return entry.Name == nameof(ProfessionEnum.Sailors)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Worldly);

            //38–40	Thieves
            case int n when (n >= 38 && n <= 40):
                return entry.Name == nameof(ProfessionEnum.Thieves)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.ChildoftheStreets);

            //41–55	Yeomen
            case int n when (n >= 41 && n <= 55):
                return entry.Name == nameof(ProfessionEnum.Yeomen)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.SavannaChild);

            //56–70	Tradespeople
            case int n when (n >= 56 && n <= 70):
                return entry.Name == nameof(ProfessionEnum.Tradespeople)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.LifeofToil)
                    && entry.Traits.Contains(TraitEnum.Artisan);

            //71–85	Artisans
            case int n when (n >= 71 && n <= 85):
                return entry.Name == nameof(ProfessionEnum.Artisans)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Artisan);

            //86–95	Merchants You gain access to the Merchant social trait.
            case int n when (n >= 86 && n <= 95):
                return entry.Name == nameof(ProfessionEnum.Merchants)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Merchant);

            //96–100	Clergy or Cultists You gain access to the Child of the Temple faith trait.
            case int n when (n >= 96 && n <= 100):
                return entry.Name == nameof(ProfessionEnum.ClergyorCultists)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.ChildoftheTemple);
        }
        return false;
    }
}
