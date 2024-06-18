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
            Player player = new Player(new Grid());
            Player bot = new Player(new Grid());
            bool playersTurn = true;
            bot.grid.printGrid();
            // game will continue until one of the player has 0 ships left
            while (player.grid.ships.Count > 0 || bot.grid.ships.Count > 0)
            {
                if (playersTurn)
                {
                    while(playersTurn)
                    {
                       // Console.WriteLine("It is your turn");
                        //Console.WriteLine("Top Left is (x: 0, y: 0)");
                        //Console.WriteLine("Bottom Right is (x: 3, y: 3)");
                        //Console.WriteLine("");
                        Console.WriteLine("enter a number (0 - 3) for X:  ");
                        string inputX = Console.ReadLine();
                        int x;
                        int y;
                        if(int.TryParse(inputX, out x))
                        {
                            // user entered an int, check if int is < 4
                            if(x < 4)
                            {
                                // user has entered a suitable x coordinate for their turn
                                // prompt user for a y value
                                Console.WriteLine("enter a number (0 - 3) for Y:  ");
                                string inputY = Console.ReadLine();
                                if (int.TryParse(inputY, out y))
                                {
                                    if (y < 4)
                                    {
                                        // TODO: check if the move has been made before

                                        Player.Shot(bot.grid,x, y);
                                        playersTurn = false;
                                        break;

                                    } else
                                    {
                                        Console.WriteLine("You must enter a Number between 0 and 3 (inclusive)");
                                        break;
                                    }
                                } else
                                {
                                    Console.WriteLine("You must enter a Number between 0 and 3 (inclusive)");
                                    break;
                                }

                            } else
                            {
                                Console.WriteLine("You must enter a number between 0 and 3 (inclusive)");
                                break;
                            }
                        } else // user entered a letter, prompt them for a number between 0 and 3
                        {
                            Console.WriteLine("You must enter a Number between 0 and 3(inclusive)");
                            break; 
                        }
                    }
                } else // bots turn
                {
                    //Console.WriteLine("Bots turn");
                    //Console.ReadLine();
                    break;
                }
                //player.grid.printGrid();
            }
            {

            }
        }


    }
}
