namespace ConstantFramework.PhysicalConstants
{
	public struct Boltzmann
	{
		//Variables
		static float boltzmannConstant = IdealGas.Constant / Avogrado.Constant;

		//Properties
		public static float Constant
		{
			get
			{
				return boltzmannConstant;
			}
		}
	}
}
