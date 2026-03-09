//Prioridad o Jerarquia de las operaciones matematicas *,/,% > +,-
using System;

public class Prioridad
{
    public static void Desborde()
    {
        int a = 1000000;
        int b = 5000000;
        int c = a * b;//excede la capacidad o hay desbordamiento en Csharp

        Console.Write("1er resuelve * y luego + y lo hace de izq a dcha : "+(2+3*5));//17
        Console.WriteLine();
        Console.WriteLine(c);//658067456 dato extraño, limitaciones de C#
    }
}