using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rntd.UI.Views
{
    public class GetInputView : IView
    {
        private string _input = String.Empty;

        public string Input
        {
            get { return _input; }
        }

        public void Show()
        {
            Console.Write("Enter Value: ");
            _input = Console.ReadLine();
        }
    }
}