using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	public static class ScriptPlay{
		public static void Center(string[] Str, int Y){
			Print Prt = new Print();
			
			ConsoleKeyInfo a = default(ConsoleKeyInfo);
			
			for(int i = 0; i < Str.Length; i++){
				if(Str[i] == "#enter#"){
					a = Console.ReadKey(true);
				}
				else if(Str[i] == "#delay#"){
					Thread.Sleep(ConstValue.Delayms);
				}
				else{
					Prt.DelayCenter(Str[i], Y+i);
				}
			}
		}
	}
}