using D20.Core.Interfaces;
using D20.Goods.Models;

namespace D20.Goods.Interfaces;

public interface IGoodsTableEntry : IGameTableEntry
{
    /// <summary>
    /// The goods cost
    /// </summary>
    GoodsCost Cost { get; set; }
}