using System;
using System.IO;

namespace Sarahel{
	public static class PlayerInfo{
		static int Progress;
		
		static string Name;
		
		static int MaxHP;
		static int HP;
		
		static int Money;
		
		static string[] Jobs = new string[5] {"전사", "도적", "학자", "마법사", "게임 마스터"};
		static int Job;
		
		static string[] Personas = new string[4] {"선", "중립", "악", "게임 마스터"};
		static int Persona;
		
		static int[] Status = new int[5];
		
		static string[] Property = new string[10];
		
		static string[] Tool = new string[6];
		
		static string[] Keyword = new string[10];
		
		static string GameGoal;
		
		
		
		public static void Change(string Type, string Str){
			switch(Type){
				case "Progress":
					Progress = Convert.ToInt32(Str);
					break;
				case "Name":
					Name = Str;
					break;
				case "MaxHP":
					HP += Convert.ToInt32(Str) - MaxHP;
					MaxHP = Convert.ToInt32(Str);
					break;
				case "Job":
					Job = Convert.ToInt32(Str);
					break;
				case "Persona":
					Persona = Convert.ToInt32(Str);
					break;
				case "GameGoal":
					GameGoal = Str;
					break;
			}
		}
		
		/*
		public static void Remove(string Type, string Str){
			switch(Type){
				case "Property":
					break;
				case "Tool":
					break;
				case "Keyword":
					break;
			}
		}
		*/
		
		public static void Add(string Type, string Str){
			switch(Type){
				case "Property":
					for(int i = 0; i < 10; i++){
						if(Property[i] == null){
							Property[i] = Str;
							i = 999;
						}
					}
					break;
				case "Tool":
					for(int i = 0; i < 10; i++){
						if(Tool[i] == null){
							Tool[i] = Str;
							i = 999;
						}
					}
					break;
				case "Keyword":
					for(int i = 0; i < 10; i++){
						if(Keyword[i] == null){
							Keyword[i] = Str;
							i = 999;
						}
					}
					break;
			}
		}
		
		public static string Return(string Type){
			switch(Type){
				case "Progress":
					return String.Format("{0:000}", Progress);
					break;
				case "Name":
					return Name;
					break;
				case "Health":
					return String.Format("{0:00}", HP) + "/" + String.Format("{0:00}", MaxHP);
					break;
				case "Money":
					return String.Format("{0:000}", Money);
					break;
				case "Job":
					return Jobs[Job];
					break;
				case "Persona":
					return Personas[Persona];
					break;
				case "GameGoal":
					return GameGoal;
			}
			
			return "Error";
		}
		
		public static string Return(string Type, int i){
			switch(Type){
				case "Status":
					return String.Format("{0:00}", Status[i]);
					break;
				case "Property":
					return Property[i];
					break;
				case "Tool":
					return Tool[i];
					break;
				case "Keyword":
					return Keyword[i];
					break;
			}
			
			return "Error";
		}
		
		public static bool Load(string File, string pw){
			string Path = "/workspace/GoormIDE_test/save/";
			
			string[] SaveData = System.IO.File.ReadAllLines(Path+File);
			
			if(SaveData[0] == pw){
				Progress = Convert.ToInt32(SaveData[1]);
				Name = SaveData[2];
				MaxHP = Convert.ToInt32(SaveData[3]);
				HP = Convert.ToInt32(SaveData[4]);
				Money = Convert.ToInt32(SaveData[5]);
				Job = Convert.ToInt32(SaveData[6]);
				Persona = Convert.ToInt32(SaveData[7]);
				
				string[] Data0 = SaveData[8].Split(',');
				for(int i = 0; i < Data0.Length; i++) Status[i] = Convert.ToInt32(Data0[i]);
				
				string[] Data1 = SaveData[9].Split(',');
				for(int i = 0; i < Data1.Length; i++) Property[i] = Data1[i];
				
				string[] Data2 = SaveData[10].Split(',');
				for(int i = 0; i < Data2.Length; i++) Tool[i] = Data2[i];
				
				string[] Data3 = SaveData[11].Split(',');
				for(int i = 0; i < Data3.Length; i++) Keyword[i] = Data3[i];
				
				GameGoal = SaveData[12];
				
				return false;
			}
			else{
				return true;
			}
		}
	}
}