﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Triangle : Figure
    {
        public int Height { get; set; }
        public int Bottom { get; set; }

        public override void Draw(Graphics gr)
        {
            PointF point1 = new PointF(Position.X, Position.Y);
            PointF point2 = new PointF(Position.X + Bottom / 2, Position.Y - Height);
            PointF point3 = new PointF(Position.X + Bottom, Position.Y);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3
             };

            gr.DrawPolygon(new Pen(Color), curvePoints);

            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }

        public override double GetArea()
        {
            return 0.5 * Height * Bottom;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Bottom / 2), (int)(Position.Y - Height / 2));
        }
    }
}
