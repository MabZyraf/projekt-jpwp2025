using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpwp_forms
{
    internal class Avatar
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Hearts { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Image Pic { get; set; }
        public Avatar(int startX, int startY)
        {
            X = startX; // Np. 100
            Y = startY; // Np. 300
            Hearts = 3;  // Startujemy z 3 serduszkami
            Width = 160;
            Height = 130;
            Pic = Properties.Resources.duck;
        }
        public void GoUp()
        {
            Y -= 190;
        }
        public void GoDown()
        {
            Y += 190;
        }
    }
}
