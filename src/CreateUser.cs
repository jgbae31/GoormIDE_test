using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	public class CreateUser{
		public void Run(){
			string Path = "/workspace/GoormIDE_test/script/CreateUser";
			
			string[] Script = FileIO.ReadScript(Path);
			
			Console.Clear();
			
			DisplayPrint.GameDisplay();
			for(int i = 0; i < 10; i++) DisplayPrint.HideUserInfo(i);
			ScriptPlay.Center(Script, 35, ConstValue.WinSizeX - 1, 3);
			
		}
	}
}