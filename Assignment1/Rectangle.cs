using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Rectangle
    {
        private int length;
        private int width;

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }
                   
        public Rectangle()
        {
            Length = 1;
            Width = 1;
        }
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
               
        public int GetLength()
        {
            return Length;
        }
        
        public int GetWidth()
        {
            return Width;
        }

        public int SetLength(int Length)
        {
            
            Length = length;
            return Length;
        }


        public int SetWidth(int width)
        {
            Width = width;
            return Width;
        }

        public int GetPerimeter()
        {
            return (Length * Width)*2;
        }
        
        public int GetArea()
        {
            return Length * Width;
        }
    }
}
