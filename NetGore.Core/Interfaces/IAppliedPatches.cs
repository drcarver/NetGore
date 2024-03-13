namespace NetGore.Core.Interfaces;

public interface IAppliedPatches
{
    DateTime DateApplied { get; set; }
    string FileName { get; set; }
}