//Ciclo que inicia en do => pasa al codigo una vez aunque no se cumpla la condicion
//while (condicion)
//Volvemos a la Division PorCero
public class C14_do_while
{
	public static void DividirPorCero()
	{
		int a,b;
		Console.Write("Ingrese el divisor a: ");
		a = Convert.ToInt32(Console.ReadLine());
		
		do
		{
			Console.Write("Ingrese el divisor b: ");
			b = Convert.ToInt32(Console.ReadLine());
			if (b == 0)
			{
				Console.WriteLine("No puedo dividir por cero");
			}
		}
		while (b==0);
		

		
			Console.WriteLine("La division da: {0}", a/b);
	}

}
