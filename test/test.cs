using System;
using System.IO;

class test{
	
	public static void Main(){
		string[] a = File.ReadAllLines("/workspace/GoormIDE_test/test/test");
		
		
		Console.Clear();
		
		for(int i = 0; i < a.Length; i++){
			Console.WriteLine(a[i]);
		}
		
	}
}