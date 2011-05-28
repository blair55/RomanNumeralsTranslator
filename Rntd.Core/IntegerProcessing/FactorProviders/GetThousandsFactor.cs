using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.Core.IntegerProcessing.FactorProviders
{
    public class GetThousandsFactor : IGetFactor
    {
        public int GetFactor(string[] arr)
        {
            int thousands = 0;
            string s = String.Join(String.Empty, arr);

            if (s.Length > 3)
            {
                string sThousands = s.Substring(0, s.Length - 3);

                try
                {
                    thousands = Convert.ToInt32(sThousands);
                }
                catch (Exception)
                {
                    throw new Exception("Could not convert thousands");
                }
            }

            return thousands;
        }
    }
}