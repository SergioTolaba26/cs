using System;
public class IfAnidado
{
    public static void PositivoCeroNegativo(){
        int n;
        Console.Write("Dime un numero n= ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            Console.WriteLine("Positivo");
        }
        else if(n == 0) //(0 = n)indicaria incorrecto en C# y C++ pero no se detectaria en C++ si fuera (n=0), asignacion en lugar de comparacion
        {
            Console.WriteLine("Cero");
        }
        else
        {
            Console.WriteLine("Negativo");
        }
        

    }
}