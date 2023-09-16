using System;
using System.IO;

namespace GoormIDE_test{
	public class ConstValue{
		public const string Version = "0.0.1";
	}
	
	class Program{
		static void Main(){
			Console.WriteLine("GoormIDE test version :"+ConstValue.Version);
		}
	}
}
