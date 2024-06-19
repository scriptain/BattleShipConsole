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
        public static string Shot(Grid opponentsGrid, int x, int y)
        {
            // check if a ship exists at coords for the shot
            int index = opponentsGrid.ships.FindIndex(ship => ship.x == x && ship.y == y);
            if (index != -1)
            {
                // register the hit by removing the opponents ship at the given index
                opponentsGrid.ships.RemoveAt(index);
                return "hit";
            } else
            {
                return "miss";
            }
            opponentsGrid.printGrid();
            Console.ReadLine();



        }

    }
}
