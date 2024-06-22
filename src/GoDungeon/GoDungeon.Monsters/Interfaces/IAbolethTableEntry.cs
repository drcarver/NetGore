//
// Aboleth view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Monsters.Interfaces;

/// <summary>
/// IAboleth
/// </summary>
public interface IAbolethTableEntry : IStandardTableEntry
{
	/// <summary>
	/// STR
	/// </summary>
	public string STR { get; set; }

	/// <summary>
	/// DEX
	/// </summary>
	public string DEX { get; set; }

	/// <summary>
	/// CON
	/// </summary>
	public string CON { get; set; }

	/// <summary>
	/// INT
	/// </summary>
	public string INT { get; set; }

	/// <summary>
	/// WIS
	/// </summary>
	public string WIS { get; set; }

	/// <summary>
	/// CHA
	/// </summary>
	public string CHA { get; set; }

}
