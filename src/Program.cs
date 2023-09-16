using System;
using System.IO;

namespace GoormIDE_test{
	public class ConstValue{
		public const int WinSizeX = 100;
		public const int WinSizeY = 40;
		
		public const string Version = "0.0.1";
	}
	
	public class Print{
		public void Center(string Str, int Y){
			int ByteSize = System.Text.Encoding.Default.GetByteCount(Str);
			
			Console.SetCursorPosition((ConstValue.WinSizeX - ByteSize)/2, Y);
			
			Console.Write(Str);
		}
		
		public void Center(string Str, int X, int Y){
			int ByteSize = System.Text.Encoding.Default.GetByteCount(Str);
			
			Console.SetCursorPosition( X + (ConstValue.WinSizeX - X)/2 - (ByteSize)/2, Y);
			
			Console.Write(Str);
		}
		
		public void Left(string Str, int X, int Y){
			Console.SetCursorPosition(X, Y);
			
			Console.Write(Str);
		}
		
		public void Right(string Str, int X, int Y){
			int ByteSize = System.Text.Encoding.Default.GetByteCount(Str);
			
			Console.SetCursorPosition(X - ByteSize, Y);
			
			Console.Write(Str);
		}
	}
	
	class Program{
		
		static void Main(){
			Print Prt = new Print();

			Console.Clear();
			Console.SetWindowSize(ConstValue.WinSizeX, ConstValue.WinSizeY);
			Console.CursorVisible = false;
			
			Prt.Center("Version : "+ConstValue.Version, 10);
		}
	}
}
