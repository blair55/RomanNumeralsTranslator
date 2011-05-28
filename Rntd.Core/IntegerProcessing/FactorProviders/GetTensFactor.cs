using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.Core.IntegerProcessing.FactorProviders
{
    public class GetTensFactor : IGetFactor
    {
        public int GetFactor(string[] arr)
        {
            int tens = 0;

            if (arr.Length > 1)
            {
                int index = arr.Length - 2;

                try
                {
                    tens = Convert.ToInt32(arr[index]);
                }
                catch (Exception)
                {
                    throw new Exception("Could not convert tens");
                }
            }

            return tens;
        }
    }
}
