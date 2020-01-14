using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuplesTLAS.GameManager;

namespace TuplesTLAS
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bowling Game !");

            var game = new Game();
            game.LaunchGame();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
