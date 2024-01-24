using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter.Libs.v2
{
	public abstract class Shape
	{
		public float LineWidth { get => 3; }
		public Point StartPoint { get; set; }
		public Point EndPoint { get; set; }

		public Color Color { get; set; }
		public Shape(Point start, Point end, Color color)
		{
			this.StartPoint = start;
			this.EndPoint = end;
			this.Color = color;
		}

		public virtual void Draw(Graphics g)
		{
		}
	}
}
