using System;
using System.Collections.Generic;

namespace ShapeLib
{
	public class Polygon : Shape
	{
		public List<Point> Vertices { get; set; }

		internal Polygon()
		{
			Vertices = new List<Point>();
		}

		/// <summary>
		/// non-safe constructor
		/// </summary>
		public Polygon(List<Point> vertices)
		{
			Vertices = vertices;
		}

		/// <summary>
		/// safe constructor - not implemented (:
		/// </summary>
		public Polygon(List<Segment> edges)
		{
			throw new NotImplementedException();
		}

		public override double Area()
		{
			double result = 0.0;
			for (int i = 0; i < Vertices.Count; i++)
			{
				int ip = i == Vertices.Count - 1 ? 0 : i + 1;
				int im = i == 0 ? Vertices.Count - 1 : i - 1;
				result += Vertices[i].X * (Vertices[ip].Y - Vertices[im].Y);
			}
			return 0.5 * Math.Abs(result);
		}
	}
}
