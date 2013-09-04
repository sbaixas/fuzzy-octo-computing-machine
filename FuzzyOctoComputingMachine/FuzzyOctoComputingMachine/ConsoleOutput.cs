using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FuzzyOctoComputingMachine
{
    class ConsoleOutput
    {
        //Static Class used to interpret game in console
        static char[,] grid;
        static int[] coords = new int[2];
        public static void Init(int sizeX, int sizeY)
        {
            grid = new char[sizeX, sizeY];
            CleanGrid();
            coords = new int[] { sizeX / 2, sizeY / 2 };
            Console.SetWindowSize(170, 50);
        }
        private static void CleanGrid()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = ' ';
                }
            }
        }
        private static void Update()
        {
            CleanGrid();
            grid[coords[0], coords[1]] = 'o';

        }
        private static void Draw()
        {
            Console.Clear();
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                string a = " ";
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    a += grid[i, j];
                }
                Console.WriteLine(a);
            }
            Thread.Sleep(17);
        }
        public static void Show()
        {
            Update();
            Draw();
        }
    }
}
