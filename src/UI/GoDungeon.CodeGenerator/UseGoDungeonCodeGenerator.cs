using GoDungeon.CodeGenerator.CodeGen;
using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CommandLineTools.CodeGen;

namespace GoDungeon.CodeGenerator
{
    public static class DataServices
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static IServiceCollection UseGoDungeonCodeGenerator(this IServiceCollection collection)
        {
            //collection
            collection
                .AddSingleton<IGenerateHtml, GenerateHtml>()
                .AddSingleton<IGenerateMonster, GenerateMonster>()
                .AddSingleton<IParseMonsterMarkdown, ParseMonsterMarkdown>()
                .AddSingleton<IProcess5ESRDFiles, Process5ESRDFiles>()
                ;
            return collection;
        }
    }
}
