using System.Reflection;

using CommunityToolkit.Maui;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.MAUI.Core.Interfaces;
using GoDungeon.MAUI.Core.Tables;
using GoDungeon.MAUI.Core.ViewModels;
using GoDungeon.MAUI.Core.Views;

namespace GoDungeon.MAUI.Core
{
    public static class DataServices
    {
        /// <summary>
        /// Get all the IGameable entries
        /// </summary>
        /// <returns></returns>
        public static List<Type> CoreTables => Assembly
            .GetExecutingAssembly()
            .GetExportedTypes()
            .Where(t => 
                    t.IsSubclassOf(typeof(GameTable)) 
                &&  t.Name != nameof(RandomTable)
                &&  t.Name != nameof(NamedTable))
            .ToList();

        /// <summary>
        /// The GoDungeon Core tables and services
        /// </summary>
        /// <param name="collection">The DI service collection</param>
        /// <returns>The services collection</returns>
        public static IServiceCollection UseGoDungeonMAUICore(this IServiceCollection collection)
        {
            //collection
            // Add all the game table types as transient
            collection.AddTransient<ICoreMenuTable, CoreMenuTable>();

            // The tables
            collection.AddTransientWithShellRoute<CoreMenuTablePage, CoreMenuTable>(nameof(CoreMenuTablePage));
            collection.AddTransientWithShellRoute<AbilityModifierTablePage, AbilityModifierTable>(nameof(AbilityModifierTablePage));
            collection.AddTransientWithShellRoute<AcrobaticsModifierTablePage, AcrobaticsModifierTable>(nameof(AcrobaticsModifierTablePage));
            collection.AddTransientWithShellRoute<AlignmentTablePage, AlignmentTable>(nameof(AlignmentTablePage));
            collection.AddTransientWithShellRoute<SpellAbilityModifierTablePage, SpellAbilityModifierTable>(nameof(SpellAbilityModifierTablePage));

            return collection;
        }
    }
}
