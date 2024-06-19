using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    internal class Grid
    {
        // grid currently generates a 4x4 2d array of ship objects
        public Ship[,] grid = new Ship[3, 3];
        public List<Ship> ships = new List<Ship>();
        public int lives = 5;

        public Grid()
        {
            ships = createShips(ships);
        }

        // store 5 ship objects in 'ships'  
        private List<Ship> createShips(List<Ship> ships)
        {
            List<Ship> populatedShips = new List<Ship>();

            for(int i = 0; i < 5; i++)
            {
                bool placed = false;
                Random random = new Random();
                while(!placed)
                {
                    int randomX = random.Next(3);
                    int randomY = random.Next(3);
                    if(!populatedShips.Any(ship => ship.x == randomX && ship.y == randomY))
                    {
                        populatedShips.Add(new Ship(randomX, randomY));
                        placed = true;
                        break;
                    }
                }
            }
            return populatedShips;
        }

        public void printGrid()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            for (int x = 0; x < 4; x++)
            {
                Console.Write($"|");
                for(int y = 0; y < 4; y++)
                {
                    // check to see if a ship with x of x and y of y exist
                    if(ships.Any(ship => ship.x == x && ship.y == y))
                    {

                        Console.Write($" \t SHIP \t | ");
                    } else
                    {
                        Console.Write(" \t ~ \t | ");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }
    }
}
