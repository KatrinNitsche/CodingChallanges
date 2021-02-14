using System;
using System.Collections.Generic;

namespace CodingChallanges
{
    public class ColumnHeaderHelper
    {
        private List<string> LookUp = new List<string>();

        public ColumnHeaderHelper()
        {
            for (int i = 0; i < 26; i++)
            {
                LookUp.Add(char.ConvertFromUtf32(65 + i));
            }
        }

        public string HeaderFor(int v)
        {
            if (v < 0) return string.Empty;

            v -= 1;

            int remaining = v / 26;
            if (remaining > 0)
                return HeaderFor(remaining) + LookUp[v % 26].ToString();
            else
                return LookUp[v % 26].ToString();
        }
    }
}
