using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero:");
            string input1 = Console.ReadLine();
            
            Console.WriteLine("Ingrese el segundo numero:");
            string input2 = Console.ReadLine();
            
            int resultado = Calculadora.Sumar(input1, input2);
            Console.WriteLine("La suma da: " + resultado);
            

            //OTRAS FORMAS DE CONCATENAR STRINGS
            //Console.WriteLine(string.Concat("string.Concat: ", resultado, " ", "param2", " ", "param3"));

            //string.Format("La suma da: primero {0} el segundo {1}, ambos {0}-{1}", "PRIMERO", "SEGUNDO");

            //Console.WriteLine("string.Format: imagen-{0}.png", DateTime.Now.ToString());

            //Console.WriteLine($"INTERPOLATION: la suma da {resultado}");

            Console.ReadKey();
        }

    }
}
