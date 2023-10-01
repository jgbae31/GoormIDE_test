using System;

namespace Sarahel{
	public static class CreatePlayer{
		private static void Name(){
			string nm;
			
			Display.Run("1111111111");
			
			Print.DelayCenter(ConstValue.CallDelayms("Text"), "그럼 이제 당신이 누구인지 알려주세요", 36, ConstValue.CallWinSize("X")-1, 3);
			Print.DelayLeft(ConstValue.CallDelayms("Text"), "이름은 무엇인가요?", 37, 5);
			
			Print.Left("이름 : ", 37, 39);
			Console.CursorVisible = true;
			nm = Console.ReadLine();
			Console.CursorVisible = false;
			
			PlayerInfo.Change("Name", nm);
		}
		
		private static void Job(){
			string Path = "/workspace/GoormIDE_test/script/Create/Job/";
			string File = "Option_Text";
			
			string jb = null;
			string[] opt = System.IO.File.ReadAllLines(Path+File);
			
			Display.Run("1011111111");
			
			Print.Center("그럼 이제 당신이 누구인지 알려주세요", 36, ConstValue.CallWinSize("X")-1, 3);
			Print.Left("이름은 무엇인가요?", 37, 5);
			Print.DelayLeft(ConstValue.CallDelayms("Text"), "어떤 직업을 가지고 있나요?", 37, 6);
			
			switch(Display.Sclt_UpDown(opt, 36, ConstValue.CallWinSize("X")-1, 39)){
				case 0:
					jb = "0";
					PlayerInfo.Change("MaxHP", "11");
					PlayerInfo.Add("Money", "5");
					break;
				case 1:
					jb = "1";
					PlayerInfo.Change("MaxHP", "8");
					PlayerInfo.Add("Money", "3");
					break;
				case 2:
					jb = "2";
					PlayerInfo.Change("MaxHP", "7");
					PlayerInfo.Add("Money", "5");
					break;
				case 3:
					jb = "3";
					PlayerInfo.Change("MaxHP", "6");
					PlayerInfo.Add("Money", "8");
					break;
			}
			
			PlayerInfo.Change("Job", jb);
		}
		
		private static void Persona(){
			string Path = "/workspace/GoormIDE_test/script/Create/Persona/";
			string File = "Option_Text";
			
			string psn = null;
			string[] opt = System.IO.File.ReadAllLines(Path+File);
			
			Display.Run("1000011111");
			
			Print.Center("그럼 이제 당신이 누구인지 알려주세요", 36, ConstValue.CallWinSize("X")-1, 3);
			Print.Left("이름은 무엇인가요?", 37, 5);
			Print.Left("어떤 직업을 가지고 있나요?", 37, 6);
			Print.DelayLeft(ConstValue.CallDelayms("Text"), "어떤 성향의 사람인가요?", 37, 7);
			
			psn = Convert.ToString(Display.Sclt_UpDown(opt, 36, ConstValue.CallWinSize("X")-1, 39));
			
			PlayerInfo.Change("Persona", psn);
		}
		
		private static void Status(){
			string Path = "/workspace/GoormIDE_test/script/Create/Status/";
			string File = "Option_Text";
			
			bool Retemp = true;
			string[] opt = System.IO.File.ReadAllLines(Path+File);
			
			Display.Run("1000001111");
			
			Print.Center("그럼 이제 당신이 누구인지 알려주세요", 36, ConstValue.CallWinSize("X")-1, 3);
			Print.Left("이름은 무엇인가요?", 37, 5);
			Print.Left("어떤 직업을 가지고 있나요?", 37, 6);
			Print.Left("어떤 성향의 사람인가요?", 37, 7);
			Print.DelayLeft(ConstValue.CallDelayms("Text"), "당신의 재능은 어느정도인가요?", 37, 8);
			
			while(Retemp){
				Random Rd = new Random();
				
				int[] temp = new int[] {3, 8, 10, 15, 17};
				int temp0, temp1, temp2, temp3, temp4;
				
				temp0 = temp[Rd.Next(5)];
				do{
					temp1 = temp[Rd.Next(5)];
				}while(temp1 == temp0);
				do{
					temp2 = temp[Rd.Next(5)];
				}while(temp2 == temp0 || temp2 == temp1);
				do{
					temp3 = temp[Rd.Next(5)];
				}while(temp3 == temp0 || temp3 == temp1 || temp3 == temp2);
				do{
					temp4 = temp[Rd.Next(5)];
				}while(temp4 == temp0 || temp4 == temp1 || temp4 == temp2 || temp4 == temp3);
				
				switch(PlayerInfo.Return("Job")){
					case "전사":
						temp0 += 2; temp1 += 2; temp2 += -2; temp3 += -1; temp4 += 0;
						break;
					case "도적":
						temp0 += -1; temp1 += 2; temp2 += -2; temp3 += 2; temp4 += 0;
						break;
					case "학자":
						temp0 += -2; temp1 += -1; temp2 += 0; temp3 += 2; temp4 += 2;
						break;
					case "마법사":
						temp0 += -3; temp1 += -2; temp2 += 3; temp3 += 2; temp4 += 1;
						break;
				}
				
				Print.Left("힘 : "+String.Format("{0:00}", temp0), 45, 10);
				Print.Left("민첩 : "+String.Format("{0:00}", temp1), 53, 10);
				Print.Left("지능 : "+String.Format("{0:00}", temp2), 63, 10);
				Print.Left("지혜 : "+String.Format("{0:00}", temp3), 73, 10);
				Print.Left("매력 : "+String.Format("{0:00}", temp4), 83, 10);
				
				switch(Display.Sclt_UpDown(opt, 36, ConstValue.CallWinSize("X")-1, 39)){
					case 0:
						Retemp = true;
						break;
					case 1:
						PlayerInfo.Change("Status", temp0, 0);
						PlayerInfo.Change("Status", temp1, 1);
						PlayerInfo.Change("Status", temp2, 2);
						PlayerInfo.Change("Status", temp3, 3);
						PlayerInfo.Change("Status", temp4, 4);
						Retemp = false;
						break;
				}
			}
		}
		
