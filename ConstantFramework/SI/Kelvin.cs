namespace ConstantFramework.SI
{
	/// <summary>
	/// The kelvin, unit of thermodynamic temperature, is the fraction 1/273.16 of the thermodynamic temperature of the triple point of water.
	/// </summary>
	public struct Kelvin
	{
		//Variables
		static float kelvinConstant = 1f;
		float temperature;

		//Properties
		/// <summary>
		/// The strength of the kelvin constant.
		/// </summary>
		public static float Constant
		{
			get
			{
				return kelvinConstant;
			}
		}
		/// <summary>
		/// The temperature multiplied by the constant.
		/// </summary>
		public float Normalised
		{
			get
			{
				return temperature * kelvinConstant;
			}
		}

		//Methods
		/// <summary>
		/// Kelvins to float.
		/// </summary>
		public static implicit operator float(Kelvin t)
		{
			return t.Normalised / Constant;
		}
		/// <summary>
		/// Float to kelvins.
		/// </summary>
		public static implicit operator Kelvin(float f)
		{
			Kelvin t = new Kelvin();
			t.temperature = f;
			return t;
		}
	}
}