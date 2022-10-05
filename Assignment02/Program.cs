using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rLength, rWidth;
            var endOptions = true;
            bool lengthInput = false;
            bool widthInput = false;
            Rectangle rectangle = new Rectangle();

            do
            {
                Console.WriteLine("Please,enter rectangle length:-");
                rLength = int.Parse(Console.ReadLine());
                if (rLength <= 0)
                {
                    lengthInput = false;
                    Console.WriteLine("please enter a valid length again!");
                }
                else
                {
                    lengthInput = true;
                }
            } while (!lengthInput);

            do
            {
                Console.WriteLine("Please,enter rectangle width:-");
                rWidth = int.Parse(Console.ReadLine());
                if (rWidth <= 0)
                {
                    widthInput = false;
                    Console.WriteLine("please enter a valid width again!");
                }
                else
                {
                    widthInput = true;
                }
            } while (!widthInput);


            rectangle = new Rectangle(rLength, rWidth);

            do
            {
                Console.WriteLine("\n-------Select Options to get length & Width---------");
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Select your choice :");
                var usersChoice = Console.ReadLine();

                switch (usersChoice)
                {
                    case "1":
                        Console.WriteLine($"\nCurrent Rectangle Length is :{rectangle.GetCurrentLength()}");
                        break;
                    case "2":
                        bool lchoice = false;
                        do
                        {
                            Console.WriteLine("Please,Enter New Rectangle Length:-");
                            rLength = int.Parse(Console.ReadLine());
                            if (rLength < 1)
                            {
                                Console.WriteLine("please enter a new valid length again!");
                                lchoice = false;
                            }
                            else
                            {
                                rectangle.SetNewLength(rLength);
                                lchoice = true;
                            }
                        } while (!lchoice);

                        break;
                    case "3":
                        Console.WriteLine($"\nCurrent Rectangle Width is:{rectangle.GetCurrentWidth()}");
                        break;
                    case "4":
                        bool wchoice = false;
                        do
                        {
                            Console.WriteLine("Please,Enter New Rectangle Width:-");
                            rWidth = int.Parse(Console.ReadLine());
                            if (rWidth < 1)
                            {
                                wchoice = false;
                                Console.WriteLine("please enter a valid width again!");
                            }
                            else
                            {
                                rectangle.SetNewWidth(rWidth);
                                wchoice = true;
                            }
                        } while (!wchoice);

                        break;
                    case "5":
                        Console.WriteLine($"\nRectangle Perimeter is:{rectangle.GetPerimeter()}");
                        break;
                    case "6":
                        Console.WriteLine($"\nRectangle Area is:{rectangle.GetArea()}");
                        break;
                    case "7":
                        endOptions = false;
                        Console.WriteLine("\n Press enter to Close the System.");
                        break;
                    default:
                        Console.WriteLine("\n Wrong Input...!! Try again.");
                        break;
                }

            } while (endOptions);
            Console.ReadLine();
        }
    }
}
