using System;

class Program{
	static void Main(){
		Random a = new Random();

		for(int i = 0; i < 100; i++) Console.WriteLine(a.Next(5));
	}
}
