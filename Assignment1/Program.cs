using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("INPUT");
            Console.Write("Please insert the length of your rectangle:");
            int length = Int32.Parse(Console.ReadLine());
            Console.Write("Please insert the width of your rectangle:");
            int width = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "OUTPUT");
            Rectangle rectangle = new Rectangle(length, width);
            Console.WriteLine(rectangle.Width);
            Console.WriteLine(rectangle.Length);
            Console.WriteLine("====");
            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine(rectangle.GetPerimeter());

            


            Console.ReadKey();


        }
    }
}
