using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.Testing.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLength, inputWidth;
            int userInput = 0;
            do
            {
                Console.WriteLine("Please enter the length of the rectangle");

            } while (!int.TryParse(Console.ReadLine(), out inputLength) || inputLength <= 0);

            do
            {
                Console.WriteLine("Please enter the width of the rectangle");

            } while (!int.TryParse(Console.ReadLine(), out inputWidth) || inputWidth <= 0);


            Rectangle rectangle = new Rectangle(inputLength, inputWidth);

            do
            {
                Console.WriteLine("Please choose an option from the menu.\nMenu\n1. Get Rectangle Length\n2. Change Rectangle Length\n3. Get Rectangle Width\n" +
                "4. Change Rectangle Width\n5. Get Rectangle Perimeter\n6. Get Rectangle Area\n7. Exit");
                try
                {
                    int.TryParse(Console.ReadLine(), out userInput);

                    switch (userInput)
                    {
                        case 1:
                            int currentLength = rectangle.GetLength();
                            Console.WriteLine("Length of the rectangle is: {0}", currentLength);
                            break;
                        case 2:
                            int changedLength;
                            do
                            {
                                Console.WriteLine("Please input a new length for the rectangle");

                            } while (!int.TryParse(Console.ReadLine(), out changedLength) || changedLength <= 0);

                            rectangle.SetLength(changedLength);
                            Console.WriteLine("Length of the rectangle is changed and new length is: {0}", changedLength);
                            break;
                        case 3:
                            int currentWidth = rectangle.GetWidth();
                            Console.WriteLine("Width of the rectangle is: {0}", currentWidth);
                            break;
                        case 4:
                            int changedWidth;
                            do
                            {
                                Console.WriteLine("Please input a new width for the rectangle");

                            } while (!int.TryParse(Console.ReadLine(), out changedWidth) || changedWidth <= 0);

                            rectangle.SetWidth(changedWidth);
                            Console.WriteLine("Width of the rectangle is changed and new Width is: {0}", changedWidth);
                            break;
                        case 5:
                            int perimeter = rectangle.GetPerimeter();
                            Console.WriteLine("Perimeter of the rectangle is: {0}", perimeter);
                            break;
                        case 6:
                            int area = rectangle.GetArea();
                            Console.WriteLine("Area of the rectangle is: {0}", area);
                            break;
                        case 7:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please enter numbers between 1 and 7 only");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong with the user input. Please try again.");
                }


            } while (!(userInput == 7));
        }
    }
}
