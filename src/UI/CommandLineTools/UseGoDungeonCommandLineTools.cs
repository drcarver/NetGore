using GoDungeon.CommandLineTools.CodeGen;
using GoDungeon.CommandLineTools.Interfaces;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.CommandLineTools
{
    public static class DataServices
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IServiceCollection UseGoDungeonCommandLineTools(this IServiceCollection collection)
        {
            //collection
            collection
                .AddTransient<IGenerateHtml, GenerateHtml>()
                ;
            return collection;
        }
    }
}
