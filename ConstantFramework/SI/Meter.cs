using ConstantFramework.PhysicalConstants;

namespace ConstantFramework.SI
{
	/// <summary>
	/// The meter is the length of the path travelled by light in vacuum during a time interval of 1/299 792 458 of a second.
	/// </summary>
	public struct Meter
	{
		//Variables
		static float meterConstant = SpeedOfLight.Normalised * 299792458f;
		float length;

		//Properties
		/// <summary>
		/// The length of the meter constant.
		/// </summary>
		public static float Constant
		{
			get
			{
				return meterConstant;
			}
		}
		/// <summary>
		/// The length multiplied by the constant.
		/// </summary>
		public float Normalised
		{
			get
			{
				return length * meterConstant;
			}
		}

		//Methods
		/// <summary>
		/// Meters to float.
		/// </summary>
		public static implicit operator float(Meter m)
		{
			return m.Normalised / Constant;
		}
		/// <summary>
		/// Float to meters.
		/// </summary>
		public static implicit operator Meter(float f)
		{
			Meter m = new Meter();
			m.length = f;
			return m;
		}
	}
}