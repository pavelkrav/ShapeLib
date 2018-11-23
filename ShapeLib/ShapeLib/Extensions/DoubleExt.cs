using System;

namespace ShapeLib.Extensions
{
	public static class DoubleExt
	{
		public static double P(this double d, int pow)
		{
			return Math.Pow(d, pow);
		}

		public static double P2(this double d)
		{
			return d * d;
		}

		public static double Sr(this double d)
		{
			return Math.Sqrt(d);
		}

	}
}
