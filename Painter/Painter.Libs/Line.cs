using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter.Libs
{
	public class Line : Shape
	{
		public Line(Point start, Point end, Color color) : base(start, end, color)
		{
		}

		public override void Draw(Graphics g)
		{
			Pen pen = new Pen(Color, LineWidth);
			g.DrawLine(pen, StartPoint, EndPoint);
		}

	}
}
