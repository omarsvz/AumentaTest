using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecarArray
{
    class Program
    {
        static void Main(string[] args)
        {
            long longNumber = 1000000;
            object[] arrayTest = { "10", "10", "test", 10.2, -1, longNumber };
            /*Para validar los casos de  prueba seria cambiando los diferentes tipos de datos que tenga el array
             * object[] arrayTest = { "10" }; el resultado es: no esta, ya que es un tipo string
             * object[] arrayTest = { "10", 10 }; el resultado es: si esta, ya que si existe el tipo int
             * object[] arrayTest = { "10", 10.2, "test"}; el resultado es: no esta, ya que los datos son string y double
             * object[] arrayTest = { "10", -1 }; el resultado es: si esta, ya que los numeros negativos siguen siendo int
             * object[] arrayTest = { "test", longNumber }; el resultado es: no esta, nota: si se quiere que tambien se valide el
             * tipo de dato long como valido seria cambiar en el ciclo la instruccion typeof(Int32) por typeof(int)
            */
            string resultado = "NO ESTA";
            for (int i = 0; i < arrayTest.Length; i++)
            {
                if (arrayTest[i].GetType() == typeof(Int32))
                {
                    resultado = "SI ESTA";
                    i = arrayTest.Length;
                }
            }
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
