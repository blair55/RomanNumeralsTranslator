using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.Core.IntegerProcessing.NumeralProviders
{
    public class GetThousandsNumerals : GetNumerals
    {
        protected override int Factor
        {
            get { return 1000; }
        }

        public override string GetNumeralsFromCount(int count)
        {
            for (int t = 0; t < count; t++)
                base.Numerals += GetNumeralFromInteger(this.Factor);

            return base.Numerals;
        }
    }
}