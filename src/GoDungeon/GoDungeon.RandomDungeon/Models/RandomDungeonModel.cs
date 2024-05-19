using System;
using System.IO;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Models;
using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Interfaces;

using Syncfusion.DocIO.DLS;
using Syncfusion.DocIORenderer;
using Syncfusion.Pdf;

namespace GoDungeon.RandomDungeon.Models
{
    public class RandomDungeonModel : BaseObjectModel, IRandomDungeonModel
    {
        public RandomDungeonModel(
            IServiceProvider services,
            IDungeonPurposeTable purpose,
            IDungeonHistoryTable history,
            IStartingAreaTable startingAreaTable,
            IPassageTable passageTable,
            IPassageWidthTable passageWidthTable,
            IChamberTable chamberTable,
            IChamberExitTable chamberExitTable,
            IBeyondADoorTable beyondADoorTable,
            IDoorTypeTable doorTypeTable,
            IExitLocationTable exitLocationTable,
            IExitTypeTable exitTypeTable,
            IStairsTable stairsTable,
            IDungeonLocationTable dungeonLocationTable,
            IExoticLocationTable exoticLocationTable
            )
        {
            // Initialize the tables
            purpose.InitializeTable();
            history.InitializeTable();
            startingAreaTable.InitializeTable();
            passageTable.InitializeTable();
            passageWidthTable.InitializeTable();
            chamberTable.InitializeTable();
            chamberExitTable.InitializeTable();
            beyondADoorTable.InitializeTable();
            exitLocationTable.InitializeTable();
            exitTypeTable.InitializeTable();
            doorTypeTable.InitializeTable();
            stairsTable.InitializeTable();
            dungeonLocationTable.InitializeTable();
            exoticLocationTable.InitializeTable();

            // Set the properties
            Purpose = purpose;
            History = history;
            StartingAreaTable = startingAreaTable;
            PassageTable = passageTable;
            PassageWidthTable = passageWidthTable;
            ChamberTable = chamberTable;
            ChamberExitTable = chamberExitTable;
            BeyondADoorTable = beyondADoorTable;
            DoorTypeTable = doorTypeTable;
            ExitLocationTable = exitLocationTable;
            ExitTypeTable = exitTypeTable;
            StairsTable = stairsTable;
            DungeonLocationTable = dungeonLocationTable;
            ExoticLocationTable = exoticLocationTable;
        }

        /// <summary>
        /// Properties for injected tables
        /// </summary>
        private IRandomTable Purpose { get; }
        private IRandomTable History { get; }
        private IStartingAreaTable StartingAreaTable { get; }
        private IPassageTable PassageTable { get; }
        private IPassageWidthTable PassageWidthTable { get; }
        private IChamberTable ChamberTable { get; }
        private IChamberExitTable ChamberExitTable { get; }
        private IBeyondADoorTable BeyondADoorTable { get; }
        private IDoorTypeTable DoorTypeTable { get; }
        private IExitLocationTable ExitLocationTable { get; }
        private IExitTypeTable ExitTypeTable { get; }
        private IStairsTable StairsTable { get; }
        private IDungeonLocationTable DungeonLocationTable { get; }
        private IExoticLocationTable ExoticLocationTable { get; }

