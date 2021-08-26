using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se hace creacion de objeto de tipo clase Fibonacci que me permita ejecutar los llamados a los metos
          y se haga el calculo deacurdo a los metos creados
             */
            Fibonacci objFibonacci = new Fibonacci(11);
            objFibonacci.fibonacciImprimir();            
            objFibonacci.primoImprimir();
            Console.ReadLine();
        }
    }
}
