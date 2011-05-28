using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.Core.IntegerProcessing.FactorProviders
{
    public class GetUnitsFactor : IGetFactor
    {
        public int GetFactor(string[] arr)
        {
            try
            {
                return Convert.ToInt32(arr[arr.Length - 1]);
            }
            catch (Exception)
            {
                throw new Exception("Could not convert tens");
            }
        }
    }
}
