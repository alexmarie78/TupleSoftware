using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuplesTLAS.GameManager;
using TuplesTLAS.Objects;

namespace TuplesTLAS
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bowling Game !");

            var game = new Game();
            var tuple = new TupleAPI();
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(10, 0);
            tuple.Add(5, 1);
            
            /*
            tuple.Add(2, 8);
            tuple.Add(6, 0);
            */
            

            game.LaunchGame(tuple, valueBonus1:6, valueBonus2:2);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
