using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.MAUI.Interfaces;

namespace GoDungeon.MAUI.ViewModels;

public partial class MainViewModel : ObservableObject, IMainViewModel
{
    [ObservableProperty]
    private string title = "Main View Model";

    [ObservableProperty]
    private FormattedString pageDescription = new FormattedString();

    [ObservableProperty]
    private FormattedString pageHeader = new FormattedString();

    [ObservableProperty]
    private FormattedString pageBody = new FormattedString();

    public MainViewModel()
    {
        PageDescription.Spans.Add(new Span 
        {
            Text = "Rules and information governing player time between adventures (downtime)\n" 
        });
        PageHeader.Spans.Add(new Span
        {
            Text = "Between Adventures"
        });
        PageBody.Spans.Add(new Span
        {
            Text = "Between trips to dungeons and battles against ancient evils, adventurers need time to rest, recuperate, and prepare for their next adventure. Many adventurers also use this time to perform other tasks, such as crafting arms and armor, performing research, or spending their hard-earned gold.\n\n"
        });
        PageBody.Spans.Add(new Span
        {
            Text = "In some cases, the passage of time is something that occurs with little fanfare or description. When starting a new adventure, the GM might simply declare that a certain amount of time has passed and allow you to describe in general terms what your character has been doing. At other times, the GM might want to keep track of just how much time is passing as events beyond your perception stay in motion.\n"
        });
    }
}