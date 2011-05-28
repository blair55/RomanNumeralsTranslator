using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.Core.NumeralProcessing
{
    public static class NumeralProcessor
    {
        public static int GetIntegerFromNumerals(string numerals)
        {
            List<int> integers = GetIntegerCollectionFromNumerals(numerals);
            int total = 0;

            for (int i = 0; i < integers.Count; i++)
            {
                if (i == integers.Count - 1)
                    total += integers[i];
                else
                {
                    int current = integers[i];
                    int next = integers[i + 1];

                    if (next > current)
                    {
                        total += (next - current);
                        i++;
                    }
                    else
                        total += current;
                }
            }

            return total;
        }

        private static List<int> GetIntegerCollectionFromNumerals(string numerals)
        {
            char[] numeralsArray = numerals.ToUpper().ToCharArray();
            List<int> integers = new List<int>();

            foreach (char num in numeralsArray)
                integers.Add(NumeralsManager.GetIntegerFromNumeral(num));

            return integers;
        }
    }
}