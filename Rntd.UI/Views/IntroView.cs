using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.UI.Views
{
    public class IntroView : IView
    {
        public void Show()
        {
            Console.WriteLine("ROMAN NUMERALS TRANSLATOR");
            Console.WriteLine("Enter either roman numerals or an integer to get the translated value");
            Console.WriteLine();
        }
    }
}
