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
		
		private static void InfoBoard(){
			Print.Left(".------------------------------.", 1, 1);
			for(int i = 2; i < 49; i++){
				Print.Left("|",  1, i);
				Print.Left("|", 32, i);
			}
			Print.Left("|______________________________|", 1, 49);
			
			Print.Left("진행도 : "+PlayerInfo.Return("Progress"), 3, 2);
			
			Print.Left("------------------------------", 2, 3);
			
			Print.Left(" 이름  : "+PlayerInfo.Return("Name"), 3, 4);
			Print.Left(" 체력  : "+PlayerInfo.Return("Health"), 3, 5);
			Print.Left(" 소지금 : "+PlayerInfo.Return("Money"), 3, 6);
			Print.Left(" 직업  : "+PlayerInfo.Return("Job"), 3, 7);
			Print.Left(" 성향  : "+PlayerInfo.Return("Persona"), 3, 8);
			
			Print.Left("------------------------------", 2, 9);
			
			Print.Left(" 스탯", 3, 10);
			Print.Left("  힘  :"+PlayerInfo.Return("Status", 0), 3, 11);
			Print.Left(" 민첩 :"+PlayerInfo.Return("Status", 1), 3, 12);
			Print.Left(" 지능 :"+PlayerInfo.Return("Status", 2), 3, 13);
			Print.Left(" 지혜 :"+PlayerInfo.Return("Status", 3), 3, 14);
			Print.Left(" 매력 :"+PlayerInfo.Return("Status", 4), 3, 15);
			
			Print.Left("------------------------------", 2, 16);
			
			Print.Left(" 특성", 3, 17);
			for(int i = 0; i < 10; i++){
				if(PlayerInfo.Return("Property", i) == null) break;
				Print.Left(" - "+PlayerInfo.Return("Property", i), 3, 18+i);
			}
			
			Print.Left("------------------------------", 2, 28);
			
			Print.Left(" 소지품", 3, 29);
			for(int i = 0; i < 6; i++){
				if(PlayerInfo.Return("Tool", i) == null) break;
				Print.Left(" - "+PlayerInfo.Return("Tool", i), 3, 30+i);
			}
			
			Print.Left("------------------------------", 2, 37);
			
			Print.Left(" 키워드", 3, 38);
			for(int i = 0; i < 10; i++){
				if(PlayerInfo.Return("Keyword", i) == null) break;
				Print.Left(" - "+PlayerInfo.Return("Keyword", i), 3, 39+i);
			}
		}
		
		private static void ScriptsWindow(){
			Print.Left(".", 35, 1);
			for(int i = 36; i < ConstValue.CallWinSize("X") - 1; i++) Print.Left("-", i, 1);
			Print.Left(".", ConstValue.CallWinSize("X") - 1, 1);
			
			for(int i = 2; i < 50; i++){
				Print.Left("|", 35, i);
				Print.Left("|", ConstValue.CallWinSize("X") - 1, i);
			}
			
			for(int i = 36; i < ConstValue.CallWinSize("X") - 1; i++){
				Print.Left("=", i, 37);
				Print.Left("_", i, 49);
			}
		}
		
		public static void Run(){
			Console.Clear();
			InfoBoard();
			ScriptsWindow();
		}
	}
}