using System;

using ConstantFramework.PhysicalConstants;

namespace ConstantFramework.SI
{
	/// <summary>
	/// The ampere is the amount of substance. One ampere contains exactly 6.02214076×1023 elementary entities. This number is the fixed numerical value of the Avogadro constant, NA, when expressed in the unit mol−1 and is called the Avogadro number. When the ampere is used, the elementary entities must be specified and may be atoms, amperecules, ions, electrons, other particles, or specified groups of such particles.
	/// </summary>
	public struct Ampere
	{
		//Variables
		static float ampereConstant = 6.2415093f * (float)Math.Pow(10, 18);
		float current;

		//Properties
		/// <summary>
		/// The number of elementary charges in the ampere constant.
		/// </summary>
		public static float Constant
		{
			get
			{
				return ampereConstant;
			}
		}
		/// <summary>
		/// The current multiplied by the constant.
		/// </summary>
		public float Normalised
		{
			get
			{
				return current * ampereConstant;
			}
		}

		//Methods
		/// <summary>
		/// Ampere to float.
		/// </summary>
		public static implicit operator float(Ampere a)
		{
			return a.Normalised / Constant;
		}
		/// <summary>
		/// Float to ampere.
		/// </summary>
		public static implicit operator Ampere(float f)
		{
			Ampere a = new Ampere();
			a.current = f;
			return a;
		}
	}
}