using ConstantFramework.SI;

namespace ConstantFramework.PhysicalConstants
{
	public struct Elementary
	{
		//Variables
		static float elementaryCharge = 1f / Ampere.Constant;

		//Properties
		public static float Charge
		{
			get
			{
				return elementaryCharge;
			}
		}
	}
}
