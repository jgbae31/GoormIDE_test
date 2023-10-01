using System;
using System.IO;
using System.Threading;

namespace Sarahel{
	public static class GameStart{
		public static void Intro(){
			string Path = "/workspace/GoormIDE_test/script/Intro/";
			string File0 = "Script";
			string File1 = "Keybuffer";
			
			string[] Script = System.IO.File.ReadAllLines(Path+File0);
			string[] Keybuffer = System.IO.File.ReadAllLines(Path+File1);
			
			ConsoleKeyInfo a = default(ConsoleKeyInfo);
			
			
			
			Display.Run();
			
			for(int i = 0; i < Script.Length; i++){
				Print.DelayCenter(ConstValue.CallDelayms("Text"), Script[i], 36, ConstValue.CallWinSize("X")-1, 3+i);
				if(Convert.ToInt32(Keybuffer[i]) == 1) a = Console.ReadKey(true);
			}
			
		}
		
		public static bool LoadPlayer(){
			string id;
			string pw;
			
			string[] Sclt_Scripts = new string[2] {"불러오기", "돌아가기"};
			
			do{
				Console.Clear();
				
				for(int i = 0; i < 2; i++) Print.Center(Sclt_Scripts[i], ConstValue.CallWinSize("Y")-8+i);
				
				Print.Left("ID       : ", 1, ConstValue.CallWinSize("Y")-10);
				Print.Left("비밀번호 : ", 1, ConstValue.CallWinSize("Y")-9);
				
				Console.SetCursorPosition(12, ConstValue.CallWinSize("Y")-10);
				id = Console.ReadLine();
				Console.SetCursorPosition(12, ConstValue.CallWinSize("Y")-9);
				pw = Console.ReadLine();
				
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Print.Center("불러오기", ConstValue.CallWinSize("Y")-8);
				Console.ForegroundColor = ConsoleColor.Black;
				
				if(Display.Sclt_UpDown(Sclt_Scripts, 0, ConstValue.CallWinSize("X"), ConstValue.CallWinSize("Y")-8) != 0) return false;
				
			}while(PlayerInfo.Load(id, pw));
			
			return true;
		}
		

		public static void Run(){
			Display.Run();
			
			ConsoleKeyInfo a = Console.ReadKey(true);
		}
	}
}