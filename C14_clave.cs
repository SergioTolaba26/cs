class C14_clave
{
	public static void DividirPorCero()
	{
		int clave =0;

		
		do
		{
		Console.Write("Ingrese enteros de su clave (1,2...): ");
		clave = Convert.ToInt32(Console.ReadLine());
		}
		while (clave != 1234);
		{
			
		}
		Console.WriteLine("Bienvenido");
	}
	
}
