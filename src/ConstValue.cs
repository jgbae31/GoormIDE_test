using System;
using System.IO;
using System.Collections.Generic;

namespace Sarahel{
	public static class ConstValue{
		private static Dictionary<string, string> GameName = new Dictionary<string, string>();
		private static Dictionary<string, string> Version = new Dictionary<string, string>();
		private static Dictionary<string, int> Delayms = new Dictionary<string, int>();
		private static Dictionary<string, int> WinSize = new Dictionary<string, int>();
		
		public static void LoadSetFile(string File){
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
	}
}
