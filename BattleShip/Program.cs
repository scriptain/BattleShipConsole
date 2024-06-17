    using System;
    using System.Collections.Generic;

    namespace BattleShip

    {
        internal class Program
        {
            static void Main(string[] args)
            {   
                Game game = new Game();
                game.Start();

            }

            class Game
            {
                public void Start()
                {
                    while (true)
                    {
                        Grid grid = new Grid();
                        Console.WriteLine(grid);
                        Console.ReadLine();
                    }
                }
                // run the intro. Show the game banner, ask user for their name

                // build the ships 

                    // pass the players to the Grid class, store outcome in grid variable
                // begin game
            }

            class Grid
            {
                // grid currently generates a 5x5 2d array of ship objects
                public List<Ship>[,] grid = new List<Ship>[5, 5];

                public Grid()
                {
                    populateGrid();
                }

                public override string ToString()
                {
                    return "jldksfjsldkjflwkjfalkjd";
                }

            // sets each cell in the grid to have an empty list of ships 
            private void populateGrid()
            {
                for(int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        grid[i,j] = new List<Ship>();
                    }
                }
            }

            }

            class Ship
            {
                bool hit;

            }
        }
    }
