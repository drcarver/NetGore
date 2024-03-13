using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IActiveTradeCash
{
    int Cash { get; set; }
    Character Character { get; set; }
}