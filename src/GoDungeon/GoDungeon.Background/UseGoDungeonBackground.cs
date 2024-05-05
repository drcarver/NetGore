using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using GoDungeon.Background.Interfaces;
using GoDungeon.Background.Tables;
using GoDungeon.Background.Tables.Dragonborn;
using GoDungeon.Background.Tables.Dwarf;
using GoDungeon.Background.Tables.Elf;
using GoDungeon.Background.Tables.Gnome;
using GoDungeon.Background.Tables.HalfElf;
using GoDungeon.Background.Tables.Halfling;
using GoDungeon.Background.Tables.HalfOrc;
using GoDungeon.Background.Tables.Human;
using GoDungeon.Background.Tables.Tiefling;
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
        /// The GoDungeon Core tables and services
        /// </summary>
        /// <param name="collection">The DI service collection</param>
        /// <returns>The services collection</returns>
        public static IServiceCollection UseGoDungeonBackground(this IServiceCollection collection)
        {
            //collection
            // The race tables
            #region Race Background Tables
            collection.AddTransient<IDragonbornHomelandTable, DragonbornHomelandTable>();
            collection.AddTransient<IDragonbornParentsTable, DragonbornParentsTable>();
            collection.AddTransient<IDragonbornSiblingsTable, DragonbornSiblingsTable>();
            collection.AddTransient<IDwarfHomelandTable, DwarfHomelandTable>();
            collection.AddTransient<IDwarfParentsTable, DwarfParentsTable>();
            collection.AddTransient<IDwarfSiblingsTable, DwarfSiblingsTable>();
            collection.AddTransient<IElfHomelandTable, ElfHomelandTable>();
            collection.AddTransient<IElfParentsTable, ElfParentsTable>();
            collection.AddTransient<IElfSiblingsTable, ElfSiblingsTable>();
            collection.AddTransient<IGnomeHomelandTable, GnomeHomelandTable>();
            collection.AddTransient<IGnomeParentsTable, GnomeParentsTable>();
            collection.AddTransient<IGnomeSiblingsTable, GnomeSiblingsTable>();
            collection.AddTransient<IHalfElfHomelandTable, HalfElfHomelandTable>();
            collection.AddTransient<IHalfElfParentsTable, HalfElfParentsTable>();
            collection.AddTransient<IHalfElfSiblingsTable, HalfElfSiblingsTable>();
            collection.AddTransient<IHalflingHomelandTable, HalflingHomelandTable>();
            collection.AddTransient<IHalflingParentsTable, HalflingParentsTable>();
            collection.AddTransient<IHalflingSiblingsTable, HalflingSiblingsTable>();
            collection.AddTransient<IHalfOrcHomelandTable, HalfOrcHomelandTable>();
            collection.AddTransient<IHalfOrcParentsTable, HalfOrcParentsTable>();
            collection.AddTransient<IHalfOrcSiblingsTable, HalfOrcSiblingsTable>();
            collection.AddTransient<IHumanHomelandTable, HumanHomelandTable>();
            collection.AddTransient<IHumanParentsTable, HumanParentsTable>();
            collection.AddTransient<IHumanSiblingsTable, HumanSiblingsTable>();
            collection.AddTransient<ITieflingHomelandTable, TieflingHomelandTable>();
            collection.AddTransient<ITieflingParentsTable, TieflingParentsTable>();
            collection.AddTransient<ITieflingSiblingsTable, TieflingSiblingsTable>();
            #endregion

            // The background tables
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
