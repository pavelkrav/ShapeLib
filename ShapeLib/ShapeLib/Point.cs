using ShapeLib.Extensions;
using System;

namespace ShapeLib
{
	public class Point
	{
		public double X { get; set; }
		public double Y { get; set; }

		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}

		public double DistanceTo(Point point)
		{
			return Math.Sqrt((point.X - X).P2() + (point.Y - Y).P2());
		}

		public override string ToString()
		{
			return $"({X}, {Y})";
		}
	}
}
