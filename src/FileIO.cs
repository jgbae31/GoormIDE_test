using System;
using System.IO;

namespace Sarahel{
	public static class FileIO{
		public static string[] ReadFile(string PathFile){
			return File.ReadAllLines(PathFile);
		}
	}
}