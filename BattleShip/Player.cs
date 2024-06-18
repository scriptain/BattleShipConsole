using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    internal class Player
    {
        public Grid grid;

        public Player(Grid grid) {
            this.grid = grid;
        }
        // takes in the other players grid
        public static void Shot(Grid grid, int x, int y)
        {
            // check if a ship exists at coords for the shot
            int index = grid.ships.FindIndex(ship => ship.x == x && ship.y == y);
            if (index != -1)
            {
                Console.WriteLine("HIT~~~~~~~~~~~");
                Console.WriteLine(grid.ships[index]);
                grid.ships.RemoveAt(index);
            }
            grid.printGrid();
            Console.ReadLine();



        }

    }
}
