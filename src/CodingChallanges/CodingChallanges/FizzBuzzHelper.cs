using System.Collections.Generic;

namespace CodingChallanges
{
    public class FizzBuzzHelper
    {
        public List<string> GetList(FizzBuzzVersion fizzBuzzVersion = FizzBuzzVersion.Base, int maxNumber = 100)
        {
            switch (fizzBuzzVersion)
            {
                case FizzBuzzVersion.Base:
                    return GetList_BaseVersion(maxNumber);                    
                case FizzBuzzVersion.Verstion2:
                    return GetList_2ndVersion(maxNumber);
                case FizzBuzzVersion.UsingRules:
                    return GetList_UsingRules(maxNumber);
            }

            return null;
        }

        private List<string> GetList_UsingRules(int maxNumber)
        {
            var resultList = new List<string>();

            var ruleList = new Dictionary<string, int>
            {
                { "Fizz", 3 },
                { "Buzz", 5 }
            };

            for (int i = 1; i < maxNumber; i++)
            {
                var newEntry = "";
                foreach (var rule in ruleList)
                {
                    if (i % rule.Value == 0)
                    {
                        newEntry += rule.Key;
                    }
                }

                if (string.IsNullOrEmpty(newEntry))
                    newEntry = i.ToString();

                resultList.Add(newEntry);
            }

            return resultList;
        }

        private List<string> GetList_2ndVersion(int maxNumber)
        {
            var resultList = new List<string>();
            for (int i = 1; i < maxNumber; i++)
            {
                var newEntry = "";
                if (i % 3 == 0)
                {
                    newEntry += "Fizz";
                }
                else if (i % 5 == 0)
                {
                    newEntry += "Buzz";
                }
                else
                {
                    newEntry += i.ToString();
                }

                resultList.Add(newEntry);
            }

            return resultList;
        }

        private List<string> GetList_BaseVersion(int maxNumber)
        {
            var resultList = new List<string>();
            for (int i = 1; i < maxNumber; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    resultList.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    resultList.Add("Fizz");
                }
                else if(i % 5 == 0)
                {
                    resultList.Add("Buzz");
                }
                else
                {
                    resultList.Add(i.ToString());
                }
            }

            return resultList;
        }
    }

    public enum FizzBuzzVersion { Base, Verstion2, UsingRules }
}
