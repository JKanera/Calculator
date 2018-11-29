using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        private int a, b, c;
        private double discriminant;
        private double x1, x2;
        private string equation;

        public void ReadEquation()
        {
            Console.WriteLine("Zapis rovnici ve formatu Ax^2 +- Bx +- C = 0");
            equation = Console.ReadLine();
            Console.WriteLine("Rovnice je: " + equation);
        }

        public bool isEquationValid()
        {
            string[] parsedEquation = equation.Split(' ');
            bool cparsed = false;
            for (int i = 0; i < parsedEquation.Length; i++)
            {
                String parsedEquationPart = parsedEquation[i];
                if(parsedEquationPart.Contains("x^2")) {
                    string textA = parsedEquationPart.Replace("x^2", "");
                    a = int.Parse(textA);
                }

                if(parsedEquationPart.Contains("x") && !parsedEquationPart.Contains("^2"))
                {
                    string textB = parsedEquationPart.Replace("x", "");
                    b = int.Parse(textB);
                }

                if(!(i == parsedEquation.Length - 1) && !cparsed) { 
                    bool succeed = Int32.TryParse(parsedEquationPart, out c);
                    if(succeed)
                    {
                        cparsed = true;
                    }
                }
            }

            if(a != 0 && b != 0 && c != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void printVariables()
        {
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
        }
    }

}
