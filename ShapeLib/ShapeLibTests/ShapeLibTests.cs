using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLib;

namespace ShapeLibTests
{
	[TestClass]
	public class ShapeLibTests
	{
		[TestMethod]
		public void CircleArea_4radius()
		{
			double radius = 4.0;
			double expected = 50.26548;

			Circle c = new Circle(radius);
			double area = c.Area();

			Assert.AreEqual(expected, area, 0.00001);
		}

		[TestMethod]
		public void TriangleArea_3_4_5_sides()
		{
			double s1 = 3.0, s2 = 4.0, s3 = 5.0;
			double expected = 6.0;

			Triangle t = new Triangle(s1, s2, s3);
			double area = t.Area();

			Assert.AreEqual(expected, area);
		}

		[TestMethod]
		public void TriangleIsRight_3_4_5_sides()
		{
			double s1 = 3.0, s2 = 4.0, s3 = 5.0;
			bool expected = true;

			Triangle t = new Triangle(s1, s2, s3);
			bool right = t.IsRight();

			Assert.AreEqual(expected, right);
		}

		[TestMethod]
		public void ShapeArea_7_6_3_sides_triangle()
		{
			double s1 = 7.0, s2 = 6.0, s3 = 3.0;
			double expected = 8.9442719;

			Shape s = new Triangle(s1, s2, s3);
			double area = s.Area();

			Assert.AreEqual(expected, area, 0.0000001);
		}
	}
}
