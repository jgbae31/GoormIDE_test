using System;
using System.Collections.Generic;

namespace Sarahel{
	public static class ConstValue{
		//private static Dictionary<string, string> GameName = new Dictionary<string, string>();
		//private static Dictionary<string, string> Version = new Dictionary<string, string>();
		//private static Dictionary<string, int> Delayms = Dictionary<string, int>();
		private static Dictionary<string, int> WinSzie = Dictionary<string, int>();
		
		public static void LoadSetFile(string File){
			string Path = "/workspace/GoormIDE_test/setting/";
			
			string[] a = FileIO.ReadFile(Path+File);
			
			for(int i = 0; i < a.Length; i++) Console.WriteLine(a[i]);
		}
	}
}
