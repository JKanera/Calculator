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
            while (true) {
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
            double[] Roots = calculator.calculateRoots();
            double[] SortedRoots = new double[2];
            if (Roots[0] < Roots[1])
            {
                SortedRoots[0] = Roots[0];
                SortedRoots[1] = Roots[1];
                
                
            }
            else
            {
                SortedRoots[0] = Roots[1];
                SortedRoots[1] = Roots[0];


            }

            
            string Result = ("Kořen x1 je " + SortedRoots[0] + "\tKořen x2 je " + SortedRoots[1]);
            string FormatedResult = String.Format("Kořen x1 je {0:0.000} \tKořen x2 je {1:0.000}", SortedRoots[0], SortedRoots[1] );
            Console.WriteLine(FormatedResult);

            Console.WriteLine("Chcete pokračovat? A/N");
            String Continue = Console.ReadLine();
            if (Continue == "A") {
                    Console.WriteLine("Uživatel chce pokračovat");
                }
            else {
                 Console.WriteLine("Uživatel nechce pokračovat");
                 break;
                }
                

             }
           









            
        }
    }
}
