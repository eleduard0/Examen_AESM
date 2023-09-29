using Examen_AESM;
using System.Globalization;

Console.WriteLine("Ejercicio 1:");
Metodos metodo1 = new Metodos();
Console.WriteLine("Ingrese 2 numeros");
int inicio = Convert.ToInt32(Console.ReadLine());
int fin = Convert.ToInt32(Console.ReadLine());

metodo1.IntervaloDeNumeros(inicio, fin);

Console.WriteLine("\nEjercicio 2: ");
Console.WriteLine("Ingresa tu curp");
string curp = Console.ReadLine();
metodo1.CURP(curp);

Console.WriteLine("\nEjercicio 3: ");
Console.WriteLine("Ingresa que tabla quieres saber: ");
int num1 = Convert.ToInt32(Console.ReadLine());


metodo1.TablaDeMultiplicar(num1, 0);


