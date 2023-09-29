using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_AESM
{
    public class Metodos
    {
        public void IntervaloDeNumeros(int inicio , int final)
        {
            if (inicio < final)
            {
                for (int i = inicio; i <= final; i++)
                {
                    Console.WriteLine($"La secuencia de números es {i}");

                }
            }

            else if (inicio > final)
            {
                for ( int i = inicio; i >= final; i--)
                {
                    Console.WriteLine($"La secuencia de números es {i}");
                }

            }        

           
            else Console.WriteLine("Los números son iguales");
        }

        public void TablaDeMultiplicar(int num1 , int num2 )
        {
            if (num2 <= 10)
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                TablaDeMultiplicar(num1, num2 + 1);

            }

        }

        public string CURPFecha(string curp)
        {
            int longitud = curp.Length;
            int numeros = longitud / 2;

            return curp.Substring(numeros-5,6);

        }
        public string CURPSexo(string curp)
        {
            int longitud = curp.Length;
            int numeros = longitud / 2;

            return curp.Substring(numeros +1,1);
        }

     

    }


}
