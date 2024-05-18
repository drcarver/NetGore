using GoDungeon.Core.Interfaces;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf;
using System.Data;
using System.IO;

namespace GoDungeon.RandomDungeon
{
    public interface IRandomDungeonModel
    {
        /// <summary>
        /// The dungeon purpose from the dungeon purpose table
        /// </summary>
        public IRandomTable Purpose { get; }

        /// <summary>
        /// The dungeon history table from the dungeon history
        /// </summary>
        public IRandomTable History { get; }

        /// <summary>
        /// Export the dungeon as a pdf
        /// </summary>
        public void ExportToPDF(Stream stream);
    }
}