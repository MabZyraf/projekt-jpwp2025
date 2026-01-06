using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace jpwp_forms
{
    internal class Food
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Image PicF { get; set; }
        public bool Correct { get; set; }
        public Food(int x, int y, Image img, bool good)
        {
            X = x;
            Y = y;
            Width = 160;
            Height = 130;
            PicF = img;
            Correct = good;
        }
        public void Moving(int speed)
        {
            X -= speed; 
        }

    }
}
