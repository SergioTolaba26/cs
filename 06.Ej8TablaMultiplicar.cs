//Tabla multiplicar, el usuario elige Ej 5x0, ... 5x10
using System;
namespace _01_Basico;
public class Tabla
{
    public static void Multiplicar()
    {   int m;
        Console.Write("Eliga el numero entero multiplicador m = ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("La Tabla del {0} x 0 = {1} ",m,(m*0));
        Console.WriteLine("La Tabla del {0} x 1 = {1} ",m,(m*1));
        Console.WriteLine("La Tabla del {0} x 2 = {1} ",m,(m*2));
        Console.WriteLine("La Tabla del {0} x 3 = {1} ",m,(m*3));
        Console.WriteLine("La Tabla del {0} x 4 = {1} ",m,(m*4));
        Console.WriteLine("La Tabla del {0} x 5 = {1} ",m,(m*5));
        Console.WriteLine("La Tabla del {0} x 6 = {1} ",m,(m*6));
        Console.WriteLine("La Tabla del {0} x 7 = {1} ",m,(m*7));
        Console.WriteLine("La Tabla del {0} x 8 = {1} ",m,(m*8));
        Console.WriteLine("La Tabla del {0} x 9 = {1} ",m,(m*9));
        Console.WriteLine("La Tabla del {0} x 10 = {1} ",m,(m*10));
    }
}