using System;
namespace _01_Basico;
public class Dividir
{
    public static void PorCero()
    {//System.DivideByZeroException
        int a,b;
        Console.Write("Ingrese divisor: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese dividendo: ");
        b = Convert.ToInt32(Console.ReadLine());
        if(b != 0)
        {
            Console.WriteLine("Division es: {0}", a/b);
        }
        else //opcional es agregar else. Cuando hay 1 sola instruccion=> sin {}
        
            Console.WriteLine("System.DivideByZeroException, no puedo dividir por cero");
        
        Console.WriteLine("Hasta luego, fin programa");//Si comento if y else. Esto no se escribe en la consola. Programa se interrumpe de forma abrupta
        
    }
}