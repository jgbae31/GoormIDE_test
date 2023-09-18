using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	
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