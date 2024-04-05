using NetGore.Core.Enum;

namespace NetGore.Core.Models;

public class SavingThrowPenality
{
    public SavingThrowEnum SavingThrow {  get; set; }
    public int Penalty { get; set; }
}