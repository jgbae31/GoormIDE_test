using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{	
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
		public static void ChMaxHP(int N){
			HP += N - MaxHP;
			MaxHP = N;
		}
		public static void ChHP(int N){
			HP += N;	
		}
		public static void ChMoney(int M){
			Money += M;
		}
		public static void ChJob(int J){
			Job = J;	
		}
		public static void ChPersona(int P){
			Persona = P;
		}
		//public static void ChStatus
		public static void AddProperty(string P){
			for(int i = 0; i < 10; i++){
				if(Property[i] == null){
					Property[i] = P;
					i = 999;
				}
			}
		}
		/*
		public static void RmProperty(string P){
			for(int i = 0; i < 10; i++){
				if(Property(i) == P){
					
				}
			}
		}
		*/
		//public static void AddTool
		public static void AddKeyword(string K){
			for(int i = 0; i < 10; i++){
				if(Keyword[i] == null){
					Keyword[i] = K;
					i = 999;
				}
			}
		}
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
			return String.Format("{0:00}", Status[i]);
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