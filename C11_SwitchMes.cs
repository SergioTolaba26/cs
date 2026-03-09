//No sirve switch para > que o un rango como en if..else
//Switch solo valores concretos y enteros Ej case 1 :....
class C11_SwitchMes{
	public static void QueMes(){
		int mes;
		Console.Write("Dime el numero de un mes: ");
		mes = Convert.ToInt32(Console.ReadLine());
		switch(mes){
			case 1 :
				Console.WriteLine("Quizas sea Enero...");
				goto case 2;//Pongo 1, go to case 2 
				
			case 2 :
				Console.WriteLine("Enero o Febrero");
				break;
			case 3 :
				Console.WriteLine("Marzo");
				break;
				
			default ://No es obligatorio pero si pongo defaul, lleva break;
				Console.Write("Mes invalido");
			    break;
			    
		}	    
	}
}
