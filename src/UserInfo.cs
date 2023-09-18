using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
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
}