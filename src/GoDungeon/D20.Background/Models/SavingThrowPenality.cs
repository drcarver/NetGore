using D20.Core.Enum;

namespace D20.Background.Models
{
    public class SavingThrowPenalty
    {
        public SavingThrowEnum SavingThrow { get; set; }
        public int Penalty { get; set; }
    }
}