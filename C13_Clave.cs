//Se le pide al usuario la clave de acceso o contrasenia, 1234
//se repite hasta que ponga bien la clave entonces dice Bienvenido

public class C13_Clave
{
	public static void Bienvenido() 
	{
		var clave=0;
		while (clave != 1234)
		{
			Console.Write("Ingresa los enteros de la clave(1,2...): ");
			clave = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Bienvenido");
	}

}
