namespace ConstantFramework.SI
{
	/// <summary>
	/// The kilogram is the unit of mass; it is equal to the mass of the international prototype of the kilogram.
	/// </summary>
	public struct Kilogram
	{
		//Variables
		static float kilogramConstant = 1f;
		float mass;

		//Properties
		/// <summary>
		/// The mass of the kilogram constant.
		/// </summary>
		public static float Constant
		{
			get
			{
				return kilogramConstant;
			}
		}
		/// <summary>
		/// The mass multiplied by the constant.
		/// </summary>
		public float Normalised
		{
			get
			{
				return mass * kilogramConstant;
			}
		}

		//Methods
		/// <summary>
		/// Kilograms to float.
		/// </summary>
		public static implicit operator float(Kilogram kg)
		{
			return kg.Normalised / Constant;
		}
		/// <summary>
		/// Float to kilograms.
		/// </summary>
		public static implicit operator Kilogram(float f)
		{
			Kilogram kg = new Kilogram();
			kg.mass = f;
			return kg;
		}
	}
}