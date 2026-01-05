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
        public Image Obrazek { get; set; }
        public bool Correct { get; set; }
        public Food(int x, int y, Image img, bool good)
        {
            X = x;
            Y = y;
            Obrazek = img;
            Correct = good;
        }
        public void Moving(int speed)
        {
            X -= speed; 
        }

    }
}
