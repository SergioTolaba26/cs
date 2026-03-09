class C12_CantidadPositivos {
	public static void DosEntero() {
		Console.Write("Ingresa un entero num1: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Ingresa un entero num2: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		int cantidadDePositivos = 0;

		if (num1 > 0)
			cantidadDePositivos++;
		if (num2 > 0)
			cantidadDePositivos++;


		Console.WriteLine("Cuantos entero positivos ha ingresado? {0}", cantidadDePositivos);	

//Operador ternario
cantidadDePositivos = (num1 > 0? 1:0)+(num2 >0? 1:0);
		
		Console.WriteLine("Ternario Cuantos entero positivos ha ingresado? {0}", cantidadDePositivos);	
		
		
	}
	}
