using D20.Core.Enum;
using D20.Core.Tables;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Core;

[TestFixture]
public class LanguageTableTests
{
    /// <summary>
    /// The language table is just the list of languages 
    /// in a GameTable
    /// </summary>
    [Test]
    public void AreTableEntriesCorrect()
    {
        var languages = new List<string>();
        foreach (var language in Enum.GetValues(typeof(LanguageEnum)).Cast<LanguageEnum>())
        {
            languages.Add(language.ToString());
        }

        var table = new AlignmentTable();
        ClassicAssert.IsTrue(table.Name == nameof(AlignmentTable));

        foreach (var entry in table.Table)
        {
            ClassicAssert.IsTrue(languages.Contains(entry.Name), $"Table entry Name = {entry?.Name} is incorrect");
        }
    }
}
