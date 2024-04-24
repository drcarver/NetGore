using D20.Core.Enum;
using D20.Core.Tables;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Core;

[TestFixture]
public class AlignmentTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        var alignments = new List<string>();
        foreach (var align in Enum.GetValues(typeof(AlignmentEnum)).Cast<AlignmentEnum>())
        {
            alignments.Add(align.ToString());
        }

        var table = new AlignmentTable();
        ClassicAssert.IsTrue(table.Name == nameof(AlignmentTable));

        foreach (var entry in table.Table)
        {
            ClassicAssert.IsTrue(alignments.Contains(entry.Name), $"Table entry Name = {entry?.Name} is incorrect");
        }
    }
}

