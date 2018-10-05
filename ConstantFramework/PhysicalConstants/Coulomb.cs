using System;

namespace ConstantFramework.PhysicalConstants
{
	public struct Coulomb
	{
		//Variables
		static float coulombConstant = 1f / (4f * 3.14f * Electric.Constant);

		//Properties
		public static float Constant
		{
			get
			{
				return coulombConstant;
			}
		}
	}
}
