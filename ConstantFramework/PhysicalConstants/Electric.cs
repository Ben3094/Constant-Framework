using System;

namespace ConstantFramework.PhysicalConstants
{
	public struct Electric
	{
		//Variables
		static float electricConstant = 1f / (Magnetic.Constant * (float)Math.Pow(SpeedOfLight.Constant, 2));

		//Properties
		public static float Constant
		{
			get
			{
				return electricConstant;
			}
		}
	}
}
