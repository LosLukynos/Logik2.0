using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Logik2._0
{
    public class Pin
    {
        public PinState State { get; set; }

        public Pin()
        {
            State = PinState.Empty;
        }

        public void Draw(Graphics graphics, Pen pen, PointF point, int size)
        {
            Brush brush = new SolidBrush(GetColor());
            graphics.FillEllipse(brush, point.X, point.Y, size, size);
            graphics.DrawEllipse(pen, point.X, point.Y, size, size);
        }
        private Color GetColor()
        {
            switch (State)
            {
                case PinState.Color1:
                    return Color.Red;

                case PinState.Color2:
                    return Color.Blue;

                case PinState.Color3:
                    return Color.Yellow;

                case PinState.Color4:
                    return Color.Orange;

                case PinState.Color5:
                    return Color.Green;


                case PinState.Color6:
                    return Color.LimeGreen;

                default:
                    return Color.White;

            }
        }
        public enum PinState
        {
            Empty,
            Color1,
            Color2,
            Color3,
            Color4,
            Color5,
            Color6
        }
    }
}