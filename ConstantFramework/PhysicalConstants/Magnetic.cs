using System;

namespace ConstantFramework.PhysicalConstants
{
	public struct Magnetic
	{
		//Variables
		static float magneticConstant = 4f * 3.14f * (float)Math.Pow(10, -7);

		//Properties
		public static float Constant
		{
			get
			{
				return magneticConstant;
			}
		}
	}
}
