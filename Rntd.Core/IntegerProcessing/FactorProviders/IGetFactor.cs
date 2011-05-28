using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.Core.IntegerProcessing.FactorProviders
{
    public interface IGetFactor
    {
        int GetFactor(string[] arr);
    }
}
