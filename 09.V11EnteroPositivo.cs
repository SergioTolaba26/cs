using System;
public class Entero
{
    public static void main()
    {
        int n;
        Console.Write("Dime un numero n= ");
        n = Convert.ToInt32(Console.ReadLine());
        if ((n > 0) || (n==0))//Co solo 1true=>ok if
        //if (!(n<0)) esto invierte el ser negativo a ser "positivo o ser cero"
        {
            Console.WriteLine("{0} es positivo o cero",n);
        }
        else //Ocurre si las dos condiciones son falsas
        {
            Console.WriteLine("{0} es negativo",n);
        }
    }
}
