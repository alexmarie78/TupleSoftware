using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesTLAS.Objects
{
    /// <summary>
    /// Class TupleAPI
    /// API representing a list of tuple
    /// </summary>
    public class TupleAPI
    {
        /// <summary>
        /// List of Tuples
        /// </summary>
        public List<Tuple<int, int>> Tuples { get; } = new List<Tuple<int, int>>();

        /// <summary>
        /// Add a tuple to the list
        /// </summary>
        /// <param name="x"> First integer of the new Tuple</param>
        /// <param name="y"> Second integer of the new Tuple</param>
        public void Add(int x, int y)
        {
            if (Tuples.Count >= 10)
            {
                throw new ArgumentException("Max capacity");
            }

            if (x < 0 || y < 0)
            {
                throw new ArgumentException("Tuple members are not positives");
            }


            if (x + y > 10)
            {
                throw new ArgumentException("Max capacity of the tuple");
            }

            Tuples.Add(new Tuple<int, int>(x, y));
        }

        /// <summary>
        /// Return the sum of all element of the list of Tuples
        /// </summary>
        /// <returns>Integer</returns>
        public int Sum()
        {
            var sum = 0;

            for (var i = 0; i < Tuples.Count - 1; i++)
            {
                var temp = Tuples[i].Item1 + Tuples[i].Item2;
                sum += temp;

                if (Tuples[i].Item1 == 10)
                {
                    sum += Tuples[i + 1].Item1 + Tuples[i + 1].Item2;
                }
                else if (temp == 10)
                {
                    sum += Tuples[i + 1].Item1;
                }
            }

            // Handle last element
            sum += Tuples[Tuples.Count - 1].Item1 + Tuples[Tuples.Count - 1].Item2;

            return sum;
        }
    }
}