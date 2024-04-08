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
            .AddTransientWithShellRoute<GameTableDetailPage, GameTableDetailViewModel>(nameof(GameTableDetailPage))
            .AddTransientWithShellRoute<ConflictTableDetailPage, ConflictTableDetailViewModel>(nameof(ConflictTableDetailPage))
            .AddTransientWithShellRoute<BackgroundTableDetailPage, BackgroundTableDetailViewModel>(nameof(BackgroundTableDetailPage))
            .AddTransientWithShellRoute<CharacterAdvancementDetailPage, CharacterAdvancementDetailViewModel>(nameof(CharacterAdvancementDetailPage));

        return collection;
    }
}
