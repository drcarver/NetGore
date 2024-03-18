namespace NetGore.Core.Interfaces;

public interface IShop
{
    /// <summary>
    /// Whether or not this shop can buy items from 
    /// shoppers. When false, the shop only sells items 
    /// (users cannot sell to it).
    /// </summary>
    public bool CanBuy { get; set; }
}