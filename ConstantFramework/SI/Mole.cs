using System;

using ConstantFramework.PhysicalConstants;

namespace ConstantFramework.SI
{
	/// <summary>
	/// The mole is the amount of substance. One mole contains exactly 6.02214076×1023 elementary entities. This number is the fixed numerical value of the Avogadro constant, NA, when expressed in the unit mol−1 and is called the Avogadro number. When the mole is used, the elementary entities must be specified and may be atoms, molecules, ions, electrons, other particles, or specified groups of such particles.
	/// </summary>
	public struct Mole
	{
		//Variables
		static float moleConstant = Avogrado.Constant;
		float amount;

		//Properties
		/// <summary>
		/// The number of elementary entities in the mole constant.
		/// </summary>
		public static float Constant
		{
			get
			{
				return moleConstant;
			}
		}
		/// <summary>
		/// The amount multiplied by the constant.
		/// </summary>
		public float Normalised
		{
			get
			{
				return amount * moleConstant;
			}
		}

		//Methods
		/// <summary>
		/// Mole to float.
		/// </summary>
		public static implicit operator float(Mole mol)
		{
			return mol.Normalised / Constant;
		}
		/// <summary>
		/// Float to mole.
		/// </summary>
		public static implicit operator Mole(float f)
		{
			Mole mol = new Mole();
			mol.amount = f;
			return mol;
		}
	}
}