using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNet
{
    class Fibonacci
    {
        private int calcularNumero;
        private int resultadoNumero;

        public Fibonacci(int calcular)
        {
            this.calcularNumero = calcular;
        }

        /**
         * Creacion de los metodos Getters and Setters
         * @return the calcularNumero
         */
        public int getCalcularNumero()
        {
            return calcularNumero;
        }

        /**
         * @param calcularNumero the calcularNumero to set
         */
        public void setCalcularNumero(int calcularNumero)
        {
            this.calcularNumero = calcularNumero;
        }

        /**
         * @return the resultadoNumero
         */
        public int getResultadoNumero()
        {
            return resultadoNumero;
        }

        /**
         * @param resultadoNumero the resultadoNumero to set
         */
        public void setResultadoNumero(int resultadoNumero)
        {
            this.resultadoNumero = resultadoNumero;
        }

        /**
         * Este Metodo permitira imprimir la serie de los numeros segun el calculo Fibonacci del numero ingresado
         */

        public void fibonacciImprimir()
        {
            Console.WriteLine("................******................");
            Console.WriteLine("Segun el calculo Fibonacci del numero: " + this.calcularNumero + "\n" + "el resultado es:");
            for (int f = 0; f <= this.calcularNumero; f++)
            {
                Console.Write(this.fibonacciCalculado(f) + " - ");
                this.resultadoNumero = this.fibonacciCalculado(f);
            }
            Console.WriteLine();
            Console.WriteLine("................******................");
        }

        /**
         * Metodo para mostrar en pantalla el resultado de la serie fibonacci e indicar si es primo o no.
         */

        public void primoImprimir()
        {
            if (this.primo(this.resultadoNumero))
            {
                Console.WriteLine("El número: " + this.resultadoNumero + " Es primo");
            }
            else
            {
                Console.WriteLine("El número: " + this.resultadoNumero + " No es primo");
            }
        }

        /**
         * Metodo creado para evaluar las condiciones que identifiquen segun
         * el numero indicado si este es primo o no
         * @param numero
         * @return 
         */

        private bool primo(int numero)
        {
            int cuenta = 0;
            bool primo = false;
            for (int p = 1; p <= numero; p++)
            {
                if (numero % p == 0)
                {
                    cuenta += 1;
                }
            }
            if (cuenta == 2)
            {
                primo = true;
            }
            return primo;
        }

        /**
         * Metodo creado para evaluar las condiciones segun el numero ingresado
         * y generar la sumatoria recursiva y grabe dichos valoress
         * para mostrarlos en la serie impresa
         * @param resultado
         * @return 
         */

        private int fibonacciCalculado(int resultado)
        {
            if (resultado == 0)
            {
                return 0;
            }
            else if (resultado == 1)
            {
                return 1;
            }
            else
            {
                return this.fibonacciCalculado(resultado - 1) + this.fibonacciCalculado(resultado - 2);
            }
        }

    }


}
