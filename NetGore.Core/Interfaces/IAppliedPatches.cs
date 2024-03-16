namespace NetGore.Core.Interfaces;

public interface IAppliedPatches
{
    /// <summary>
    /// The datetime the patch was applied.
    /// </summary>
    DateTime? DateApplied { get; set; }

    /// <summary>
    /// The filename of the patch that was applied.
    /// </summary>
    string? FileName { get; set; }
}