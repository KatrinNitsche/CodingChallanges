using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallanges
{
    public class AnagramHelper
    {
        public bool Compare(string word1, string word2)
        {
            var listOfLetters1 = new HashSet<char>(word1.ToLower().ToList());
            var listOfLetters2 = new HashSet<char>(word2.ToLower().ToList());

            var orderedList1 = listOfLetters1.OrderBy(x => x);
            var orderedList2 = listOfLetters2.OrderBy(x => x);

            if (orderedList1.Count() != orderedList2.Count()) return false;

            for (int i = 0; i < orderedList1.Count(); i++)
            {
                if (orderedList1.ElementAt(i) != orderedList2.ElementAt(i)) return false;
            }

            return true;
        }
    }
}
