//
// Container Capacity view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Container Capacity
/// </summary>
public partial class ContainerCapacityTableEntryViewModel : StandardTableEntryViewModel, IContainerCapacityTableEntry
{
	/// <summary>
	/// Container
	/// </summary>
	[ObservableProperty]
	private string container;

	/// <summary>
	/// Capacity
	/// </summary>
	[ObservableProperty]
	private string capacity;

}
