using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.Core.IntegerProcessing.FactorProviders
{
    public class GetHundredsFactor : IGetFactor
    {
        public int GetFactor(string[] arr)
        {
            int hundreds = 0;

            if (arr.Length > 2)
            {
                int index = arr.Length - 3;

                try
                {
                    hundreds = Convert.ToInt32(arr[index]);
                }
                catch (Exception)
                {
                    throw new Exception("Could not convert hundreds");
                }
            }

            return hundreds;
        }
    }
}
