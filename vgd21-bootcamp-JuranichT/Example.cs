using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_JuranichT
{
    class Example
    {
        Example(double len, double hgt)
        {
            length = len;
            height = hgt;
        }

        public double Area()
        {
            return length * height;
        }


        private double length;
        private double height;
    }
}
