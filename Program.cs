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

string data = metodo1.CURPFecha(curp).Insert(4, "/").Insert(2, "/");



if (curp.Length == 18)
{
    DateOnly fecha = DateOnly.ParseExact(data, "yy/MM/dd", CultureInfo.InvariantCulture);
    if (metodo1.CURPSexo(curp) == "M")
    {
        Console.WriteLine($"Usted es de sexo femenino y su fecha de nacimiento es: {fecha}");
    }
    else Console.WriteLine($"Usted es de sexo masculino y su fecha de nacimiento es: {fecha}");

}
else Console.WriteLine("La curp debe ser de 18 caracteres");

Console.WriteLine("\nEjercicio 3: ");
Console.WriteLine("Ingresa que tabla quieres saber: ");
int num1 = Convert.ToInt32(Console.ReadLine());


metodo1.TablaDeMultiplicar(num1, 0);


