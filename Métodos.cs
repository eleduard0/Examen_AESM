using System;
using System.Collections.Generic;
using System.Globalization;
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

        public void CURP(string curp)
        {
            if(curp.Length == 18)
            {
                int longitud = curp.Length;
                int numeros = longitud / 2;

                string fn = curp.Substring(numeros-5,6);
                string sexo = curp.Substring(numeros + 1, 1);

                string data = fn.Insert(4, "/").Insert(2, "/");
                DateOnly fecha = DateOnly.ParseExact(data, "yy/MM/dd", CultureInfo.InvariantCulture);
                if (sexo == "M")
                {
                    Console.WriteLine($"Usted es de sexo femenino y su fecha de nacimiento es: {fecha}");
                }
                else Console.WriteLine($"Usted es de sexo masculino y su fecha de nacimiento es: {fecha}");

            }
            else Console.WriteLine("La curp debe ser de 18 caracteres");



        }
        /*public string CURPSexo(string curp)
        {
            int longitud = curp.Length;
            int numeros = longitud / 2;

            return curp.Substring(numeros +1,1);
        }*/

     

    }


}
