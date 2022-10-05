using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {
        private int length;
        private int width;

        //default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        //non-default constructor
        public Rectangle(int rLength, int rWidth)
        {
            length = rLength;
            width = rWidth;
        }
        public int GetCurrentLength()
        {
            return length;
        }
        public int SetNewLength(int rLength)
        {
            length = rLength;
            return length;
        }
        public int GetCurrentWidth()
        {
            return width;
        }
        public int SetNewWidth(int rWidth)
        {
            width = rWidth;
            return width;
        }
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }
        public int GetArea()
        {
            return length * width;
        }
    }
}
