using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEnum
{
    public enum Move { Up='\u2191', Down='\u2193', Left='\u2190', Right='\u2192' }

    public class Program
    {
        static void Main(string[] args)
        {
            Move move = Move.Up;
            Console.WriteLine("{0} {1} {2:x} {3}", move, (int)move, (int)move, (char)move);

            move = Move.Down;
            Console.WriteLine("{0} {1} {2:x} {3}", move, (int)move, (int)move, (char)move);

            move = Move.Left;
            Console.WriteLine("{0} {1} {2:x} {3}", move, (int)move, (int)move, (char)move);
            
            move = Move.Right;
            Console.WriteLine("{0} {1} {2:x} {3}", move, (int)move, (int)move, (char)move);

            Console.WriteLine();
        }
    }
}
