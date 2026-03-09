//De dos enteros, mostrar el mayor
using System;
public class Mayor
{
    public static void DeDosEnteros()
    {
        int n1, n2;
        Console.Write("Ingrese n1= ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese n2= ");
        n2 = Convert.ToInt32(Console.ReadLine());
        if (n1 >= n2)
        {
            Console.WriteLine("{0} es el mayor",n1);
        }
        else
        {
            Console.WriteLine("{0} es el mayor",n2);
        }

    }
}