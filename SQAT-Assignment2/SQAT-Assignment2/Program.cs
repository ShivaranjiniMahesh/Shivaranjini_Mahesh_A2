using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQAT_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            a.Begin();
            Console.ReadLine();
        }
        public void Begin()
        {
            
            Console.Write("Enter the length of the rectangle : ");
            int length = Convert.ToInt32(Console.ReadLine());
            if(length < 0)
            {
                Console.Write("Value not in range 0-50");
                Console.Write("Enter the length of the rectangle:");
                length = Convert.ToInt32(Console.ReadLine());
            
            }
            else if (length > 50)
            {
                Console.Write("Value not in range 0-50");
                Console.Write("Enter the length of the rectangle:");
                length = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the width of the rectangle : ");
            int width = Convert.ToInt32(Console.ReadLine());
            if (width < 0)
            {
                Console.Write("Value not in range 0-50");
                Console.Write("Enter the width of the rectangle:");
                width = Convert.ToInt32(Console.ReadLine());
            }
            else if (width > 50)
            {
                Console.Write("Value not in range 0-50");
                Console.Write("Enter the width of the rectangle:");
                width = Convert.ToInt32(Console.ReadLine());
            }

            Rectangle rect = new Rectangle(length,width);
            Console.WriteLine("Perimeter of rectangle is " + rect.GetPerimeter());
             Console.WriteLine("Area of rectangle is" + rect.GetArea());
            Console.WriteLine(" Rectangle of Length {0} and Width {1} will result in  Perimeter {2} and Area {3}  ", rect.GetLength(), rect.GetWidth(), rect.GetPerimeter(), rect.GetArea());
            Console.WriteLine("-------");

            Rectangle rect1 = new Rectangle(5,10);
            Console.WriteLine("Perimeter of rectangle is : " + rect1.GetPerimeter());
            Console.WriteLine("Area of rectangle is: " + rect1.GetArea());
            Console.WriteLine("Rectangle of Length {0} and Width {1} will result in  Perimeter {2} and Area {3} ", rect1.GetLength(), rect1.GetWidth(), rect1.GetPerimeter(), rect1.GetArea());
            Console.WriteLine("-------");

            Rectangle rect2 = new Rectangle( );
            Console.WriteLine("Perimeter of rectangle is : " + rect2.GetPerimeter());
            Console.WriteLine("Area of rectangle is: " + rect2.GetArea());
            Console.WriteLine("Rectangle of Length {0} and Width {1} will result in  Perimeter {2} and Area {3}  ", rect2.GetLength(), rect2.GetWidth(), rect2.GetPerimeter(), rect2.GetArea());







        }
    }
}
