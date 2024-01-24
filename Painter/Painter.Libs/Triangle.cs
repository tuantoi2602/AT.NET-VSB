using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter.Libs
{
	public class Triangle : Shape
	{
		public Triangle(Point start, Point end, Color color) : base(start, end, color)
		{
		}

		public override void Draw(Graphics g)
		{
			Pen pen = new Pen(Color, LineWidth);
			var points = new PointF[4];
			int x1 = StartPoint.X > EndPoint.X ? (EndPoint.X - StartPoint.X) / 2 + StartPoint.X : (StartPoint.X - EndPoint.X) / 2 + EndPoint.X;
			int y1 = StartPoint.Y;
			points[0] = new PointF(x1, y1);
			points[3] = new PointF(x1, y1);

			int x2 = StartPoint.X > EndPoint.X ? StartPoint.X : EndPoint.X;
			int y2 = StartPoint.Y > EndPoint.Y ? EndPoint.Y : EndPoint.Y;
			points[1] = new PointF(x2, y2);

			int x3 = StartPoint.X > EndPoint.X ? EndPoint.X : StartPoint.X;
			int y3 = StartPoint.Y > EndPoint.Y ? EndPoint.Y : EndPoint.Y;
			points[2] = new PointF(x3, y3);
			g.DrawLines(pen, points);
		}
	}
}
