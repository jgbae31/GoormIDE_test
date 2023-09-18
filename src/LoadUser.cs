using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	public class LoadUser{
		private void LoadGM(){
			User.ChProgress(999);
			User.ChName("게임 마스터");
			User.ChMaxHP(99);
			User.ChMoney(999);
			User.ChJob(0);
			User.ChPersona(0);
			User.AddProperty("게임 마스터의 권능");
			User.AddKeyword("게임 마스터의 권능작");
		}
		
		public bool Run(){
			Print Prt = new Print();
			
			ConsoleKeyInfo a = default(ConsoleKeyInfo);
			string ID = null;
			
			do{
				Console.Clear();
				Prt.Left("불러올 게임 ID : ", 3, 3);
				Prt.Center("불러오기", ConstValue.WinSizeY - 10);
				
				Console.SetCursorPosition(20, 3);
				ID = Console.ReadLine();
				
				if(ID == "Load to Game Master"){
					a = Console.ReadKey(true);
					if(a.Key == ConsoleKey.UpArrow){
						a = default(ConsoleKeyInfo);
						a = Console.ReadKey(true);
						if(a.Key == ConsoleKey.UpArrow){
							a = default(ConsoleKeyInfo);
							a = Console.ReadKey(true);
							if(a.Key == ConsoleKey.RightArrow){
								a = default(ConsoleKeyInfo);
								a = Console.ReadKey(true);
								if(a.Key == ConsoleKey.LeftArrow){
									a = default(ConsoleKeyInfo);
									a = Console.ReadKey(true);
									if(a.Key == ConsoleKey.Enter){
										LoadGM();
										return true;
									}
								}
							}
						}
					}
				}
				
				Prt.Center("[ 불러오기 ]", ConstValue.WinSizeY - 10);
				a = Console.ReadKey(true);
			}while(a.Key != ConsoleKey.Spacebar && a.Key != ConsoleKey.Enter && a.Key != ConsoleKey.Escape);
			
			return false;
		}
	}
}