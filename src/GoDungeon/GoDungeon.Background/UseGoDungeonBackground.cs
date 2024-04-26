using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using GoDungeon.Background.Interfaces;
using GoDungeon.Background.Tables;
using GoDungeon.Background.Tables.Halfling;
using GoDungeon.Core.Tables;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.Background
{
    public static class DataServices
    {
        /// <summary>
        /// Get all the IGameable entries
        /// </summary>
        /// <returns></returns>
        public static List<Type> BackGroundTables => Assembly
            .GetExecutingAssembly()
            .GetExportedTypes()
            .Where(t =>
                    t.IsSubclassOf(typeof(GameTable))
                && t.Name != nameof(RandomTable)
                && t.Name != nameof(NamedTable))
            .ToList();

        /// <summary>
        /// The D20 Core tables and services
        /// </summary>
        /// <param name="collection">The DI service collection</param>
        /// <returns>The services collection</returns>
        public static IServiceCollection UseGoDungeonBackground(this IServiceCollection collection)
        {
            //collection
            // The race tables
            #region Halfling
            collection.AddTransient<IHalflingHomelandTable, HalflingHomelandTable>();
            collection.AddTransient<IHalflingParentsTable, HalflingParentsTable>();
            collection.AddTransient<IHalflingSiblingsTable, HalflingSiblingsTable>();
            #endregion

            // The background table
            #region Background Tables
            collection.AddTransient<IAdoptedOutsideYourRaceTable, AdoptedOutsideYourRaceTable>();
            collection.AddTransient<ICharacterDrawbackTable, CharacterDrawbackTable>();
            collection.AddTransient<ICircumstanceofBirthTable, CircumstanceofBirthTable>();
            collection.AddTransient<IConflictMotivationTable, ConflictMotivationTable>();
            collection.AddTransient<IConflictResolutionTable, ConflictResolutionTable>();
            collection.AddTransient<IConflictSubjectTable, ConflictSubjectTable>();
            collection.AddTransient<IConflictTable, ConflictTable>();
            collection.AddTransient<ICrimeTable, CrimeTable>();
            collection.AddTransient<IInfluentialAssociatesTable, InfluentialAssociatesTable>();
            collection.AddTransient<IMajorChildhoodEventTable, MajorChildhoodEventTable>();
            collection.AddTransient<INobilityTable, NobilityTable>();
            collection.AddTransient<IProfessionTable, ProfessionTable>();
            collection.AddTransient<IPunishmentTable, PunishmentTable>();
            collection.AddTransient<IRelationshipwithFellowAdventurerTable, RelationshipwithFellowAdventurerTable>();
            collection.AddTransient<IRelativeAgeofSiblingTable, RelativeAgeofSiblingTable>();
            collection.AddTransient<IRomanticRelationshipsTable, RomanticRelationshipsTable>();
            collection.AddTransient<IUnusualHomelandTable, UnusualHomelandTable>();
            #endregion

            return collection;
        }
    }
}
