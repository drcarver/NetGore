using System.Security.Claims;

namespace GoDungeon.MAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        
        var principal = ClaimsPrincipal.Current?.Identity?.Name;

        // Syncfusion License
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF1cXmhMYVFyWmFZfVpgcF9DYFZTRWY/P1ZhSXxXdkBiXn5YdXRXR2dUVEY=");

        MainPage = new AppShell();
    }
}
