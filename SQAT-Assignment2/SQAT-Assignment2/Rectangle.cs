using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQAT_Assignment2
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int l, int w)
        {
            length = l;
            width = w;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int l)
        {
            length = l;
            if ((length <= 0) || (length >= 50))
            {
                throw new ArgumentException("length not in the range 0-50");
            }
            return length;
        }
            
        
          public int GetWidth()
        {
            return width; 
        }

        public  int SetWidth(int w)
        {
            width = w;
            if ((width <= 0) || (width >= 50))
            {
                throw new ArgumentException("width not in the range 0-50");
            }
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
