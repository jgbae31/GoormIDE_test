using System;
using System.Threading;

namespace Sarahel{
	public static class Print{
		public static void Center(string Str, int Y){
			Console.SetCursorPosition((ConstValue.CallWinSize("X") - System.Text.Encoding.Default.GetByteCount(Str))/2, Y);
			Console.Write(Str);
		}
		
		public static void Center(string Str, int X0, int X1, int Y){
			Console.SetCursorPosition( X0 + (X1 - X0)/2 - System.Text.Encoding.Default.GetByteCount(Str)/2, Y);
			Console.Write(Str);
		}
		
		public static void Left(string Str, int X, int Y){
			Console.SetCursorPosition(X, Y);
			Console.Write(Str);
		}
		
		public static void Right(string Str, int X, int Y){
			Console.SetCursorPosition(ConstValue.CallWinSize("X") - X - System.Text.Encoding.Default.GetByteCount(Str), Y);
			Console.Write(Str);
		}
		
		public static void DelayCenter(int ms, string Str, int Y){
			Console.SetCursorPosition((ConstValue.CallWinSize("X") - System.Text.Encoding.Default.GetByteCount(Str))/2, Y);
			
			for(int i = 0; i < Str.Length; i++){
				Console.Write(Str[i]);
				Thread.Sleep(ms);
			}
		}
		
		public static void DelayCenter(int ms, string Str, int X0, int X1, int Y){
			Console.SetCursorPosition( X0 + (X1 - X0)/2 - System.Text.Encoding.Default.GetByteCount(Str)/2, Y);
			
			for(int i = 0; i < Str.Length; i++){
				Console.Write(Str[i]);
				Thread.Sleep(ms);
			}
		}
		
		public static void DelayLeft(int ms, string Str, int X, int Y){
			Console.SetCursorPosition(X, Y);
			
			for(int i = 0; i < Str.Length; i++){
				Console.Write(Str[i]);
				Thread.Sleep(ms);
			}
		}
		
		public static void DelayRight(int ms, string Str, int X, int Y){
			Console.SetCursorPosition(ConstValue.CallWinSize("X") - X - System.Text.Encoding.Default.GetByteCount(Str), Y);
			
			for(int i = 0; i < Str.Length; i++){
				Console.Write(Str[i]);
				Thread.Sleep(ms);
			}
		}
	}
}
