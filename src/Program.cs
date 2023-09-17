using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	
	//입출력 관련 변수
	/*
	public class FileIO{
		public void WriteData(){
			
		}
		
		public void ReadData(){
			
		}
	}
	*/
	
	//변함없는 상수
	public class ConstValue{
		public const int WinSizeX = 120;
		public const int WinSizeY = 50;
		
		public const string Name00 = "사라헬";
		public const string Name01 = "사 라 헬";
		public const string Name03 = "사   라   헬";
		public const string Name05 = "사     라     헬";
		public const string Name10 = "사          라          헬";
		
		
		public const string Version = "0.0.0";
		
		public const int Delayms = 20;
	}
	
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
	
	
	//선택 함수
	/*
	public class Selection{
		public void UpDown(){
		
		}
	}
	*/
	
	static class Program{
		static void Main(){
			//콘솔 초기 설정
			Console.Title = ConstValue.Name00;
			Console.SetWindowSize(ConstValue.WinSizeX, ConstValue.WinSizeY);
			Console.CursorVisible = false;
			
			//콘솔 화면 리셋
			Console.Clear();
			
			//프로그램 시작
			Title Ttl = new Title();
			
			Ttl.Run();
		}
	}
}