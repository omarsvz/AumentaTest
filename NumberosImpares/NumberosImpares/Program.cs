using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numerosImpares = new List<int>();
            numerosImpares = ObtenerImpares(1, 10);
            /* Los casos de uso serian cambiando los valores que se le envian a la funcion de ObtenerImpares
             * numerosImpares = ObtenerImpares(1, 10); Para comprobarlos impares del 1 al 10
             * numerosImpares = ObtenerImpares(10, 1); para comprobar que el primer parametro puede ser mayor que el primero
             * numerosImpares = ObtenerImpares(-10, 1); que acepta negativos
             * numerosImpares = ObtenerImpares(-10, 10); en este caso imprime negativos y positivos
             * numerosImpares = ObtenerImpares(1, 3); cuando en el rango no hay impares
             * numerosImpares = ObtenerImpares(3, 3); o cuando no hay un rango que evaluar porque son el mismo numero
             * numerosImpares = ObtenerImpares(-3, -3); lo mismo pero cuando es negativo
             * numerosImpares = ObtenerImpares(-3, 0); cuando se pasa el 0 como parametro
             * 
             * Nota: hice la funcion teniendo en cuenta que solo mostrara los impares dentro del rango
             * por ejemplo si es del 1 al 9 no muestra el 1 y el 9 como parte de los impares, solo los numeros
             * dentro del rango: (3,5,7), si se deseara que tambien se mostraran el inicio y fin del rango (1,3,5,7,9)
             * solo se necesita borrar el else que contiene la instruccion inicio +=2; y en el ciclo for del recorrido hacer
             * que en lugar de i < fin que sea i <= fin.
            */

            if (numerosImpares.Count > 0)
            {
                foreach (int item in numerosImpares)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("No hay numeros primos en ese rango de numeros");

            Console.ReadKey();
        }

        public static List<int> ObtenerImpares(int a, int b)
        {
            List<int> listaImpares = new List<int>();
            
            int inicio, fin;
            if (a <= b)
            {
                inicio = a;
                fin = b;
            }
            else
            {
                inicio = b;
                fin = a;
            }

            if (inicio % 2 == 0)
            {
                inicio++;
            }
            else
            {
                inicio += 2;
            }

            for (int i = inicio; i < fin; i+=2)
            {
                listaImpares.Add(i);
            }

            return listaImpares;
        }
    }
}
