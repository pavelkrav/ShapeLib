using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeLib
{
	public class Triangle : Polygon
	{
		// constructor for trial assignment
		public Triangle(double side1, double side2, double side3) : base()
		{
			Point p1 = new Point(0, 0);
			Point p2 = new Point(side1, 0);

			Circle c1 = new Circle(p1, side2);
			Circle c2 = new Circle(p2, side3);

			var inters = c1.Intersection(c2);
			if (inters.Count == 0)
				throw new Exception("Wrong triangle sides.");
			Point p3 = inters.First();

			Vertices.Add(p1);
			Vertices.Add(p2);
			Vertices.Add(p3);
		}

		public Triangle(Point p1, Point p2, Point p3) : base(new List<Point>() { p1, p2, p3 }) {; }

		public Triangle(List<Point> vertices) : base(vertices)
		{
			if (vertices.Count != 3)
				throw new Exception($"Wrong vertices count in triangle constructor ({vertices.Count}).");
		}

		public bool IsRight()
		{
			List<Line> lines = new List<Line>();
			for (int i = 0; i < Vertices.Count; i++)
			{
				int ip = i == Vertices.Count - 1 ? 0 : i + 1;
				lines.Add(new Line(Vertices[i], Vertices[ip]));
			}
			foreach (var l in lines)
			{
				foreach (var il in lines.Where(t => t != l))
				{
					if (l.CosAngleTo(il) == 0)
						return true;
				}
			}
			return false;
		}
	}
}
