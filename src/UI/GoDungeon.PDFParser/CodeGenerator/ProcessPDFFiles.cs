using GoDungeon.PDFParser.interfaces;

using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;

namespace GoDungeon.PDFParser.CodeGenerator;

public class ProcessPDFFiles : IProcessPDFFiles
{
    /// <summary>
    /// Extract tables from pages in the PDF
    /// </summary>
    /// <param name="inputPDF"></param>
    public void ExtractTables(string inputPDF)
    {
        string pdfFilePath = inputPDF;

        // Load the PDF document
        //Get stream from an existing PDF document
        FileStream docStream = new FileStream(pdfFilePath, FileMode.Open, FileAccess.Read);
            
        //Load the PDF document
        PdfLoadedDocument loadedDocument = new PdfLoadedDocument(docStream);
        string extractedText = string.Empty;

        //Extract all the text from the PDF document pages
        extractedText = loadedDocument.Pages[289].ExtractText();

        //Save the text to file
        File.WriteAllText(@"..\..\..\RDTables.txt", extractedText);

        //Close the document
        loadedDocument.Close(true);
    }
}
