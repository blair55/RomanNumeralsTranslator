using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.UI.Views
{
    public class OutputResultsView : IView
    {
        public string Result;

        public void Show()
        {
            Console.WriteLine("Result:      " + Result);
            Console.WriteLine(String.Empty);
        }
    }
}
