using System;

namespace ConstantFramework.PhysicalConstants
{
	public struct Impedance
	{
		//Variables
		static float impedanceConstant = Magnetic.Constant * SpeedOfLight.Constant;

		//Properties
		public static float Constant
		{
			get
			{
				return impedanceConstant;
			}
		}
	}
}
