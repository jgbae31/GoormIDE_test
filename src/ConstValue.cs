using System;
using System.IO;
using System.Collections.Generic;

namespace Sarahel{
	public static class ConstValue{
		private static Dictionary<string, string> GameName = new Dictionary<string, string>();
		private static Dictionary<string, string> Version = new Dictionary<string, string>();
		private static Dictionary<string, int> Delayms = new Dictionary<string, int>();
		private static Dictionary<string, int> WinSize = new Dictionary<string, int>();
		
		private static void LoadSetFile(string File){
			string Path = "/workspace/GoormIDE_test/setting/";
			
			StreamReader Sr = new StreamReader(Path+File);
			
			while(!Sr.EndOfStream){
				string Line = Sr.ReadLine();
				string[] Data = Line.Split(',');
				
				switch(File){
					case "GameName":
						GameName.Add(Data[0], Data[1]);
						break;
					case "Version":
						Version.Add(Data[0], Data[1]);
						break;
					case "Delayms":
						Delayms.Add(Data[0], Convert.ToInt32(Data[1]));
						break;
					case "WinSize":
						WinSize.Add(Data[0], Convert.ToInt32(Data[1]));
						break;
				}
			}
		}
		
		private static void ResetSetFile(){
			foreach(string TKey in GameName.Keys) GameName.Remove(TKey);
			foreach(string TKey in Version.Keys) Version.Remove(TKey);
			foreach(string TKey in Delayms.Keys) Delayms.Remove(TKey);
			foreach(string TKey in WinSize.Keys) WinSize.Remove(TKey);
		}
		
		public static void LoadSetFile(){
			ResetSetFile();
			
			LoadSetFile("GameName");
			LoadSetFile("Version");
			LoadSetFile("Delayms");
			LoadSetFile("WinSize");
		}
		
		public static string CallGameName(string Key, int NumSpace){			
			string a = GameName[Key];
			string b = null;
			for(int i = 0; i < a.Length-1; i++){
				b += a[i];
				for(int j = 0; j < NumSpace; j++) b += " ";
			}
			b += a[a.Length-1];
			
			return b;
		}
		
		public static string CallVersion(string Key){
			return Version[Key];
		}
		
		public static int CallDelayms(string Key){
			return Delayms[Key];
		} 
		
		public static int CallWinSize(string Key){
			return WinSize[Key];
		}
	}
}
