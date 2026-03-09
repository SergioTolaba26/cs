class C11_SwitchDia{
	public static void Semana(){
		int semana;
		Console.Write("Entry the number of the day of the week: ");
		semana = Convert.ToInt32(Console.ReadLine());
		switch (semana) {
			case 1:
				Console.WriteLine("Monday");
				break;
			case 2:
				Console.WriteLine("Tuesday");
				break;
			case 3:
				Console.WriteLine("Wednesday");
				break;
			case 4:
				Console.WriteLine("Thursday");
				break;
			case 5:
				Console.WriteLine("Friday");
				break;
			case 6:
				Console.WriteLine("Saturday");
				break;
			case 7:
				Console.WriteLine("Sunday");
				break;

		
			default:
				break;
		}
	}
}
