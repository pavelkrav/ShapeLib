using ShapeLib.Extensions;
using System;

namespace ShapeLib
{
	public class Line
	{
		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }

		public Line(double a, double b, double c)
		{
			A = a;
			B = b;
			C = c;
		}

		public Line(Point p1, Point p2)
		{
			A = p1.Y - p2.Y;
			B = p2.X - p1.X;
			C = p1.X * p2.Y - p2.X * p1.Y;
		}

		public Line(Segment s) : this(s.P1, s.P2) {; }

		public double CosAngleTo(Line line)
		{
			double cos = (A * line.A + B * line.B) / ((A.P2() + B.P2()).Sr() * (line.A.P2() + line.B.P2()).Sr());
			return cos;
		}

		public double AngleTo(Line line)
		{
			double cos = CosAngleTo(line);
			return Math.Acos(cos);
		}
	}
}
