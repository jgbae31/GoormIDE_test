using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	public static class ScriptPlay{
		public static void Center(string[] Str, int X1, int X2, int Y){
			Print Prt = new Print();
			
			ConsoleKeyInfo a = default(ConsoleKeyInfo);
			
			for(int i = 0; i < Str.Length; i++){
				if(Str[i] == "#enter#"){
					Prt.Right("<-", 2, 48);
					a = Console.ReadKey(true);
					a = default(ConsoleKeyInfo);
				}
				else if(Str[i] == "#ChangeLine#"){
					Prt.Right("   ", 2, 48);
					Y -= 1;
				}
				else if(Str[i] == "#delay#"){
					Prt.Right("   ", 2, 48);
					Thread.Sleep(ConstValue.Delayms);
				}
				else if(Str[i] == "#delay10#"){
					Prt.Right("   ", 2, 48);
					Thread.Sleep(ConstValue.Delayms * 10);
				}
				else if(Str[i] == "#delay25#"){
					Prt.Right("   ", 2, 48);
					Thread.Sleep(ConstValue.Delayms * 25);
				}
				else if(Str[i] == "#delay50#"){
					Prt.Right("   ", 2, 48);
					Thread.Sleep(ConstValue.Delayms * 50);
				}
				else if(Str[i] == "#delay100#"){
					Prt.Right("   ", 2, 48);
					Thread.Sleep(ConstValue.Delayms * 100);
				}
				else{
					Prt.Right("   ", 2, 48);
					Prt.DelayCenter(Str[i], X1, X2, Y+i);
				}
			}
		}
	}
}