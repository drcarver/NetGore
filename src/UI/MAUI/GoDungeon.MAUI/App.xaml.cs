using System.Security.Claims;

namespace GoDungeon.MAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        
        var principal = ClaimsPrincipal.Current?.Identity?.Name;

        // Syncfusion License
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NHaF5cWWdCeEx3Q3xbf1x0ZFFMZVRbRHVPIiBoS35RckVmWHhfd3RRRGJUU0N/");

        MainPage = new AppShell();
    }
}