		private static void Property(int Num){
			string Path = "/workspace/GoormIDE_test/script/Create/Property/";
			string File = "Script_Text";
			string File0 = "Option_Text"+Num;
			string File1 = "Property"+Num;
			
			string[] scrt = System.IO.File.ReadAllLines(Path+File);
			string[] opt = System.IO.File.ReadAllLines(Path+File0);
			string[] ppty = System.IO.File.ReadAllLines(Path+File1);
			
			Display.Run("1000000111");
			
			Print.Center("그럼 이제 당신이 누구인지 알려주세요", 36, ConstValue.CallWinSize("X")-1, 3);
			Print.Left("이름은 무엇인가요?", 37, 5);
			Print.Left("어떤 직업을 가지고 있나요?", 37, 6);
			Print.Left("어떤 성향의 사람인가요?", 37, 7);
			Print.Left("당신의 재능은 어느정도인가요?", 37, 8);
			if(Num == 0){
				Print.DelayLeft(ConstValue.CallDelayms("Text"), "당신은 어떤 삶을 살아왔나요?", 37, 9);
			}
			else{
				Print.Left("당신은 어떤 삶을 살아왔나요?", 37, 9);
			}
			
			if(Num > 0) for(int i = 0; i < Num; i ++) Print.Center(scrt[i], 36, ConstValue.CallWinSize("X")-1, 11+i);
			Print.DelayCenter(ConstValue.CallDelayms("Text"), scrt[Num], 36, ConstValue.CallWinSize("X")-1, 11+Num);
			
			switch(Num){
				case 1:
					int temp1 = Display.Sclt_UpDown(opt, 36, ConstValue.CallWinSize("X")-1, 39);
					if(temp1 == 0 && PlayerInfo.Return("Persona") == "선"){
						PlayerInfo.Add("Property", "의적");
					}
					else if(temp1 == 4){
						string[] opt1 = System.IO.File.ReadAllLines(Path+"Option_Text1-1");
						string[] ppty1 = System.IO.File.ReadAllLines(Path+"Option_Text1-1");
						Display.ClearScriptWindow(1);
						PlayerInfo.Add("Property", ppty1[Display.Sclt_UpDown(opt1, 36, ConstValue.CallWinSize("X")-1, 39)]);
					}
					else{
						PlayerInfo.Add("Property", ppty[temp1]);
					}
					break;
				case 2:
					int temp2 = Display.Sclt_UpDown(opt, 36, ConstValue.CallWinSize("X")-1, 39);
					if(temp2 == 1 && PlayerInfo.Return("Persona") == "악") PlayerInfo.Add("Property", "위선");

					string[] ppty2 = ppty[temp2].Split(',');
					PlayerInfo.Add("Property", ppty2[0]);
					PlayerInfo.Change("GameGoal", ppty2[1]);
					break;
				default:
					PlayerInfo.Add("Property", ppty[Display.Sclt_UpDown(opt, 36, ConstValue.CallWinSize("X")-1, 39)]);
					break;
			}
			
			
		}
		
		public static void Run(){
			PlayerInfo.Reset();
			Name();
			Job();
			Persona();
			Status();
			for(int i = 0; i < 5; i++) Property(i);
		}
	}
}