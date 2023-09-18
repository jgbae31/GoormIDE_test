using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	public class Intro{
		public void Run(){
			string Path = "/workspace/GoormIDE_test/script/Intro";
			
			string[] Script = FileIO.ReadScript(Path);
			
			Console.Clear();
			
			DisplayPrint.GameDisplay();
			for(int i = 0; i < 10; i++) DisplayPrint.HideUserInfo(i);
			ScriptPlay.Center(Script, 35, ConstValue.WinSizeX - 1, 3);
		}
	}
}