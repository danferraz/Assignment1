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
            int length = 1;
            int width = 1;
            string lengthInput = string.Empty;      
            string widthInput = string.Empty;
            Rectangle rectangle = new Rectangle(length, width);

            int userInput = 0;
            do
            {
                userInput = DisplayMenu();
                int caseSwitch = userInput;

                switch (caseSwitch)
                {
                    case 1:

                        Console.WriteLine("Rectangle Length: " + rectangle.GetLength());
                        break;
                    case 2:
                        //change lenght
                        do
                        {
                            Console.Write("Please insert the new length of your rectangle: ");
                            lengthInput = Console.ReadLine();
                        } while (!int.TryParse(lengthInput, out length) || length < 1);
                        rectangle.SetLength(length);
                        break;
                    case 3:
                        Console.WriteLine("Rectangle Width: " + rectangle.GetWidth());
                        break;
                    case 4:
                        do
                        {
                            Console.Write("Please insert the width of your rectangle: ");
                            widthInput = Console.ReadLine();
                        } while (!int.TryParse(widthInput, out width) || width < 1);
                        rectangle.SetWidth(width);
                        break;
                    case 5:
                        Console.WriteLine("Rectangle Perimeter: " + rectangle.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
                        break;
                    default:
                        //exit
                        userInput = 7;
                        break;
                }                
            } while (userInput != 7);
            
            //Console.ReadKey();
            
        }

        public static int DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Rectangle MENU");
            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
    }
}
