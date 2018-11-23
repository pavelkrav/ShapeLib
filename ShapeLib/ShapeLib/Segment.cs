namespace ShapeLib
{
	public class Segment
	{
		public Point P1 { get; set; }
		public Point P2 { get; set; }

		public Segment(Point p1, Point p2)
		{
			P1 = p1;
			P2 = p2;
		}

		public double Length()
		{
			return P1.DistanceTo(P2);
		}
	}
}
