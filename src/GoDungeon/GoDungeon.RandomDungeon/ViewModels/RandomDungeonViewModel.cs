using System;
using System.Drawing;
using System.Net.Http.Headers;

using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Interfaces;

namespace GoDungeon.RandomDungeon.ViewModels
{
    public class RandomDungeonViewModel : BaseObjectViewModel, IRandomDungeon
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RandomDungeonViewModel(IServiceProvider services) 
        {
            Services = services;
        }

        private IServiceProvider Services { get; }

        public int[,] GenerateRandomDungeon(int height, int width)
        {
            var dungeon = new int[height, width];

            return dungeon;
        }
    }
}
