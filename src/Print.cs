using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	//화면 출력관련 함수
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
			
			Console.SetCursorPosition(ConstValue.WinSizeX - X - ByteSize, Y);
			
			Console.Write(Str);
		}
		
		public void DelayCenter(string Str, int X, int Y, int ms){
			int ByteSize = System.Text.Encoding.Default.GetByteCount(Str);
			
			Console.SetCursorPosition( X + (ConstValue.WinSizeX - X)/2 - (ByteSize)/2, Y);
			
			for(int i = 0; i < Str.Length; i++){
				Console.Write(Str[i]);
				Thread.Sleep(ms);
			}
		}
		
		public void DelayLeft(string Str, int X, int Y, int ms){
			Console.SetCursorPosition(X, Y);
			
			for(int i = 0; i < Str.Length; i++){
				Console.Write(Str[i]);
				Thread.Sleep(ms);
			}
		}
		
		public void DelayRight(string Str, int X, int Y, int ms){
			int ByteSize = System.Text.Encoding.Default.GetByteCount(Str);
			
			Console.SetCursorPosition(ConstValue.WinSizeX - X - ByteSize, Y);
			
			for(int i = 0; i < Str.Length; i++){
				Console.Write(Str[i]);
				Thread.Sleep(ms);
			}
		}
		
		public void DelayCenter(string Str, int Y){
			int ByteSize = System.Text.Encoding.Default.GetByteCount(Str);
			
			Console.SetCursorPosition((ConstValue.WinSizeX - ByteSize)/2, Y);
			
			for(int i = 0; i < Str.Length; i++){
				Console.Write(Str[i]);
				Thread.Sleep(ConstValue.Delayms);
			}
			
		}
		
		public void DelayCenter(string Str, int X, int Y){
			int ByteSize = System.Text.Encoding.Default.GetByteCount(Str);
			
			Console.SetCursorPosition( X + (ConstValue.WinSizeX - X)/2 - (ByteSize)/2, Y);
			
			for(int i = 0; i < Str.Length; i++){
				Console.Write(Str[i]);
				Thread.Sleep(ConstValue.Delayms);
			}
		}
		
		public void DelayLeft(string Str, int X, int Y){
			Console.SetCursorPosition(X, Y);
			
			for(int i = 0; i < Str.Length; i++){
				Console.Write(Str[i]);
				Thread.Sleep(ConstValue.Delayms);
			}
		}
		
		public void DelayRight(string Str, int X, int Y){
			int ByteSize = System.Text.Encoding.Default.GetByteCount(Str);
			
			Console.SetCursorPosition(ConstValue.WinSizeX - X - ByteSize, Y);
			
			for(int i = 0; i < Str.Length; i++){
				Console.Write(Str[i]);
				Thread.Sleep(ConstValue.Delayms);
			}
		}
	}
}