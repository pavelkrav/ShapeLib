using ShapeLib.Extensions;
using System;
using System.Collections.Generic;

namespace ShapeLib
{
	public class Circle : Shape
	{
		public Point Center { get; set; }
		public double Radius { get; set; }

		public Circle(double radius)
		{
			Center = new Point(0, 0);
			Radius = radius;
		}

		public Circle(Point center, double radius)
		{
			Center = center;
			Radius = radius;
		}

		public override double Area()
		{
			return Math.PI * Radius * Radius;
		}

		public List<Point> Intersection(Circle circle)
		{
			List<Point> result = new List<Point>();

			double x1 = Center.X, y1 = Center.Y;
			double x2 = circle.Center.X, y2 = circle.Center.Y;
			double r1 = Radius, r2 = circle.Radius;
			double x0 = x2 - x1, y0 = y2 - y1;

			double c = (r2.P2() - x0.P2() - y0.P2() - r1.P2()) / -2;

			if (x0 != 0)
			{
				double a = y0.P2() + x0.P2();
				double b = -2 * y0 * c;
				double e = c.P2() - r1.P2() * x0.P2();

				double D = b.P2() - 4 * a * e;
				if (D < 0)
					return result;
				double y = (-b + D.Sr()) / (2 * a);
				double x = (c - y * y0) / x0;
				result.Add(new Point(x, y));
				if (D == 0)
					return result;
				y = (-b - D.Sr()) / (2 * a);
				x = (c - y * y0) / x0;
				result.Add(new Point(x, y));
				return result;
			}
			else
			{
				double y = c / y0;
				double D = r1.P2() - c.P2() / y0.P2();
				if (D < 0)
					return result;
				result.Add(new Point(D.Sr(), y));
				if (D == 0)
					return result;
				result.Add(new Point(-(D.Sr()), y));
				return result;
			}
		}
	}
}
