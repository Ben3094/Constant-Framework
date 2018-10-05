using ConstantFramework.SI;

namespace ConstantFramework.PhysicalConstants
{
	public struct SpeedOfLight
	{
		//Variables
		static float speedConstant = 299792458f;

		//Properties
		public static float Constant
		{
			get
			{
				return speedConstant;
			}
		}
		public static float Normalised
		{
			get
			{
				return Second.Constant / speedConstant;
			}
		}
	}
}
