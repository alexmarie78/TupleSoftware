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
    class TupleAPI
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
            Tuples.Add(new Tuple<int, int>(x, y));
        }

       
        /// <summary>
        /// Return the sum of all element of the list of Tuples
        /// </summary>
        /// <returns>Integer</returns>
        public int Sum()
        {
            var sum = 0;
            foreach(var tuple in Tuples)
            {
                sum += tuple.Item1 + tuple.Item2;
            }
            return sum;
        }
    }
}
