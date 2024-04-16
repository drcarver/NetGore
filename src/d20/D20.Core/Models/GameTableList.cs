using D20.Core.Interfaces;

namespace D20.Core.Models;

public class GameTableList<T> : List<T> where T : IGameTableEntry
{
    public new void Add(T entry)
    {
        if (this.Exists(l => l.Name == entry.Name))
        {
            throw new Exception($"There is already an entry for {entry.Name} in the table");
        }
        else base.Add(entry);
    }
}
