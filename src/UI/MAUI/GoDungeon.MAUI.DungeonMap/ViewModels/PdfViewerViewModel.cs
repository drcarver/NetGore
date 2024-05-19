using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GoDungeon.Core.Interfaces;
using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.ViewModels
{
    public partial class PdfViewerViewModel : ObservableObject, IQueryAttributable, IPdfViewer
    {
        /// <summary>
        /// The PDF document stream that is loaded into the instance of the 
        /// PDF viewer. 
        /// </summary>
        [ObservableProperty]
        private Stream? pdfDocumentStream;

        [RelayCommand]
        private async Task SaveFile() 
        {
            if (PdfDocumentStream != null) 
            {
                PdfDocumentStream.Position = 0;
                var fileSaverResult = await FileSaver.Default.SaveAsync("RandomDungeon.pdf", PdfDocumentStream);
                if (fileSaverResult.IsSuccessful)
                {
                    await Toast.Make($"The file was saved successfully to location: {fileSaverResult.FilePath}").Show();
                }
                else
                {
                    await Toast.Make($"The file was not saved successfully with error: {fileSaverResult.Exception.Message}").Show();
                }
            }
        }

        /// <summary>
        /// Get the BindingContext from the query parameter
        /// </summary>
        /// <param name="query"></param>
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            PdfDocumentStream = (Stream) query["pdfDocument"];
        }
    }
}