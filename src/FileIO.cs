using System;
using System.Threading;
using System.IO;

namespace GoormIDE_test{
	
	//입출력 관련 변수
	public static class FileIO{
		/*
		public void WriteData(){
			
		}
		*/
		
		public static string[] ReadScript(string Path){
			return File.ReadAllLines(Path);
		}
	}
}