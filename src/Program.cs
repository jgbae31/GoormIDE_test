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
	
	//게임 플레이 화면 출력 관련 함수
	public static class DisplayPrint{
		static Print Prt = new Print();
		
		public static void UserInfo(){
			Prt.Left(".------------------------------.", 1, 0);
			for(int i = 1; i < 48; i++) Prt.Left("|", 1, i);
			for(int i = 1; i < 48; i++) Prt.Left("|", 32, i);
			Prt.Left("|______________________________|", 1, 48);
			
			Prt.Left("진행도 : "+User.RtProgress(), 3, 1);
			
			Prt.Left("------------------------------", 2, 2);
			
			Prt.Left(" 이름  : "+User.RtName(), 3, 3);
			Prt.Left(" 체력  : "+User.RtHealth(), 3, 4);
			Prt.Left("소지금 : "+User.RtMoney(), 3, 5);
			Prt.Left(" 직업  : "+User.RtJob(), 3, 6);
			Prt.Left(" 성향  : "+User.RtPersona(), 3, 7);
			
			Prt.Left("------------------------------", 2, 8);
			
			Prt.Left(" 스탯", 3, 9);
			Prt.Left("   힘   : "+User.RtStatus(0), 3, 10);
			Prt.Left("  민첩  : "+User.RtStatus(1), 3, 11);
			Prt.Left("  지능  : "+User.RtStatus(2), 3, 12);
			Prt.Left("  지혜  : "+User.RtStatus(3), 3, 13);
			Prt.Left("  매력  : "+User.RtStatus(4), 3, 14);
			
			
			Prt.Left("------------------------------", 2, 15);
			
			Prt.Left(" 특성", 3, 16);
			for(int i = 0; i < 10; i++){
				if(User.RtProperty(i) == null) break;
				Prt.Left(" - "+User.RtProperty(i), 3, 17+i);
			}
			
			
			Prt.Left("------------------------------", 2, 27);
			
			Prt.Left("소지품", 3, 28);
			for(int i = 0; i < 6; i++){
				if(User.RtTool(i) == null) break;
				Prt.Left(" - "+User.RtTool(i), 3, 29+i);
			}
			
			Prt.Left("------------------------------", 2, 36);
			
			Prt.Left("키워드", 3, 37);
			for(int i = 0; i < 10; i++){
				if(User.RtKeyword(i) == null) break;
				Prt.Left(" - "+User.RtKeyword(i), 3, 38+i);
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
	
	//유저 정보
	public static class User{
		//유저 정보 변수
		static int Progress;
		
		static string Name;
		
		static int MaxHP;
		static int HP;
		
		static int Money;
		
		static string[] Jobs = new string[4] {"전사", "도적", "학자", "마법사"};
		static int Job;
		
		static string[] Personas = new string[3] {"선", "중립", "악"};
		static int Persona;
		
		static int[] Status = new int[5];
		
		static string[] Property = new string[10];
		
		static string[] Tool = new string[6];
		
		static string[] Keyword = new string[10];
		
		static string GameGoal;
		
		
		
		//유저 정보 변환 함수
		public static void ChProgress(int N){
			Progress = N;
		}
		public static void ChName(string N){
			Name = N;	
		}
		public static void ChMaxHp(int N){
			HP += N - MaxHP;
			MaxHP = N;
		}
		public static void ChHP(int N){
			HP += N;	
		}
		public static void ChJob(int J){
			Job = J;	
		}
		public static void ChPersona(int P){
			Persona = P;
		}
		//public static void ChStatus
		//public static void ChProperty
		//public static void ChTool
		//public static void ChKeyword
		public static void ChGameGoal(string G){
			GameGoal = G;
		}
		
		
		
		//유저 정보 반환 함수
		public static string RtProgress(){
			return String.Format("{0:000}", Progress);
		}
		public static string RtName(){
			return Name;
		}
		public static string RtHealth(){
			return String.Format("{0:00}", HP) + " / " + String.Format("{0:00}", MaxHP);
		}
		public static string RtMoney(){
			return String.Format("{0:000}", Money);
		}
		public static string RtJob(){
			return Jobs[Job];
		}
		public static string RtPersona(){
			return Personas[Persona];
		}
		public static string RtStatus(int i){
			return String.Format("{0:000}", Status[i]);
		}
		public static string RtProperty(int i){
			return Property[i];
		}
		public static string RtTool(int i){
			return Tool[i];
		}
		public static string RtKeyword(int i){
			return Keyword[i];
		}
	}
	
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