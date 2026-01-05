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
        public Avatar(int startX, int startY)
        {
            X = startX; // Np. 100
            Y = startY; // Np. 300
            Hearts = 3;  // Startujemy z 3 serduszkami
        }
        public void GoUp()
        {
            Y -= 100;
        }
        public void GoDown()
        {
            Y += 100;
        }
    }
}