        /// <summary>
        /// Create a word document from a table
        /// </summary>
        /// <param name="table">The random Table</param>
        /// <returns></returns>
        private void AddTableToWord(IWSection tableSection, IRandomTable table)
        {
            // Create a section for the table
            tableSection.BreakCode = SectionBreakCode.NoBreak;
            var paragraph = tableSection.AddParagraph();
            paragraph.AppendText(table.ProperName ?? table.Name);
            paragraph.ApplyStyle(BuiltinStyle.Heading1);

            if (table.Description != null)
            {
                paragraph = tableSection.AddParagraph();
                paragraph.AppendText(table.Description);
                paragraph.ApplyStyle(BuiltinStyle.Normal);
                paragraph.AppendBreak(BreakType.LineBreak);
                paragraph = tableSection.AddParagraph();
                paragraph.AppendText($"Roll d{table.DiceSides}");
                paragraph.ApplyStyle(BuiltinStyle.Normal);
                paragraph.AppendBreak(BreakType.LineBreak);
            }

            if (table.Table !=  null) 
            {
                var docTable = tableSection.AddTable();
                docTable.ApplyStyle(BuiltinTableStyle.TableProfessional);
                docTable.Title = table.ProperName ?? table.Name;
                docTable.ResetCells(table.Table.Count + 1, 3);
                if (table.Description != null)
                {
                    docTable.Description = table.Description;
                }
                docTable.TableFormat.HorizontalAlignment = RowAlignment.Left;
                docTable.TableFormat.IsAutoResized = true;
        
                //Accesses the instance of the first row in the table
                WTableRow row = docTable.Rows[0];
                row.IsHeader = true;
                row.HeightType = TableRowHeightType.AtLeast;

                row.Cells[0].AddParagraph().Text = "Range";
                row.Cells[1].AddParagraph().Text = "Name";
                row.Cells[2].AddParagraph().Text = "Description";

                // Now all the other rows
                for (int i = 0 ; i < table.Table.Count; i++)
                {
                    //Add rows to the DataTable
                    row = docTable.Rows[i+1];
                    row.Cells[0].AddParagraph().Text += 
                        ((RandomTableEntryViewModel)table.Table[i]).Range;
                    row.Cells[1].AddParagraph().Text += 
                           ((RandomTableEntryViewModel)table.Table[i]).ProperName 
                        ?? ((RandomTableEntryViewModel)table.Table[i]).Name;
                    row.Cells[2].AddParagraph().Text += 
                        ((RandomTableEntryViewModel)table.Table[i]).Description;
                }
            }
        }

        /// <summary>
        /// Export the PDF to a stream
        /// </summary>
        /// <param name="stream">The stream to write to</param>
        public void ExportToPDF(Stream stream)
        {
            //Create a new word document
            WordDocument wordDocument = new WordDocument();
            wordDocument.EnsureMinimal();
            IWSection tableSection = wordDocument.AddSection();

            //Add the page number to document
            tableSection.PageSetup.PageStartingNumber = 1;
            tableSection.PageSetup.RestartPageNumbering = true;
            tableSection.PageSetup.PageNumberStyle = PageNumberStyle.Arabic;

            //Specify the chapter number and page number separator
            tableSection.PageSetup.PageNumbers.ChapterPageSeparator = ChapterPageSeparatorType.Colon;
            tableSection.PageSetup.InsertPageNumbers(false, PageNumberAlignment.Center);
            tableSection.PageSetup.PageNumberStyle = PageNumberStyle.Arabic;

            //Add a page for the purpose table
            AddTableToWord(tableSection, Purpose);
            AddTableToWord(tableSection, History);
            AddTableToWord(tableSection, DungeonLocationTable);
            AddTableToWord(tableSection, ExoticLocationTable);
            AddTableToWord(tableSection, StartingAreaTable);
            AddTableToWord(tableSection, PassageTable);
            AddTableToWord(tableSection, PassageWidthTable);
            AddTableToWord(tableSection, ChamberTable);
            //AddTableToWord(tableSection, ChamberExitTable);
            AddTableToWord(tableSection, BeyondADoorTable);
            AddTableToWord(tableSection, DoorTypeTable);
            AddTableToWord(tableSection, ExitTypeTable);
            AddTableToWord(tableSection, ExitLocationTable);
            AddTableToWord(tableSection, StairsTable);

            //Instantiation of DocIORenderer for Word to PDF conversion.
            var render = new DocIORenderer();
            PdfDocument pdfDocument = render.ConvertToPDF(wordDocument);
            render.Dispose();
            wordDocument.Dispose();

            // Return the PDF
            pdfDocument.Save(stream);
            pdfDocument.Close();
            pdfDocument.Dispose();
            stream.Position = 0;
        }
    }
}
