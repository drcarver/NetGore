using System.Security.Claims;

namespace GoDungeon.MAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        
        var principal = ClaimsPrincipal.Current?.Identity?.Name;
    
        MainPage = new AppShell();
    }
}
