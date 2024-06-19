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
            // game will continue until one of the player has 0 ships left
            while (player.grid.ships.Count > 0 || bot.grid.ships.Count > 0)
            {
                if (playersTurn)
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

                                        string result = Player.Shot(bot.grid,x, y);
                                    if (result == "hit")
                                    {

                                        Console.WriteLine($"You shot at X: {x}, Y: {y} and...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("You got a hit!");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("Good work.");
                                    }
                                    else 
                                    {

                                        Console.WriteLine($"You shot at X: {x}, Y: {y} and...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("You missed.");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("Better luck next time.");
                                        Thread.Sleep(2000);


                                    }

                                    Console.WriteLine($"Bot has {bot.grid.ships.Count} ships left.");
                                    Thread.Sleep(2000);

                                    Console.WriteLine("Press any key to start bots turn");
                                        Console.ReadKey();
                                        playersTurn = false;

                                    } else
                                    {
                                        Console.WriteLine("You must enter a Number between 0 and 3 (inclusive)");
                                    }
                                } else
                                {
                                    Console.WriteLine("You must enter a Number between 0 and 3 (inclusive)");
                                }

                            } else
                            {
                                Console.WriteLine("You must enter a number between 0 and 3 (inclusive)");
                            }
                        } else // user entered a letter, prompt them for a number between 0 and 3
                        {
                            Console.WriteLine("You must enter a Number between 0 and 3(inclusive)");
                        }
                } else // bots turn
                {
                    Console.Clear();
                    Console.WriteLine("Bots turn");
                    // generate a random x and y 
                    Random random = new Random();
                    int x = random.Next(3);
                    int y = random.Next(3);
                    string result = Player.Shot(player.grid, x, y);
                    Thread.Sleep(2000);
                    Console.WriteLine($"The bot shot at: X: {x} Y: {y}");
                    Thread.Sleep(2000);
                    if (result == "hit") Console.WriteLine("The bot got a hit on one of your ships");
                    else Console.WriteLine("The bot missed your ships");
                    Thread.Sleep(2000);

                    Console.WriteLine($"You have {player.grid.ships.Count} ships left.");
                    Thread.Sleep(2000);
                    // Prompt the user to enter a key to continue to their turn
                    Console.WriteLine("Enter any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    // Players turn again
                    playersTurn = true;
                    
                }
                //player.grid.printGrid();
            }

            // one of the players has lost
            Console.WriteLine("Game over");
            Console.ReadLine();
        }


    }
}
