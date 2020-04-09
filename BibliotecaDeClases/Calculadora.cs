using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Calculadora
    {
        /// <summary>
        /// Convierte a entero y suma ambos parametros
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns>Devuelve la suma</returns>
        public static int Sumar(string input1, string input2)
        {
            int num1;

            //OTRAS FORMAS DE CONVERTIR STRING A ENTERO
            //int num1 = int.Parse(input1);
            //int num1 = Convert.ToInt32(input1);
            if (!int.TryParse(input1, out num1))
            {
                Console.WriteLine("El valor ingresado no es un numero");
                Console.ReadKey();
            }

            int num2;

            if (!int.TryParse(input2, out num2))
            {
                Console.WriteLine("El valor ingresado no es un numero");
                Console.ReadKey();
            }

            int resultado = num1 + num2;

            return resultado;
        }
    }
}
