using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    internal class Ship
    {
        bool hit;
        public int x { get; set; }
        public int y { get; set; }
        public Ship(int x, int y) {
            this.x = x; 
            this.y = y;
        }
        public override string ToString()
        {
            return $"SHIP";
        }
    }

}
