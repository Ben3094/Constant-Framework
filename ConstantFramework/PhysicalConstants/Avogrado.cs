using System;

namespace ConstantFramework.PhysicalConstants
{
	public struct Avogrado
	{
		//Variables
		static float avogradoConstant = 6.02214076f * (float)Math.Pow(10, 23);

		//Properties
		public static float Constant
		{
			get
			{
				return avogradoConstant;
			}
		}
	}
}
