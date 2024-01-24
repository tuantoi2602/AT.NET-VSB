using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter.Libs.v2
{
	public class Star : Shape
	{
		public Star(Point start, Point end, Color color) : base(start, end, color)
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

			int centerX = x + (w / 2);
			int centerY = y + (h / 2);
            int size = Convert.ToInt32((h < w ? h : w) * 0.5f);
            PointF[] pointsOfStar = Calculate5StarPoints(new PointF(centerX, centerY), size);
            g.DrawLines(pen, pointsOfStar);
        }

        // Refer: https://www.daniweb.com/programming/software-development/code/360165/draw-any-star-you-want
        private PointF[] Calculate5StarPoints(PointF Orig, float outerradius)
        {
            float innerradius = outerradius * 0.4f;
            // Define some variables to avoid as much calculations as possible
            // conversions to radians
            double Ang36 = Math.PI / 5.0;   // 36° x PI/180
            double Ang72 = 2.0 * Ang36;     // 72° x PI/180
            // some sine and cosine values we need
            float Sin36 = (float)Math.Sin(Ang36);
            float Sin72 = (float)Math.Sin(Ang72);
            float Cos36 = (float)Math.Cos(Ang36);
            float Cos72 = (float)Math.Cos(Ang72);
            // Fill array with 10 origin points
            PointF[] pnts = { Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig};
            pnts[0].Y -= outerradius;  // top off the star, or on a clock this is 12:00 or 0:00 hours
            pnts[1].X += innerradius * Sin36; pnts[1].Y -= innerradius * Cos36; // 0:06 hours
            pnts[2].X += outerradius * Sin72; pnts[2].Y -= outerradius * Cos72; // 0:12 hours
            pnts[3].X += innerradius * Sin72; pnts[3].Y += innerradius * Cos72; // 0:18
            pnts[4].X += outerradius * Sin36; pnts[4].Y += outerradius * Cos36; // 0:24 
            // Phew! Glad I got that trig working.
            pnts[5].Y += innerradius;
            // I use the symmetry of the star figure here
            pnts[6].X += pnts[6].X - pnts[4].X; pnts[6].Y = pnts[4].Y;  // mirror point
            pnts[7].X += pnts[7].X - pnts[3].X; pnts[7].Y = pnts[3].Y;  // mirror point
            pnts[8].X += pnts[8].X - pnts[2].X; pnts[8].Y = pnts[2].Y;  // mirror point
            pnts[9].X += pnts[9].X - pnts[1].X; pnts[9].Y = pnts[1].Y;  // mirror point
            pnts[10].Y -= outerradius;
            return pnts;
        }
    }
}
