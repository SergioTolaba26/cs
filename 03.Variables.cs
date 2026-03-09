using System;
namespace _01_Basico;

public class Variables{
    public static void InputUsuario()
    {   int num1, num2;//declaro las variables
        Console.Write("Dame el primer numero: ");//Mensaje
        num1 = Convert.ToInt32(Console.ReadLine());//Lee dato del usuario que es string=>Convert.ToInt32 | Guardo el dato
        Console.Write("Dame el segundo numero: "); //Leo 
        num2 = Convert.ToInt32(Console.ReadLine());//Guardo, uso
        Console.Write("La division de {0} y {1} es igual a: {2}",
        num1,num2,((double)num1/num2));
        //Console.WriteLine((double)num1 / num2);//hago la suma y la muestro
        
    }
}