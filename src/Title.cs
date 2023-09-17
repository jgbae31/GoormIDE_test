using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	public class Title{
		Print Prt = new Print();
		
		private void MainTitle(){
			Prt.Left("Version : "+ConstValue.Version, 2, 1);
			Prt.Center(ConstValue.Name10, 5);
			Prt.Center("처음부터", ConstValue.WinSizeY-10);
			Prt.Center("불러오기", ConstValue.WinSizeY-9);
			Prt.Center("게임종료", ConstValue.WinSizeY-8);
		}
		
		private int Selection(int SlctNum){
			ConsoleKeyInfo a = new ConsoleKeyInfo();
			
			do{
				Prt.Left(" ", (ConstValue.WinSizeX - System.Text.Encoding.Default.GetByteCount("처음부터"))/2 - 2, ConstValue.WinSizeY-10);
				Prt.Left(" ", (ConstValue.WinSizeX + "처음부터".Length)/2 - 1, ConstValue.WinSizeY-10);
				Prt.Left(" ", (ConstValue.WinSizeX - System.Text.Encoding.Default.GetByteCount("처음부터"))/2 - 2, ConstValue.WinSizeY-9);
				Prt.Left(" ", (ConstValue.WinSizeX + "처음부터".Length)/2 - 1, ConstValue.WinSizeY-9);
				Prt.Left(" ", (ConstValue.WinSizeX - System.Text.Encoding.Default.GetByteCount("처음부터"))/2 - 2, ConstValue.WinSizeY-8);
				Prt.Left(" ", (ConstValue.WinSizeX + "처음부터".Length)/2 - 1, ConstValue.WinSizeY-8);
				
				switch(SlctNum){
					case 0:
						Prt.Left("[", (ConstValue.WinSizeX - System.Text.Encoding.Default.GetByteCount("처음부터"))/2 - 2, ConstValue.WinSizeY-10);
						Prt.Left("]", (ConstValue.WinSizeX + "처음부터".Length)/2 - 1, ConstValue.WinSizeY-10);
						break;
					case 1:
						Prt.Left("[", (ConstValue.WinSizeX - System.Text.Encoding.Default.GetByteCount("처음부터"))/2 - 2, ConstValue.WinSizeY-9);
						Prt.Left("]", (ConstValue.WinSizeX + "처음부터".Length)/2 - 1, ConstValue.WinSizeY-9);
						break;
					case 2:
						Prt.Left("[", (ConstValue.WinSizeX - System.Text.Encoding.Default.GetByteCount("처음부터"))/2 - 2, ConstValue.WinSizeY-8);
						Prt.Left("]", (ConstValue.WinSizeX + "처음부터".Length)/2 - 1, ConstValue.WinSizeY-8);
						break;
				}
				
				a = Console.ReadKey(true);
				
				switch(a.Key){
					case ConsoleKey.UpArrow:
						if(SlctNum != 0) SlctNum--;
						break;
					case ConsoleKey.DownArrow:
						if(SlctNum != 2) SlctNum++;
						break;
				}
			}while(a.Key != ConsoleKey.Spacebar && a.Key != ConsoleKey.Enter && a.Key != ConsoleKey.Escape);
			
			if(a.Key == ConsoleKey.Escape) return -999;
			
			return SlctNum;
		}
		
		public void Run(){
			bool RunProgram = true;
			
			while(RunProgram){
				MainTitle();
				
				switch(Selection(0)){
				case 0:
					RunProgram = true;
					break;
				case 1:
					RunProgram = true;
					break;
				default:
					RunProgram = false;
					break;
				}
			}
		}
	}
}