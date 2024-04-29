using System;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.ViewModels.Humanoid;

using Microsoft.Extensions.DependencyInjection;

namespace GoDungeon.Monsters.ViewModels
{
    public class HumanoidRaceFactory : IHumanoidRaceFactory
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="raceTable">The able of humanoid races</param>
        public HumanoidRaceFactory(
            IHumanoidRaceTable raceTable,
            IServiceProvider services)
        {
            RaceTable = raceTable;
            Services = services;
        }

        /// <summary>
        /// The humanoid race table
        /// </summary>
        private IHumanoidRaceTable RaceTable { get; }

        /// <summary>
        /// THe service provider
        /// </summary>
        private IServiceProvider Services { get; }

        /// <summary>
        /// Create a humanoid of the proper race
        /// </summary>
        /// <param name="race">The humanoid race to create</param>
        /// <returns>The new humanoid race object</returns>
        public IHumanoidRace Create(RaceEnum race) => GetHumanoidRace(race);

        /// <summary>
        /// Create a random humanoid race using the race table
        /// </summary>
        /// <returns></returns>
        public IHumanoidRace? CreateRandom()
        {
            RaceTable.InitializeTable();
            IRaceTableEntry? raceTableEntry = (IRaceTableEntry?)RaceTable.GetRandomRangeEntry();
            if (raceTableEntry != null)
            {
                return GetHumanoidRace(raceTableEntry.Race);
            }
            return null;
        }

        /// <summary>
        /// The humanoid Race's
        /// </summary>
        /// <returns>The humanoid race created</returns>
        private IHumanoidRace? GetHumanoidRace(RaceEnum race)
        {
            switch (race)
            {
                case RaceEnum.Dragonborn:
                    return Services?.GetService<IDragonborn>();
                case RaceEnum.Dwarf:
                    return Services?.GetService<IDwarf>();
                case RaceEnum.Elf:
                    return Services?.GetService<IElf>();
                case RaceEnum.Gnome:
                    return Services?.GetService<IGnome>();
                case RaceEnum.HalfElf:
                    return Services?.GetService<IHalfElf>();
                case RaceEnum.Halfling:
                    return Services?.GetService<IHalfling>();
                case RaceEnum.HalfOrc:
                    return Services?.GetService<IHalfOrc>();
                case RaceEnum.Human:
                    return Services?.GetService<IHuman>();
                case RaceEnum.Tiefling:
                    return Services?.GetService<ITiefling>();
                default:
                    return new HumanoidRaceViewModel() { Race = race };
            }
        }
    }
}
