using Microsoft.Extensions.DependencyInjection;

namespace NetGore.Data;

public static class DataServices
{
    public static IServiceCollection UseNetGoreItems(this IServiceCollection collection)
    {
        return collection;
    }
}
