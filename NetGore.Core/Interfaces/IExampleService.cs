using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IExampleService
{
    /// <summary>
    /// Get the list of examples
    /// </summary>
    List<Example> GetExamples();

    /// <summary>
    /// Add a new example to the database
    /// </summary>
    /// <param name="name">The name of the example</param>
    /// <param name="description">The description of the example</param>
    void AddExample(string name, string? description = null);
}
