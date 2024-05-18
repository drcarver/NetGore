using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Models;
using GoDungeon.RandomDungeon.Interfaces;

using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;

namespace GoDungeon.RandomDungeon
{
    public class RandomDungeonModel : BaseObjectModel, IRandomDungeonModel
    {
        public RandomDungeonModel(
            IServiceProvider services,
            IDungeonPurposeTable purpose,
            IDungeonHistoryTable history
            ) 
        {
            purpose.InitializeTable();
            Purpose = purpose;

            history.InitializeTable();
            History = history; 
        }

        /// <summary>
        /// The dungeon purpose from the dungeon purpose table
        /// </summary>
        public IRandomTable Purpose { get; }

        /// <summary>
        /// The dungeon history table from the dungeon history
        /// </summary>
        public IRandomTable History { get; }

        /// <summary>
        /// Export the pdf to a stream
        /// </summary>
        /// <param name="stream">The stream to write to</param>
        public void ExportToPDF(Stream stream)
        {
            //Create a new PDF document
            PdfDocument doc = new PdfDocument();

            //Add a page
            PdfPage page = doc.Pages.Add();

            //Create PDF graphics for the page.
            PdfGraphics graphics = page.Graphics;

            //Get the page width and height
            float pageWidth = page.GetClientSize().Width;
            float pageHeight = page.GetClientSize().Height;

            ////Set the header height
            //float headerHeight = 90;

            ////Create brush with light blue color. 
            //PdfColor lightBlue = Color.FromArgb(255, 91, 126, 215);
            //PdfBrush lightBlueBrush = new PdfSolidBrush(lightBlue);

            ////Create brush with dark blue color. 
            //PdfColor darkBlue = Color.FromArgb(255, 65, 104, 209);
            //PdfBrush darkBlueBrush = new PdfSolidBrush(darkBlue);

            ////Create brush with white color. 
            //PdfBrush whiteBrush = new PdfSolidBrush(Color.FromArgb(255, 255, 255, 255));

            ////Create string format.
            //PdfStringFormat format = new PdfStringFormat();
            //format.Alignment = PdfTextAlignment.Center;
            //format.LineAlignment = PdfVerticalAlignment.Middle;

            //float y = 0;
            //float x = 0;

            ////Set the margins of address.
            //float margin = 30;

            ////Set the line space.
            //float lineSpace = 10;

            //Create border pen and draw the border to PDF page. 
            //PdfColor borderColor = Color.FromArgb(255, 142, 170, 219);
            //PdfPen borderPen = new PdfPen(borderColor, 1f);
            //graphics.DrawRectangle(borderPen, new RectangleF(0, 0, pageWidth, pageHeight));

            //Create a PdfGrid
            PdfGrid pdfGrid = new PdfGrid();

            //Add five columns to the grid.
            pdfGrid.Columns.Add(3);
            pdfGrid.Columns[0].Width = 5;
            pdfGrid.Columns[1].Width = 10;
            pdfGrid.Columns[2].Width = pageWidth - 15;

            //Create the header row of the grid.
            PdfGridRow[] headerRow = pdfGrid.Headers.Add(3);

            //Set style to the header row and set value to the header cells. 
            headerRow[0].Style.BackgroundBrush = new PdfSolidBrush(new PdfColor(68, 114, 196));
            headerRow[0].Style.TextBrush = PdfBrushes.White;
            headerRow[0].Cells[0].Value = "Range";

            headerRow[0].Cells[0].StringFormat.Alignment = PdfTextAlignment.Left;
            headerRow[0].Cells[1].Value = "Proper Name";
            headerRow[0].Cells[1].StringFormat.Alignment = PdfTextAlignment.Left;
            headerRow[0].Cells[2].Value = "Description";
            headerRow[0].Cells[2].StringFormat.Alignment = PdfTextAlignment.Left;

            //Create a DataTable
            DataTable dataTable = new DataTable();

            //Add columns to the DataTable
            dataTable.Columns.Add("Range");
            dataTable.Columns.Add("Proper Name");
            dataTable.Columns.Add("Description");

            //Add rows to the DataTable
            foreach (IRandomTableEntry row in Purpose?.Table)
            {
                dataTable.Rows.Add(new object[] 
                { 
                    row.Range, 
                    row.ProperName ?? string.Empty, 
                    row.Description  ?? string.Empty 
                });
            }

            //Set the standard font.
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

            //Assign data source
            pdfGrid.DataSource = dataTable;

            //Apply built-in table style.
            pdfGrid.ApplyBuiltinStyle(PdfGridBuiltinStyle.GridTable4Accent3);

            //Draw the grid to the page of PDF document.
            var rect = new RectangleF(40, 400, pageWidth - 80, 0);
            pdfGrid.Draw(graphics);

            //Save the document
            doc.Save(stream);
            stream.Position = 0;

            //Close the document
            doc.Close(true);
        }
    }
}
