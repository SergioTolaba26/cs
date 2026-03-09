using System;

namespace _01_Basico;
public class EnteroMayor
{
    public static void DeTres()
    {
       int n1,n2,n3;
        Console.Write("Dime un numero n1= ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dime un numero n2= ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dime un numero n3= ");
        n3 = Convert.ToInt32(Console.ReadLine());
        if ((n1>=n2) && (n1 >= n3))
        {
            Console.WriteLine("{0} es el Mayor",n1);
        }
        else if ((n2 >= n1) && (n2 >= n3))
        {
            Console.WriteLine("{0} es el Mayor",n2);
        }
        else
        {
            Console.WriteLine("{0} es el Mayor",n3);
        }
    }
}
