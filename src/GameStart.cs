using System;

namespace Sarahel{
	public static class GameStart{
		public static void Intro(){
			Display.Run();
			
			ConsoleKeyInfo a = Console.ReadKey(true);
		}
		
		/*
		public static void CreatePlayer(){
			
		}
		*/
		
		public static void LoadPlayer(){
			string id;
			string pw;
			
			do{
				Print.Left("ID : ", 1, 1); id = Console.ReadLine();
				Print.Left("비밀번호 : ", 1, 2); pw = Console.ReadLine();
			}while(PlayerInfo.Load(id, pw));
		}
		

		public static void Run(){
			Display.Run();
			
			ConsoleKeyInfo a = Console.ReadKey(true);
		}
	}
}