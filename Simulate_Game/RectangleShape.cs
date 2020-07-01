using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulate_Game
{
   public  class RectangleShape
    {
        public Point Location { get; set; }
        public Color Color { get; set; }
        public bool isSelected { get; set; }
        public RectangleShape(Point Location, Color Color)
        {
            this.Location = Location;
            this.Color = Color;
            isSelected = false;
        }
        public void Draw(Graphics g){}
        public void Clicked(Point Lokacija) { }
    }
}
