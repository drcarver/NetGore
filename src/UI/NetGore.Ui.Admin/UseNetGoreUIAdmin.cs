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
            .AddTransientWithShellRoute<BackgroundTableDetailPage, BackgroundTableDetailViewModel>(nameof(BackgroundTableDetailPage))
            .AddTransientWithShellRoute<CharacterAdvancementDetailPage, CharacterAdvancementDetailViewModel>(nameof(CharacterAdvancementDetailPage))
            .AddTransientWithShellRoute<ConflictTableDetailPage, ConflictTableDetailViewModel>(nameof(ConflictTableDetailPage))
            .AddTransientWithShellRoute<GameTableAdminPage, GameTableAdminViewModel>(nameof(GameTableAdminPage))
            .AddTransientWithShellRoute<GameTableDetailPage, GameTableDetailViewModel>(nameof(GameTableDetailPage))
            ;

        return collection;
    }
}
