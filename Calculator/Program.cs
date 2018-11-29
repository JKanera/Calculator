using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zepta se to na kvadratickou rovnici ve formatu Ax^2 +- Bx +- C = 0
            //Vyparsuje A, B, C
            //Vypocita Discriminant
            //Vypocita koreny
            //Vypise vysledek
            //Zepta se na pokracovani

            Calculator calculator = new Calculator();
            calculator.ReadEquation();
            if(calculator.isEquationValid())
            {
                Console.WriteLine("Rovnice je spravne, pokracujem ...");
            } else
            {
                Console.WriteLine("Rovnice je spatne, znovu.");
            }
            calculator.calculateDiscriminant();

            calculator.calculateRoots();



            calculator.printVariables();

            Console.ReadLine();
        }
    }
}
