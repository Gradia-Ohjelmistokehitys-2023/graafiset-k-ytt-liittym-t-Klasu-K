using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CalculatorApp.Backend
{
    static internal class Calculator
    {
        static string remainingCharacters;
        static List<char> operations = new List<char>();
        static List<int> numbers = new List<int>();

        public static bool Calculate(string calculation)
        {
            bool validCalculation = !string.IsNullOrEmpty(calculation);
            if (validCalculation && (!char.IsDigit(calculation[0]) || !char.IsDigit(calculation.Last())))
            {
                validCalculation = false;
            }

            if(validCalculation)
            {
                remainingCharacters = calculation;
                //if only for testing
                ExtractCalculationsToArrays(ref validCalculation);
                
            }

            if (validCalculation)
            {
                calculateData();
                numbers.ForEach(number => { Debug.WriteLine(number); });
                operations.ForEach(operation => { Debug.WriteLine(operation); });
                Debug.WriteLine("------------------------");
                return true;
            }
            else
            {
                return false;
            }

            
        }

        private static bool calculateData()
        {
            operations.Reverse();
            numbers.Reverse();

            for(int i = operations.Count -1; i >= 0; i--)
            {
                Char character = operations[i];
                if (character == '*')
                {
                    int result = numbers[i+1] * numbers[i];
                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                }
                if (character == '/')
                {
                    int result = numbers[i+1] / numbers[i];
                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                }
            }
            for (int i = operations.Count - 1; i >= 0; i--)
            {
                Char character = operations[i];
                if (character == '+')
                {
                    int result = numbers[i + 1] + numbers[i];
                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                }
                if (character == '-')
                {
                    int result = numbers[i + 1] - numbers[i];
                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                }
            }
            operations.Reverse();
            numbers.Reverse();

            return false;
        }

        private static void ExtractCalculationsToArrays(ref bool validCalculation)
        {
            numbers.Clear();
            operations.Clear();
            int number = 0;
            char operation = ' ';
            bool foundValidNumber = true;
            while (foundValidNumber)
            {
                foundValidNumber = NextPartIsNumber(ref number);
                if (foundValidNumber)
                {
                    numbers.Add(number);
                    int numberLength = number.ToString().Length;
                    remainingCharacters = remainingCharacters.Substring(numberLength);
                }
                bool foundValidOperation = NextCharIsOperation(ref operation);
                if (foundValidOperation)
                {
                    if (foundValidNumber)
                    {
                        operations.Add(operation);
                        remainingCharacters = remainingCharacters.Substring(1);
                    }
                    else
                    {
                        validCalculation = false;
                    }
                }
            }
        }

        private static bool NextPartIsNumber(ref int number)
        {
            int numberAmount = 0;
            bool onlyValidNumbersFound = true;
            while (onlyValidNumbersFound && numberAmount < remainingCharacters.Length)
            {
                
                if (char.IsDigit(remainingCharacters, numberAmount))
                {
                    numberAmount++;
                }
                else
                {
                    onlyValidNumbersFound = false;
                }
            }
            if (numberAmount > 0)
            {
                number = int.Parse(remainingCharacters.Substring(0, numberAmount));
                return true;
            }
            else
            {
                number = 0;
                return false;
            }  
        }

        private static bool NextCharIsOperation(ref char operation)
        {
            if(remainingCharacters.Length == 0) { return false; }
            if (!Char.IsDigit(remainingCharacters[0]))
            {
                operation = remainingCharacters[0];
                return true;
            } else
            {
                return false;
            }
        }

    }
}
