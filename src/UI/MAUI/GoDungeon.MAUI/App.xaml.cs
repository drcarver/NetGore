using System.Security.Claims;

namespace GoDungeon.MAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        
        var principal = ClaimsPrincipal.Current?.Identity?.Name;

        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Environment.GetEnvironmentVariable("SyncfusionLicense"));
        
        MainPage = new AppShell();
    }
}
