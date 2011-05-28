using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.UI.Views
{
    public class ErrorView : IView
    {
        public string Message;

        public void Show()
        {
            Console.WriteLine("Error:       " + this.Message);
            Console.WriteLine();
        }
    }
}
