using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.Core.IntegerProcessing
{
    public static class IntegerProcessor
    {
        public static string GetNumeralsFromInteger(int i)
        {
            string[] arr = i.ToString().ToCharArray().Select(s => s.ToString()).ToArray();
            string numerals = String.Empty;

            ProcessThousands(arr, ref numerals);
            ProcessHundreds(arr, ref numerals);
            ProcessTens(arr, ref numerals);
            ProcessUnits(arr, ref numerals);
            
            return numerals;
        }

        private static void ProcessThousands(string[] arr, ref string numerals)
        {
            int thousandsCount = FactorProviderFactory.GetThousandsProvider().GetFactor(arr);
            numerals += NumeralsProviderFactory.GetThousandsProvider().GetNumeralsFromCount(thousandsCount);
        }

        private static void ProcessHundreds(string[] arr, ref string numerals)
        {
            int hundredsCount = FactorProviderFactory.GetHundredsProvider().GetFactor(arr);
            numerals += NumeralsProviderFactory.GetHundredsProvider().GetNumeralsFromCount(hundredsCount);
        }

        private static void ProcessTens(string[] arr, ref string numerals)
        {
            int tensCount = FactorProviderFactory.GetTensProvider().GetFactor(arr);
            numerals += NumeralsProviderFactory.GetTensProvider().GetNumeralsFromCount(tensCount);
        }

        private static void ProcessUnits(string[] arr, ref string numerals)
        {
            int unitsCount = FactorProviderFactory.GetUnitsProvider().GetFactor(arr);
            numerals += NumeralsProviderFactory.GetUnitsProvider().GetNumeralsFromCount(unitsCount);
        }
    }
}