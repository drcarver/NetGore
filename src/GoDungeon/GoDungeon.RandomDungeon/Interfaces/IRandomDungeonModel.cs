using System.IO;

namespace GoDungeon.RandomDungeon.Interfaces
{
    public interface IRandomDungeonModel
    {
        /// <summary>
        /// Export the dungeon as a pdf
        /// </summary>
        public void ExportToPDF(Stream stream);
    }
}