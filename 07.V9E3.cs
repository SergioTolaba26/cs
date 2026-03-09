/*Conversor Temperatura de °C a K y °F  (Alt+0176=°)
K = °C + 273
°F= °C * 18/10+32
*/
using System;
public class V9E3
{  
    public static void ConvertirTemp(){
        int temp = 0;//Otra forma 3 Variables Ej c,k,f
        Console.Write("Ingrese Temperatura °C: ");
        temp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("La Temperatura de {0}°C son {1} Kelvin y {2} °F ",
         temp,temp+273,temp* 18/10+32);
        

    }
}