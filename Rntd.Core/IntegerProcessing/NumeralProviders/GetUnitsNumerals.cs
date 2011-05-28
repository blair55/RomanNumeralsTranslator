using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.Core.IntegerProcessing.NumeralProviders
{
    public class GetUnitsNumerals : GetNumerals
    {
        protected override int Factor
        {
            get { return 1; }
        }

        public override string GetNumeralsFromCount(int count)
        {
            return base.GetAdjustedNumerals(count);
        }
    }
}