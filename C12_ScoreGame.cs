class C12_ScoreGame{
	public static void Level() {
		int score, level;
		
		Console.Write("Tell me your level number: ");
		level = Convert.ToInt32(Console.ReadLine());
/*
		if (level == 1)
			score = 10;
		else
			score = 20;


*/
//Operador ternario, es un if else abreviado y tambien puedo anidar
        score = level ==1? 10 : (level ==2? 20 : 30);
		
		Console.WriteLine("Score: {0}",score);
		
	}
	}
