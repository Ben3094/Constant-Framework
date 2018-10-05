namespace ConstantFramework.SI
{
	/// <summary>
	/// The second is the duration of 9 192 631 770 periods of the radiation corresponding to the transition between the two hyperfine levels of the ground state of the caesium 133 atom.
	/// </summary>
	public struct Second
	{
		//Variables
		static float secondConstant = 1f;
		float time;

		//Properties
		/// <summary>
		/// The rate of the Second constant.
		/// </summary>
		public static float Constant
		{
			get
			{
				return secondConstant;
			}
		}
		/// <summary>
		/// The time multiplied by the constant.
		/// </summary>
		public float Normalised
		{
			get
			{
				return time * secondConstant;
			}
		}

		//Methods
		/// <summary>
		/// Seconds to float.
		/// </summary>
		public static implicit operator float(Second s)
		{
			return s.Normalised / Constant;
		}
		/// <summary>
		/// Float to seconds.
		/// </summary>
		public static implicit operator Second(float f)
		{
			Second s = new Second();
			s.time = f;
			return s;
		}
	}
}