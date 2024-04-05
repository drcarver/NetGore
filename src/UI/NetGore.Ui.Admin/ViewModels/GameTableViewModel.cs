using CommunityToolkit.Mvvm.ComponentModel;

using NetGore.Core.Interfaces;

namespace NetGore.Data.ViewModels;

public class GameTableViewModel : ObservableValidator
{
    private List<IGameTable> GameTables { get; } = [];

    /// <summary>
    /// The list of tables for the application.
    /// </summary>
    /// <param name="services">The ServiceProvider</param>
    public GameTableViewModel(IServiceProvider services)
    {
        GameTables.AddRange(services.GetServices<IGameTable>());
    }
}
