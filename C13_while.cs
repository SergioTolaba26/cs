class C13_while{
	public static void DividirPorCero() {
		int a,b;
		Console.Write("Ingrese un entero a=");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Ingrese un entero b=");
		b = Convert.ToInt32(Console.ReadLine());
		
		while (b ==0){
			Console.WriteLine("No se puede dividir por cero");
			Console.Write("Ingrese un entero b=");
			b = Convert.ToInt32(Console.ReadLine());
			
			}
		Console.WriteLine("La Division de {0}/{1} es: {2}",a,b,(a/b));
		
		
	}
}
