using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// PROGRAM NO LONGER USES THIS EXTENSION CLASS
namespace BattleShip
{
    internal static class ListExtensions
    {

        // This method is the custom behaviour that extends List printing
        // "StringBuilder allows you to append, insert, and modify strings in a flexible and efficient way" 
        // Allows for appending, modifying, and inserting strings without creating a temporary string. mutable. 
        // stringBuilder has .Append("Mr"), .Insert(0,"Good"), .Remove(0,10)
        public static string ShowCell<T>(this List<T> Ships)
        {

            return "BOX";
        }
    }
}
