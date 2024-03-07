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
        static List<float> numbers = new List<float>();

        public static bool Calculate(string calculation, out float result)
        {
            bool validCalculation = true;
            if(string.IsNullOrEmpty(calculation)) {
                validCalculation = false;
            }
            if (validCalculation && !char.IsDigit(calculation[0]) && calculation[0] != '-') {
                validCalculation = false;
            }
            if (validCalculation && !char.IsDigit(calculation.Last())) { 
                validCalculation = false; 
            }

            if(validCalculation)
            {
                remainingCharacters = calculation;
                ExtractCalculationsToArrays(ref validCalculation);
                
            }

            if (validCalculation)
            {
                ResolveOperations("*/");
                ResolveOperations("+-");
                result = numbers[0];
                return true;
            }
            else
            {
                result = 0;
                return false;
            }

            
        }

        private static void ResolveOperations(string operationsToCalculate)
        {
            int operationPositionOnList = 0;
            while(operationPositionOnList < operations.Count)
            {
                Char character = operations[operationPositionOnList];
                if (operationsToCalculate.Contains(character))
                {
                    float result = MakeOperation(operationPositionOnList, character);
                }
                else
                {
                    operationPositionOnList++;
                }
            }
        }

        private static float MakeOperation(int index, char character)
        {
            float result = 0;
            switch (character)
            {
                case '*':
                    result = numbers[index] * numbers[index + 1];
                    break;
                case '/':
                    result = numbers[index] / numbers[index + 1];
                    break;
                case '-':
                    result = numbers[index] - numbers[index + 1];
                    break;
                case '+':
                    result = numbers[index] + numbers[index + 1];
                    break;
                default:
                    Trace.TraceError($"{character} is not implemented");
                    break;
            }
            numbers[index] = result;
            numbers.RemoveAt(index + 1);
            operations.RemoveAt(index);
            return result;
        }

        private static void ExtractCalculationsToArrays(ref bool validCalculation)
        {
            numbers.Clear();
            operations.Clear();
            float number = 0;
            char operation = ' ';
            bool foundValidNumber = true;
            while (foundValidNumber)
            {
                try
                {
                    foundValidNumber = NextPartIsNumber(ref number);
                }
                catch (Exception)
                {
                    //next part was numberlike, but could not be parsed
                    foundValidNumber = false;
                    validCalculation = false;
                }                
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
                        //two operations on row
                        validCalculation = false;
                    }
                }
            }
        }

        private static bool NextPartIsNumber(ref float number)
        {
            int nextPartLength = 0;
            bool onlyValidNumbersFound = true; 

            if(remainingCharacters.Length != 0 && remainingCharacters[0] == '-') {
                    nextPartLength++;
            }           
            while (onlyValidNumbersFound && nextPartLength < remainingCharacters.Length)
            {
                char character = remainingCharacters[nextPartLength];
                if (char.IsDigit(character) || character == '.' || character == ',')
                {
                    nextPartLength++;
                }
                else
                {
                    onlyValidNumbersFound = false;
                }
            }
            if (nextPartLength > 0)
            {
                number = float.Parse(remainingCharacters.Substring(0, nextPartLength));
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
