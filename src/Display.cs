using System;
using System.IO;

namespace Sarahel{
	public static class Display{
		public static int Sclt_Updown(string[] Btn, int X0, int X1, int Y0){
			int Btns = Btn.Length;
			
			int SlctNum = 0;
			
			ConsoleKeyInfo a = default(ConsoleKeyInfo);
			
			while(a.Key != ConsoleKey.Enter && a.Key != ConsoleKey.Spacebar && a.Key != ConsoleKey.Escape){
				for(int i = 0; i < Btns; i++){
					if(i == SlctNum){
						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Print.Center(Btn[i], X0, X1, Y0+i);
						Console.ForegroundColor = ConsoleColor.Black;
					}
					else{
						Print.Center(Btn[i], X0, X1, Y0+i);
					}
				}
				
				a = Console.ReadKey(true);
				
				switch(a.Key){
					case ConsoleKey.UpArrow:
						if(SlctNum != 0) SlctNum--;
						break;
					case ConsoleKey.DownArrow:
						if(SlctNum != Btns-1) SlctNum++;
						break;
				}
			}
			
			if(a.Key == ConsoleKey.Escape) return -999;
			return SlctNum;
		}
	}
}