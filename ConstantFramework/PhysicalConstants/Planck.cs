using System;

using ConstantFramework.SI;

namespace ConstantFramework.PhysicalConstants
{
	public struct Planck
	{
		//Variables
		static float planckConstant = Kilogram.Constant * (6.63f * (float)Math.Pow(10, -34));

		//Properties
		public static float Constant
		{
			get
			{
				return planckConstant;
			}
		}
		public static float ReducedConstant
		{
			get
			{
				return planckConstant / (2f * 3.14f);
			}
		}
		public static float Length
		{
			get
			{
				return (float)Math.Sqrt((ReducedConstant * Gravitational.Constant) / Math.Pow(SpeedOfLight.Constant, 3));
			}
		}
		public static float Mass
		{
			get
			{
				return (float)Math.Sqrt((ReducedConstant * SpeedOfLight.Constant) / Gravitational.Constant);
			}
		}
		public static float Time
		{
			get
			{
				return Length / SpeedOfLight.Constant;
			}
		}
		public static float Charge
		{
			get
			{
				return (float)Math.Sqrt(4f * 3.14f * Electric.Constant * ReducedConstant * SpeedOfLight.Constant);
			}
		}
		public static float Temperature
		{
			get
			{
				return (Mass * (float)Math.Pow(SpeedOfLight.Constant, 2)) / Boltzmann.Constant;
			}
		}
	}
}
