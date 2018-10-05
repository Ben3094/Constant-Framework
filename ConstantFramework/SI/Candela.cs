using System;

using ConstantFramework.PhysicalConstants;

namespace ConstantFramework.SI
{
	/// <summary>
	/// The candela is the luminous intensity, in a given direction, of a source that emits monochromatic radiation of frequency 540 x 1012 hertz and that has a radiant intensity in that direction of 1/683 watt per steradian.
	/// </summary>
	public struct Candela
	{
		//Variables
		static float candelaConstant = (float)Math.Pow(Meter.Constant, 2f);
		float intensity;

		//Properties
		/// <summary>
		/// The intensity of the candela constant.
		/// </summary>
		public static float Constant
		{
			get
			{
				return candelaConstant;
			}
		}
		/// <summary>
		/// The intensity multiplied by the constant.
		/// </summary>
		public float Normalised
		{
			get
			{
				return intensity * candelaConstant;
			}
		}

		//Methods
		/// <summary>
		/// Candela to float.
		/// </summary>
		public static implicit operator float(Candela cd)
		{
			return cd.Normalised / Constant;
		}
		/// <summary>
		/// Float to candela.
		/// </summary>
		public static implicit operator Candela(float f)
		{
			Candela cd = new Candela();
			cd.intensity = f;
			return cd;
		}
	}
}