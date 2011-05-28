using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.Core
{
    public static class NumeralsManager
    {
        private static Dictionary<char, int> Numerals = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        public static int GetIntegerFromNumeral(char num)
        {
            try
            {
                return Numerals[num];
            }
            catch(Exception)
            {
                throw new Exception("Numeral not found");
            }
        }

        public static char GetNumeralFromInteger(int i)
        {
            return Numerals.Where(n => n.Value == i).FirstOrDefault().Key;
        }
    }
}