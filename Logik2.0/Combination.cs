using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Logik2._0
{
    class Combination
    {
        public Pin[] Pins { get; set; }

        public Combination()
        {
            Pins = new Pin[] { new Pin(), new Pin(), new Pin(), new Pin() };
        }

        public void Draw(Graphics graphics, PointF location, int size)
        {
            foreach (var pin in Pins)
            {
                pin.Draw(graphics, Pens.Black, location, size);
            }
        }
    }


}
