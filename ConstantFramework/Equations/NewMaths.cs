using System;

using ConstantFramework.PhysicalConstants;
using ConstantFramework.SI;

namespace ConstantFramework.Equations
{
	public static class NewMaths
	{
		/// <summary>
		/// v = s / t
		/// </summary>
		public static float AverageVelocity(float speed, Second time)
		{
			return speed / time.Normalised;
		}
		/// <summary>
		/// a = v / t
		/// </summary>
		public static float AverageAcceleration(float velocity, Second time)
		{
			return velocity / time.Normalised;
		}
		/// <summary>
		/// v = v0 + (a * t)
		/// </summary>
		public static float Velocity(float currentVelocity, float acceleration, Second time)
		{
			return currentVelocity + (acceleration * time.Normalised);
		}
		/// <summary>
		/// f = m * a
		/// </summary>
		public static float Force(Kilogram mass, float acceleration)
		{
			return mass.Normalised * acceleration;
		}
		/// <summary>
		/// w = m * a
		/// </summary>
		public static float Weight(Kilogram mass, float gravity)
		{
			return mass.Normalised * gravity;
		}
		/// <summary>
		/// a = (v^2) / r
		/// </summary>
		public static float CentripetalAcceleration(float velocity, Meter radius)
		{
			return (float)Math.Pow(velocity, 2) / radius.Normalised;
		}
		/// <summary>
		/// p = m / v
		/// </summary>
		public static float Momentum(Kilogram mass, float velocity)
		{
			return mass.Normalised / velocity;
		}
		/// <summary>
		/// j = f * t
		/// </summary>
		public static float Impulse(float force, Second time)
		{
			return force * time.Normalised;
		}
		/// <summary>
		/// k = (1/2) * m * (v^2)
		/// </summary>
		public static float KineticEnergy(Kilogram mass, float velocity)
		{
			return (1f / 2f) * mass.Normalised * (float)Math.Pow(velocity, 2);
		}
		/// <summary>
		/// k = (p^2) / (2 * m)
		/// </summary>
		public static float KineticEnergy(float momentum, Kilogram mass)
		{
			return (float)Math.Pow(momentum, 2) / (2f * mass.Normalised);
		}
		/// <summary>
		/// e = o / i
		/// </summary>
		public static float Efficiency(float energyIn, float workOut)
		{
			return workOut / energyIn;
		}
		/// <summary>
		/// p = w / t
		/// </summary>
		public static float Power(float work, Second time)
		{
			return work / time.Normalised;
		}
		/// <summary>
		/// p = f * v
		/// </summary>
		public static float PowerVelocity(float force, float velocity)
		{
			return force * velocity;
		}
		/// <summary>
		/// v = (w / t) * r
		/// </summary>
		public static float AngularVelocity(float angle, Second time, Meter radius)
		{
			return (angle / time.Normalised) * radius.Normalised;
		}
		/// <summary>
		/// a = ((w / t) * r) - (w^2 * r)
		/// </summary>
		public static float AngularAcceleration(float angularVelocity, Second time, Meter radius)
		{
			return ((angularVelocity/ time.Normalised) * radius.Normalised) - ((float)Math.Pow(angularVelocity, 2) * radius.Normalised);
		}
		/// <summary>
		/// w = w0 + (a * t)
		/// </summary>
		public static float AngularRotation(float angularVelocity, float acceleration, Second time)
		{
			return angularVelocity  + (acceleration * time.Normalised);
		}
		/// <summary>
		/// t = f * r
		/// </summary>
		public static float Torque(float force, Meter radius)
		{
			return force * radius.Normalised;
		}
		/// <summary>
		/// i = sum(m,r^2)
		/// </summary>
		public static float MomentOfInertia(Kilogram mass, Meter radius)
		{
			return mass + (float)Math.Pow(radius.Normalised, 2);
		}
		/// <summary>
		/// p = t * w
		/// </summary>
		public static float RotationalPower(float torque, float angularVelocity)
		{
			return torque * angularVelocity;
		}
		/// <summary>
		/// k = (1/2) * i * (w^2)
		/// </summary>
		public static float RotationalKineticEnergy(float inertia, float angularVelocity)
		{
			return (1f / 2f) * inertia * (float)Math.Pow(angularVelocity, 2);
		}
		/// <summary>
		/// l = i * w
		/// </summary>
		public static float AngularMomentum(float inertia, float angularVelocity)
		{
			return inertia * angularVelocity;
		}
		/// <summary>
		/// f = -((g * m1 * m2) / (r^2)) * r
		/// </summary>
		public static float UniversalGravitation(Kilogram mass1, Kilogram mass2, Meter radius)
		{
			return -((Gravitational.Constant * mass1.Normalised * mass2.Normalised) / (float)Math.Pow(radius.Normalised, 2)) * radius.Normalised;
		}
		/// <summary>
		/// f = -((g * m) / (r^2)) * r
		/// </summary>
		public static float GravitationalField(Kilogram mass, Meter radius)
		{
			return -((Gravitational.Constant * mass.Normalised) / (float)Math.Pow(radius.Normalised, 2)) * radius.Normalised;
		}
		/// <summary>
		/// f = -((g * m1 * m2) / r)
		/// </summary>
		public static float GravitationalPotential(Kilogram mass1, Kilogram mass2, Meter radius)
		{
			return -((Gravitational.Constant * mass1.Normalised * mass2.Normalised) / radius.Normalised);
		}
		/// <summary>
		/// f = -((g * m) / r)
		/// </summary>
		public static float GravitationalPotential(Kilogram mass, Meter radius)
		{
			return -((Gravitational.Constant * mass.Normalised) / radius.Normalised);
		}
		/// <summary>
		/// v = sqrt((g * m) / r)
		/// </summary>
		public static float OrbitalVelocity(Kilogram mass, Meter radius)
		{
			return (float)Math.Sqrt((Gravitational.Constant * mass.Normalised) / radius.Normalised);
		}
		/// <summary>
		/// v = sqrt((2 * g * m) / r)
		/// </summary>
		public static float EscapeVelocity(Kilogram mass, Meter radius)
		{
			if (radius == 0)
			{
				radius = 1f;
			}
			return (float)Math.Sqrt((2f * Gravitational.Constant * mass.Normalised) / radius.Normalised);
		}
		/// <summary>
		/// t = 2 * pi * sqrt(m / k)
		/// </summary>
		public static float SimpleHarmonicOscillation(Kilogram mass, float springConstant)
		{
			return 2f * 3.14f * (float)Math.Sqrt(mass.Normalised / springConstant);
		}
		/// <summary>
		/// t = 2 * pi * sqrt(l / g)
		/// </summary>
		public static float PendulumOscillation(Meter length, float gravity)
		{
			return 2f * 3.14f * (float)Math.Sqrt(length.Normalised / gravity);
		}
		/// <summary>
		/// f = 1 / t
		/// </summary>
		public static float OscillationFrequency(float oscillation)
		{
			return 1f / oscillation;
		}
		/// <summary>
		/// w = 2 * pi * f
		/// </summary>
		public static float OscillationAngularFrequency(float oscillationFrequency)
		{
			return 2f * 3.14f * oscillationFrequency;
		}
		/// <summary>
		/// d = m / v
		/// </summary>
		public static float Density(Kilogram mass, float volume)
		{
			return mass.Normalised / volume;
		}
		/// <summary>
		/// p = f / a
		/// </summary>
		public static float Pressure(float force, float area)
		{
			return force / area;
		}
		/// <summary>
		/// p = p0 + (d * g * h)
		/// </summary>
		public static float FluidPressure(float currentPressure, float fluidDensity, float gravity, float depth)
		{
			return currentPressure + (fluidDensity * gravity * depth);
		}
		/// <summary>
		/// b = d * g * v
		/// </summary>
		public static float Buoyancy(float fluidDensity, float gravity, float displacedVolume)
		{
			return fluidDensity * gravity * displacedVolume;
		}
		//-----
		// More in here?
		//-----
		/// <summary>
		/// m = v / c
		/// </summary>
		public static float Mach(float velocity, float localLimit)
		{
			return velocity / localLimit;
		}
		/// <summary>
		/// n = c / v
		/// </summary>
		public static float Refraction(float localLimit)
		{
			return SpeedOfLight.Constant / localLimit;
		}
	}
}
