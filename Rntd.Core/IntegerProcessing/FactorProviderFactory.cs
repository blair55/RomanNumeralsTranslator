using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rntd.Core.IntegerProcessing.FactorProviders;

namespace Rntd.Core.IntegerProcessing
{
    public static class FactorProviderFactory
    {
        public static IGetFactor GetUnitsProvider()
        {
            return new GetUnitsFactor();
        }

        public static IGetFactor GetTensProvider()
        {
            return new GetTensFactor();
        }

        public static IGetFactor GetHundredsProvider()
        {
            return new GetHundredsFactor();
        }
        
        public static IGetFactor GetThousandsProvider()
        {
            return new GetThousandsFactor();
        }
    }
}
