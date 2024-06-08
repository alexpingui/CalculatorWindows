using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Solver
    {
        public static double GetSolution(string input) 
        {
            return Solve(ConvertToPostfix(input));
        }

        public static string ConvertToPostfix(string input)
        {
            string output = String.Empty;

            Stack<char> opers = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == ',')
                {
                    while (Char.IsDigit(input[i]) || input[i] == ',')
                    {
                        output += input[i];
                        i++;
                        
                        if (i == input.Length) break;
                    }
                    output += " ";
                    i--;
                }

                else
                {
                    if (opers.Count > 0)
                        if (GetPriority(input[i]) <= GetPriority(opers.Peek()))
                            output += opers.Pop() + " ";

                    opers.Push(input[i]);
                }
            }

            while (opers.Count > 0)
                output += opers.Pop() + " ";

            return output;
        }

        private static double Solve(string input)
        {
            Stack<double> operands = new Stack<double>();
            double result = 0;
            
            for(int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) || input[i] == ',')
                {
                    string a = string.Empty;
                    while (Char.IsDigit(input[i]) || input[i] == ',')
                    {
                        a += input[i];
                        i++;
                        if (i == input.Length) break;
                    }
                    operands.Push(double.Parse(a));
                    i--;
                }

                else if (input[i] != ' ' && operands.Count > 1)
                {
                    double a = operands.Pop();
                    double b = operands.Pop();

                    switch (input[i])
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/': result = b / a; break;
                        case '^': result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;
                    }
                    operands.Push(result);
                }
            }
            if (operands.Count > 0)
                return operands.Pop();

            else return 0;
        }
        static private bool IsOperator(char сh)
        {
            if (("+-/*^".IndexOf(сh) != -1))
                return true;
            return false;
        }

        static private byte GetPriority(char ch)
        {
            switch (ch)
            {
                case '+': return 1;
                case '-': return 1;
                case '*': return 2;
                case '/': return 2;
                case '^': return 3;
                default: return 4;
            }
        }
    }
}
