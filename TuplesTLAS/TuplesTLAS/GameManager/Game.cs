using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuplesTLAS.Objects;

namespace TuplesTLAS.GameManager
{
    public class Game
    {
        private TupleAPI tupleAPI;

        public Game()
        {
            tupleAPI = new TupleAPI();
        }

        /// <summary>
        /// Scenario of game
        /// </summary>
        public int LaunchGame(TupleAPI tupleApi = null)
        {
            int score = 0;
            for (int i = 0; i < 10; i++)
            {
                int value1 = 0, value2 = 0;

                Console.WriteLine("Lancer n°" + (i+1));

                value1 = EnterFirstValue(tupleApi, i);

                if (!value1.Equals(10))
                {
                    value2 = EnterSecondValue(value1, tupleApi, i);
                }
                else
                {
                    Console.WriteLine("Bravo pour votre Strike");
                }
              
                // add new tuple
                tupleAPI.Add(value1, value2);
                score = tupleAPI.Sum();

                // last
                if (i.Equals(9))
                {
                    if(value1.Equals(10))  // if strick
                    {
                        value1 = EnterFirstValue(tupleApi, i);
                        if (!value1.Equals(10))
                        {
                            value2 = EnterSecondValue(value1, tupleApi, i);
                        }
                        score += value1 + value2;
                    }
                    if(value1 + value2 == 10)
                    {
                        value1 = EnterFirstValue();
                        score += value1;
                    }
                }

                // display score
                Console.WriteLine("Votre score : " + score);
            }

            Console.WriteLine("Partie terminée, votre score : " + score);
            return score;
        }

        /// <summary>
        ///  First entry of score
        /// </summary>
        /// <returns></returns>
        public int EnterFirstValue(TupleAPI tupleApi = null, int index = 0)
        {
            if(tupleApi != null)
            {
                return tupleApi.Tuples.ElementAt(index).Item1;
            }

            bool ok = false;
            int value = 0;
            while (!ok)
            {
                Console.Write("Entrer le nombre de quille tombée au premier coup : ");
                value = Int32.Parse(Console.ReadLine());
                if (value > 0 && value <= 10)
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Entrée non valide, recommencez.");
                }
            }
            return value;
        }

        /// <summary>
        /// Second entry of score
        /// </summary>
        /// <param name="valueFirstTry"></param>
        /// <returns></returns>
        public int EnterSecondValue(int valueFirstTry, TupleAPI tupleApi = null, int index = 0)
        {
            if (tupleApi != null)
            {
                return tupleApi.Tuples.ElementAt(index).Item2;
            }

            bool ok = false;
            int value = 0;
            while (!ok)
            {
                Console.Write("Entrer le nombre de quille tombée au deuxième coup : ");
                value = Int32.Parse(Console.ReadLine());
                if (value > 0 && value <= (10 - valueFirstTry))
                {
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Entrée non valide, recommencez.");
                }
            }
            return value;
        }
    }
}