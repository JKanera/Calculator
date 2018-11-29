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
            // equation = Console.ReadLine(); 
            equation = "3x^2 +4x -5 = 0";
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
        public double calculateDiscriminant()
        {
            //D = b^2 - 4 * a * c
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0) { Console.WriteLine("Rovnice nemá řešení");}
            if (D == 0) { Console.WriteLine("Rovnice má právě jedno řešení");}
            if (D > 0) { Console.WriteLine("Rovnice má právě tyto dvě řešení");}
            discriminant = D;
            return D;

        }
        public double[] calculateRoots()
        {
            // x1,2 = (b +- odmocnina z D) / (2 * a)

            x1 = (b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (b - Math.Sqrt(discriminant)) / (2 * a);
            double[] roots = new double[2];
            roots[0] = x1;
            roots[1] = x2;
            return roots;

        } 
    






        public void printVariables()
        {
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine("D: " + discriminant);
            Console.WriteLine("Roots:" + x1);
            Console.WriteLine("Roots:" + x2);








        }
    }

}
