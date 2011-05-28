using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rntd.Core.IntegerProcessing.NumeralProviders;

namespace Rntd.Core.IntegerProcessing
{
    public static class NumeralsProviderFactory
    {
        public static GetNumerals GetUnitsProvider()
        {
            return new GetUnitsNumerals();
        }

        public static GetNumerals GetTensProvider()
        {
            return new GetTensNumerals();
        }

        public static GetNumerals GetHundredsProvider()
        {
            return new GetHundredsNumerals();
        }

        public static GetNumerals GetThousandsProvider()
        {
            return new GetThousandsNumerals();
        }
    }
}
