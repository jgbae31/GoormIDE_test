using System;
using System.IO;

namespace Sarahel{
	public static class Title{
		private static void DisplayTitle(){
			Print.Left("Version : "+ConstValue.CallVersion("Version"), 0, 0);
			Print.Center(ConstValue.CallGameName("0", 8), 10);
		}
		
		public static void Run(){
			bool RunProgram = true;
			
			while(RunProgram){
				
				Console.Clear();
				
				DisplayTitle();
				
				switch(Display.Sclt_UpDown(File.ReadAllLines("/workspace/GoormIDE_test/script/Title/Title"), 0, ConstValue.CallWinSize("X"), ConstValue.CallWinSize("Y")-10)){
					case 0:
						GameStart.Intro();
						CreatePlayer.Run();
						GameStart.Run();
						RunProgram = true;
						break;
					case 1:
						if(GameStart.LoadPlayer()) GameStart.Run();
						RunProgram = true;
						break;
					default :
						RunProgram = false;
						break;
				}
			}
		}
	}
}