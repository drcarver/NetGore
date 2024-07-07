//
// Container Capacity view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// IContainer Capacity
/// </summary>
public interface IContainerCapacityTableEntry : IStandardTableEntry
{
	/// <summary>
	/// Container
	/// </summary>
	public string Container { get; set; }

	/// <summary>
	/// Capacity
	/// </summary>
	public string Capacity { get; set; }

}
