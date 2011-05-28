using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.Core.IntegerProcessing.NumeralProviders
{
    public abstract class GetNumerals
    {
        protected string Numerals = String.Empty;

        protected abstract int Factor { get; }

        public abstract string GetNumeralsFromCount(int count);

        protected static char GetNumeralFromInteger(int i)
        {
            return NumeralsManager.GetNumeralFromInteger(i);
        }

        protected string GetAdjustedNumerals(int count)
        {
            if (count > 9)
                throw new Exception("Invalid Count");
            else if (count == 9)
            {
                Numerals += GetNumeralFromInteger(this.Factor);
                Numerals += GetNumeralFromInteger(this.Factor * 10);
            }
            else if (count > 4)
            {
                Numerals += GetNumeralFromInteger(this.Factor * 5);

                int hundredsToAdd = count - 5;

                for (int h = 0; h < hundredsToAdd; h++)
                    Numerals += GetNumeralFromInteger(this.Factor);
            }
            else if (count == 4)
            {
                Numerals += GetNumeralFromInteger(this.Factor);
                Numerals += GetNumeralFromInteger(this.Factor * 5);
            }
            else
            {
                for (int h = 0; h < count; h++)
                    Numerals += GetNumeralFromInteger(this.Factor);
            }

            return Numerals;
        }
    }
}