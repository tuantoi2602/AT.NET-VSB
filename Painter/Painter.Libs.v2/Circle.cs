using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter.Libs.v2
{
	public class Circle : Shape
	{
		public Circle(Point start, Point end, Color color) : base(start, end, color)
		{
		}
		public override void Draw(Graphics g)
		{
			Pen pen = new Pen(Color, LineWidth);
			int h = Math.Abs(EndPoint.Y - StartPoint.Y);
			int w = Math.Abs(EndPoint.X - StartPoint.X);
			int x = StartPoint.X > EndPoint.X ? EndPoint.X : StartPoint.X;
			int y = StartPoint.Y > EndPoint.Y ? EndPoint.Y : StartPoint.Y;
			RectangleF rec = new RectangleF(x, y, w, h);
			g.DrawEllipse(pen, rec);
		}
	}
}
