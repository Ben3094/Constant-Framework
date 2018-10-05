using System;

using ConstantFramework.SI;

namespace ConstantFramework
{
	public class Class1
	{
		public void Main()
		{
			LengthTest();
			MassTest();
			Console.ReadLine();
		}
		public void LengthTest()
		{
			Meter m = 5f;
			Console.WriteLine("Length: " + m.Normalised / Meter.Constant);
			Console.WriteLine("Relative Length: " + m.Normalised);
		}
		public void MassTest()
		{
			Kilogram kg = 5f;
			Console.WriteLine("Mass: " + kg.Normalised / Kilogram.Constant);
			Console.WriteLine("Relative Mass: " + kg.Normalised);
		}
		public void TimeTest()
		{
			Second s = 5f;
			Console.WriteLine("Time: " + s.Normalised / Second.Constant);
			Console.WriteLine("Relative Time: " + s.Normalised);
		}
	}
}
