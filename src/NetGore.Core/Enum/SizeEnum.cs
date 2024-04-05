namespace NetGore.Core.Enum;

/// <summary>
/// You receive a bonus or penalty to your AC based 
/// on your size.
/// </summary>
public enum SizeEnum
{
    Fine = 8,
    Diminutive = 4,
    Tiny = 2,
    Small = 1,
    Medium = 0,
    Large = -1,
    Huge = -2,
    Gargantuan = -4,
    Colossal = -8
}
