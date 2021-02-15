using System;
using System.Collections.Generic;

namespace CodingChallanges
{
    public class FibonacciHelper
    {
        private List<int> previousResult = new List<int>();

        public int GetNumber(int v)
        {
            if (v == 0 || v == 1) return v;
            return GetNumber(v - 1) + GetNumber(v - 2);
        }

        public int[] GetSequenceUpTo(int v)
        {
            var result = new List<int>();

            for (int i = 0; i < v; i++)
            {
                if (previousResult.Count > 0 && previousResult.Count == i - 1)
                {
                    result.Add(previousResult[i]);
                }
                else
                {
                    var nextResult = GetNumber(i);
                    previousResult.Add(nextResult);
                    result.Add(nextResult);
                }
            }

            return result.ToArray();
        }
    }
}
