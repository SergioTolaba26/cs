using System;//Hace mas conciso el programa, mas facil de leer
namespace _01_Basico;
public class Calcular
{
    public static void Operaciones()
    {
        Console.WriteLine("Suma: " + (1234 + 56789)); //Suma: 58023         
        Console.WriteLine("Resta: " + (1234 - 56789));//Resta: -55555        
        Console.WriteLine("Multiplicación: " + (1234 * 56789)); //Multiplicación: 70077626
        Console.WriteLine("División: " + (1234 / 56789));  //División: entre enteros, da otro entero
        Console.WriteLine("División con decimales: " + (1234.0 / 56789));  //División con decimales: 0,021729560302171196
        Console.WriteLine("Módulo: " + (1234 % 56789));//Módulo: 1234
        //Video Nacho Cabanes C# 004 Ej Escribir 1290 por 3478 es y el resultado de la multiplicacion
        Console.WriteLine("EjV4->Escribo 1290 por 3478 es igual a: "+(1290*3478));//4486620    
    }
}