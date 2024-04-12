namespace D20.Core;

public static class DataServices
{
    public static IServiceCollection UseD20Core(this IServiceCollection collection)
    {
        //collection
        // Add a view and view model with route
        //.AddTransientWithShellRoute<GameTableDetailPage, GameTableDetailViewModel>(nameof(GameTableDetailPage))
        //.AddTransientWithShellRoute<ConflictTableDetailPage, ConflictTableDetailViewModel>(nameof(ConflictTableDetailPage))
        //.AddTransientWithShellRoute<BackgroundTableDetailPage, BackgroundTableDetailViewModel>(nameof(BackgroundTableDetailPage))
        //.AddTransientWithShellRoute<CharacterAdvancementDetailPage, CharacterAdvancementDetailViewModel>(nameof(CharacterAdvancementDetailPage));

        return collection;
    }
}
