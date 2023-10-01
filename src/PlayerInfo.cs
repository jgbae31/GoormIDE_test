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
		
		public static void Change(string Type, int St, int i){
			switch(Type){
				case "Status":
					Status[i] = St;
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
				case "HP":
					HP += Convert.ToInt32(Str);
					if(HP > MaxHP) HP = MaxHP;
					break;
				case "MaxHP":
					MaxHP += Convert.ToInt32(Str);
					if(HP > MaxHP) HP = MaxHP;
					break;
				case "Money":
					Money += Convert.ToInt32(Str);
					break;
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
				case "Name":
					return Name;
				case "Health":
					return String.Format("{0:00}", HP) + "/" + String.Format("{0:00}", MaxHP);
				case "Money":
					return String.Format("{0:000}", Money);
				case "Job":
					return Jobs[Job];
				case "Persona":
					return Personas[Persona];
				case "GameGoal":
					return GameGoal;
			}
			
			return "Error";
		}
		
		public static string Return(string Type, int i){
			switch(Type){
				case "Status":
					return String.Format("{0:00}", Status[i]);
				case "Property":
					return Property[i];
				case "Tool":
					return Tool[i];
				case "Keyword":
					return Keyword[i];
			}
			
			return "Error";
		}
		
		public static void Reset(){
		Progress = 0;	
		Name = null;	
		MaxHP = 0;
		HP = 0;
		Money = 0;	
		Job = 0;	
		Persona = 0;	
		for(int i = 0; i < 5; i++) Status[i] = 0;	
		for(int i = 0; i < 10; i++) Property[i] = null;	
		for(int i = 0; i < 6; i++) Tool[i] = null;	
		for(int i = 0; i < 10; i++) Keyword[i] = null;	
		GameGoal = null;
		}
		
		public static bool Load(string File, string pw){
			string Path = "/workspace/GoormIDE_test/save/";
			
			if(System.IO.File.Exists(Path+File)){
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
			else{
				return true;
			}
		}
	}
}