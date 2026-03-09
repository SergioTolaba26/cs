
/*Programa que pida al usuario dos numeros 
Resultado (A+B). (A-B) y Resultado A²-B²
*/
namespace _01_Basico;
public class Operaciones
{
    public static void Varias()
    {
        int A, B;
        Console.Write("Dame un numero entero A: ");
        A= Convert.ToInt32(Console.ReadLine());
        Console.Write("Dame un numero entero B: ");
        B= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Resultado1= "+(A+B)*(A-B) );
        Console.WriteLine("Resultado2= "+((A*A)-(B*B)));
    }
}