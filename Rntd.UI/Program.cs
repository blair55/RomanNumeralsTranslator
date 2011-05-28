using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rntd.UI.Views;
using Rntd.Core.IntegerProcessing;
using Rntd.Core.NumeralProcessing;

namespace Rntd.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShowIntro();

            while (true)
            {
                try
                {
                    string input = GetInput();
                    string result = GetResult(input);
                    OutputResult(result);
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

        private static void ShowIntro()
        {
            new IntroView().Show();
        }

        private static string GetInput()
        {
            var getInputView = new GetInputView();
            getInputView.Show();
            return getInputView.Input;
        }

        private static string GetResult(string input)
        {
            int i;

            if (int.TryParse(input, out i))
                return GetNumeralsFromInteger(i);
            else
                return GetIntegerFromNumerals(input).ToString();
        }

        private static int GetIntegerFromNumerals(string numerals)
        {
            return NumeralProcessor.GetIntegerFromNumerals(numerals);
        }

        private static string GetNumeralsFromInteger(int i)
        {
            return IntegerProcessor.GetNumeralsFromInteger(i);
        }

        private static void OutputResult(string result)
        {
            var outputResultsView = new OutputResultsView();
            outputResultsView.Result = result;
            outputResultsView.Show();
        }

        private static void ShowError(string message)
        {
            var errorView = new ErrorView();
            errorView.Message = message;
            errorView.Show();
        }
    }
}