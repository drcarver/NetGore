using CommunityToolkit.Maui;

using NetGore.Data.ViewModels;
using NetGore.UI.Admin.Views;

namespace NetGore.Data;

public static class DataServices
{
    public static IServiceCollection UseNetGoreUIAdmin(this IServiceCollection collection)
    {
        collection
            // Add a view and view model
            .AddSingleton<NewContent1, GameTableViewModel>();
        return collection;
    }
}
