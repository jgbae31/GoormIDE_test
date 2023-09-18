using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	//게임 플레이 화면 출력 관련 함수
	public static class DisplayPrint{
		static Print Prt = new Print();
		
		private static void UserInfo(){
			Prt.Left(".------------------------------.", 1, 1);
			for(int i = 2; i < 49; i++) Prt.Left("|", 1, i);
			for(int i = 2; i < 49; i++) Prt.Left("|", 32, i);
			Prt.Left("|______________________________|", 1, 49);
			
			Prt.Left("진행도 : "+User.RtProgress(), 3, 2);
			
			Prt.Left("------------------------------", 2, 3);
			
			Prt.Left(" 이름  : "+User.RtName(), 3, 4);
			Prt.Left(" 체력  : "+User.RtHealth(), 3, 5);
			Prt.Left("소지금 : "+User.RtMoney(), 3, 6);
			Prt.Left(" 직업  : "+User.RtJob(), 3, 7);
			Prt.Left(" 성향  : "+User.RtPersona(), 3, 8);
			
			Prt.Left("------------------------------", 2, 9);
			
			Prt.Left(" 스탯", 3, 10);
			Prt.Left("   힘   : "+User.RtStatus(0), 3, 11);
			Prt.Left("  민첩  : "+User.RtStatus(1), 3, 12);
			Prt.Left("  지능  : "+User.RtStatus(2), 3, 13);
			Prt.Left("  지혜  : "+User.RtStatus(3), 3, 14);
			Prt.Left("  매력  : "+User.RtStatus(4), 3, 15);
			
			
			Prt.Left("------------------------------", 2, 16);
			
			Prt.Left(" 특성", 3, 17);
			for(int i = 0; i < 10; i++){
				if(User.RtProperty(i) == null) break;
				Prt.Left(" - "+User.RtProperty(i), 3, 18+i);
			}
			
			
			Prt.Left("------------------------------", 2, 28);
			
			Prt.Left("소지품", 3, 29);
			for(int i = 0; i < 6; i++){
				if(User.RtTool(i) == null) break;
				Prt.Left(" - "+User.RtTool(i), 3, 30+i);
			}
			
			Prt.Left("------------------------------", 2, 37);
			
			Prt.Left("키워드", 3, 38);
			for(int i = 0; i < 10; i++){
				if(User.RtKeyword(i) == null) break;
				Prt.Left(" - "+User.RtKeyword(i), 3, 39+i);
			}
		}
		
		private static void ScriptsWindow(){
			Prt.Left(".", 35, 1);
			for(int i = 36; i < ConstValue.WinSizeX - 1; i++) Prt.Left("-", i, 1);
			Prt.Left(".", ConstValue.WinSizeX - 1, 1);
			
			for(int i = 2; i < 50; i++) Prt.Left("|", 35, i);
			for(int i = 2; i < 50; i++) Prt.Left("|", ConstValue.WinSizeX - 1, i);
			
			for(int i = 36; i < ConstValue.WinSizeX - 1; i++) Prt.Left("=", i, 37);
			
			for(int i = 36; i < ConstValue.WinSizeX - 1; i++) Prt.Left("_", i, 49);
		}
		
		public static void GameDisplay(){
			Console.Clear();
			UserInfo();
			ScriptsWindow();
		}
	}
}