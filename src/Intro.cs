using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	public class Intro{
		
		private string[] Scripts = new string[] {	"만나서 반갑습니다!",
													"사라헬의 세계에 오신 당신을 환영합니다.", "#enter#",
													" ",
													"사라헬의 세상에서는 당신의 선택에 따라 모든 것이 결정됩니다.", "#enter#",
													"당신이 어떤 사람인지", "#delay#", "#delay#", "#delay#", "#delay#",
													"어떤 이들을 만나고", "#delay#", "#delay#", "#delay#", "#delay#",
													"어떤 경험을 할지", "#delay#", "#delay#", "#delay#", "#delay#",
													"그리고 당신이 어떠한 결말을 맞이할지...", "#enter#",
													" ",
													"당신의 과거부터 현재, 그리고 미래까지 모두 당신의 선택에 따라 결정됩니다.", "#enter#"
												};
		public void Run(){
			Console.Clear();
			ScriptPlay.Center(Scripts, 3);
		}
	}
}