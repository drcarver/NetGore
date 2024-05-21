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
            IBeyondADoorTable beyondADoorTable,
            IChamberExitTable chamberExitTable,
            IChamberTable chamberTable,
            ICultsTable cultsTable,
            IDoorTypeTable doorTypeTable,
            IDungeonCreatorTable dungeonCreatorTable,
            IDungeonGoalsTable dungeonGoalsTable,
            IDungeonHistoryTable history,
            IDungeonLocationTable dungeonLocationTable,
            IDungeonPurposeTable purpose,
            IExitLocationTable exitLocationTable,
            IExitTypeTable exitTypeTable,
            IExoticLocationTable exoticLocationTable,
            IFormOfGovernmentTable formOfGovernmentTable,
            ILeaderTypeTable leaderTypeTable,
            IMonumentsTable monumentsTable,
            INPCAlignmentTable npcAlignmentTable,
            INPCClassTable npcClassTable,
            IOtherGoalsTable otherGoalsTable,
            IPassageTable passageTable,
            IPassageWidthTable passageWidthTable,
            IPrecipitationTable precipitationTable,
            IRaceRelationsTable raceRelationsTable,
            IRulerStatusTable rulerStatusTable,
            ISettlementsTable settlementsTable,
            IStairsTable stairsTable,
            IStartingAreaTable startingAreaTable,
            ITemperatureTable temperatureTable,
            IWeirdLocalesTable weirdLocalesTable,
            IWildernessGoalsTable wildernessGoalsTable,
            IWindTable windTable,
            IWorldShakingEventsTable worldShakingEventsTable
            )
        {
            // Initialize the tables
            beyondADoorTable.InitializeTable();
            chamberExitTable.InitializeTable();
            chamberTable.InitializeTable();
            cultsTable.InitializeTable();
            doorTypeTable.InitializeTable();
            dungeonCreatorTable.InitializeTable();
            dungeonGoalsTable.InitializeTable();
            history.InitializeTable();
            dungeonLocationTable.InitializeTable();
            purpose.InitializeTable();
            exitLocationTable.InitializeTable();
            exitTypeTable.InitializeTable();
            exoticLocationTable.InitializeTable();
            formOfGovernmentTable.InitializeTable();
            leaderTypeTable.InitializeTable();
            monumentsTable.InitializeTable();
            npcAlignmentTable.InitializeTable();
            npcClassTable.InitializeTable();
            otherGoalsTable.InitializeTable();
            passageTable.InitializeTable();
            passageWidthTable.InitializeTable();
            precipitationTable.InitializeTable();
            raceRelationsTable.InitializeTable();
            rulerStatusTable.InitializeTable();
            settlementsTable.InitializeTable();
            stairsTable.InitializeTable();
            startingAreaTable.InitializeTable();
            temperatureTable.InitializeTable();
            weirdLocalesTable.InitializeTable();
            wildernessGoalsTable.InitializeTable();
            windTable.InitializeTable();
            worldShakingEventsTable.InitializeTable();

            // Set the properties
            BeyondADoorTable = beyondADoorTable;
            ChamberExitTable = chamberExitTable;
            ChamberTable = chamberTable;
            CultsTable = cultsTable;
            DoorTypeTable = doorTypeTable;
            DungeonCreatorTable = dungeonCreatorTable;
            DungeonGoalsTable = dungeonGoalsTable;
            History = history;
            DungeonLocationTable = dungeonLocationTable;
            Purpose = purpose;
            ExitLocationTable = exitLocationTable;
            ExitTypeTable = exitTypeTable;
            ExoticLocationTable = exoticLocationTable;
            FormOfGovernmentTable = formOfGovernmentTable;
            LeaderTypeTable = leaderTypeTable;
            MonumentsTable = monumentsTable;
            NPCAlignmentTable = npcAlignmentTable;
            NPCClassTable = npcClassTable;
            OtherGoalsTable = otherGoalsTable;
            PassageTable = passageTable;
            PassageWidthTable = passageWidthTable;
            PrecipitationTable = precipitationTable;
            RaceRelationsTable = raceRelationsTable;
            RulerStatusTable = rulerStatusTable;
            SettlementsTable = settlementsTable;
            StairsTable = stairsTable;
            StartingAreaTable = startingAreaTable;
            TemperatureTable = temperatureTable;
            WeirdLocalesTable = weirdLocalesTable;
            WildernessGoalsTable = wildernessGoalsTable;
            WindTable = windTable;
            WorldShakingEventsTable = worldShakingEventsTable;
        }

        /// <summary>
        /// Properties for injected tables
        /// </summary>
        private IBeyondADoorTable BeyondADoorTable { get; }
        private IChamberExitTable ChamberExitTable { get; }
        private IChamberTable ChamberTable { get; }
        private ICultsTable CultsTable { get; }
        private IDoorTypeTable DoorTypeTable { get; }
        private IDungeonCreatorTable DungeonCreatorTable { get; }
        private IDungeonGoalsTable DungeonGoalsTable { get; }
        private IDungeonHistoryTable History { get; }
        private IDungeonLocationTable DungeonLocationTable { get; }
        private IDungeonPurposeTable Purpose { get; }
        private IExitLocationTable ExitLocationTable { get; }
        private IExitTypeTable ExitTypeTable { get; }
        private IExoticLocationTable ExoticLocationTable { get; }
        private IFormOfGovernmentTable FormOfGovernmentTable { get; }
        private ILeaderTypeTable LeaderTypeTable { get; }
        private IMonumentsTable MonumentsTable { get; }
        private INPCAlignmentTable NPCAlignmentTable { get; }
        private INPCClassTable NPCClassTable { get; }
        private IOtherGoalsTable OtherGoalsTable { get; }
        private IPassageTable PassageTable { get; }
        private IPassageWidthTable PassageWidthTable { get; }
        private IPrecipitationTable PrecipitationTable { get; }
        private IRaceRelationsTable RaceRelationsTable { get; }
        private IRulerStatusTable RulerStatusTable { get; }
        private ISettlementsTable SettlementsTable { get; }
        private IStairsTable StairsTable { get; }
        private IStartingAreaTable StartingAreaTable { get; }
        private ITemperatureTable TemperatureTable { get; }
        private IWeirdLocalesTable WeirdLocalesTable { get; }
        private IWildernessGoalsTable WildernessGoalsTable { get; }
        private IWindTable WindTable { get; }
        private IWorldShakingEventsTable WorldShakingEventsTable { get; }

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
            AddTableToWord(tableSection, BeyondADoorTable);
            AddTableToWord(tableSection, ChamberTable);
            AddTableToWord(tableSection, ChamberExitTable);
            AddTableToWord(tableSection, CultsTable);
            AddTableToWord(tableSection, DoorTypeTable);
            AddTableToWord(tableSection, DungeonCreatorTable);
            AddTableToWord(tableSection, DungeonGoalsTable);
            AddTableToWord(tableSection, History);
            AddTableToWord(tableSection, DungeonLocationTable);
            AddTableToWord(tableSection, Purpose);
            AddTableToWord(tableSection, ExitLocationTable);
            AddTableToWord(tableSection, ExitTypeTable);
            AddTableToWord(tableSection, ExoticLocationTable);
            AddTableToWord(tableSection, FormOfGovernmentTable);
            AddTableToWord(tableSection, LeaderTypeTable);
            AddTableToWord(tableSection, MonumentsTable);
            AddTableToWord(tableSection, NPCAlignmentTable);
            AddTableToWord(tableSection, NPCClassTable);
            AddTableToWord(tableSection, OtherGoalsTable);
            AddTableToWord(tableSection, PassageTable);
            AddTableToWord(tableSection, PassageWidthTable);
            AddTableToWord(tableSection, PrecipitationTable);
            AddTableToWord(tableSection, RaceRelationsTable);
            AddTableToWord(tableSection, RulerStatusTable);
            AddTableToWord(tableSection, SettlementsTable);
            AddTableToWord(tableSection, StairsTable);
            AddTableToWord(tableSection, StartingAreaTable);
            AddTableToWord(tableSection, TemperatureTable);
            AddTableToWord(tableSection, WeirdLocalesTable);
            AddTableToWord(tableSection, WildernessGoalsTable);
            AddTableToWord(tableSection, WindTable);
            AddTableToWord(tableSection, WorldShakingEventsTable);

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
