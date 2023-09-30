using System;

namespace Sarahel{
	class Program{
		public static void Main(){
			ConstValue.LoadSetFile();
			
			Console.Title = ConstValue.CallGameName("0", 0);
			Console.SetWindowSize(ConstValue.CallWinSize("X"), ConstValue.CallWinSize("Y"));
			Console.CursorVisible = false;
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			
			Console.Clear();
			
			Title.Run();
			
			Console.Clear();
		}
	}
}