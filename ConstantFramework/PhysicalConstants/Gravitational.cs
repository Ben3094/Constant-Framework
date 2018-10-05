using System;

namespace ConstantFramework.PhysicalConstants
{
	public struct Gravitational
	{
		//Variables
		static float gravitationalConstant = 6.67f * (float)Math.Pow(10, 11);

		//Properties
		public static float Constant
		{
			get
			{
				return gravitationalConstant;
			}
		}
	}
}
