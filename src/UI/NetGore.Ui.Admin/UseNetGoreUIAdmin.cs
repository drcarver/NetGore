using CommunityToolkit.Maui;

using NetGore.UI.Admin.ViewModel;
using NetGore.UI.Admin.Views;

namespace NetGore.Data;

public static class DataServices
{
    public static IServiceCollection UseNetGoreUIAdmin(this IServiceCollection collection)
    {
        collection
            // Add a view and view model with route
            .AddTransientWithShellRoute<GameTableDetailPage, GameTableDetailViewModel>(nameof(GameTableDetailPage));
        return collection;
    }
}
