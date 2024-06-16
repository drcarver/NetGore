namespace GoDungeon.PDFParser.interfaces;

public interface IProcessPDFFiles
{
    /// <summary>
    /// Extract the tables as text from the pdf
    /// </summary>
    /// <param name="inputPDF"></param>
    void ExtractTables(string inputPDF);
}