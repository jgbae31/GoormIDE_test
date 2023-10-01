using System;
using System.IO;

class test{
	
	public static void Main(){
		double ba, bv, uw, uv;
		
		string[] a = File.ReadAllLines("/workspace/GoormIDE_test/test/test");
		
		ba = Convert.ToDouble(a[0]);
		bv = Convert.ToDouble(a[1]);
		uw = Convert.ToDouble(a[2]);
		uv = Convert.ToDouble(a[3]);
		
		Console.WriteLine(ba / ((uw / uv) * bv));
	}
}