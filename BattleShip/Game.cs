using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    internal class Game
    {
        public void Start()
        {
            // create grids for both players
            Grid playerGrid = new Grid();
            Grid botGrid = new Grid();

            // game will continue until one of the player has 0 ships left
            while (playerGrid.ships.Count > 0 || botGrid.ships.Count > 0)
            {
                playerGrid.printGrid();
                Console.ReadLine();
            }
            {

            }
        }


    }
}
