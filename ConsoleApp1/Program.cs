using FigureLibrary;
using FigureLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuItem = -1;

            while (menuItem != 0)
            {
                Console.WriteLine("1. Create figure");
                Console.WriteLine("2. View all figures");
                Console.WriteLine("3. Check belong point to specified figure");
                Console.WriteLine("4. Special function of Rectangle and Square with specified number");
                Console.WriteLine("5. Special function of circle with specified number");
                Console.WriteLine("0. Exit");

                menuItem = Convert.ToInt32(Console.ReadLine());


                try
                {
                    switch (menuItem)
                    {
                        case 1:
                            CreateFigureMenu();
                            break;
                        case 2:
                            Console.WriteLine(ViewAll());
                            break;
                        case 3:
                            Console.WriteLine(CheckBelongPoint());
                            break;
                        case 4:
                            Console.WriteLine(SpecialFunctionsOfRectangleAndSquare());
                            break;
                        case 5:
                            Console.WriteLine($"{SpecialFanctionOfCircle()}");
                            break;
                        case 0:
                            Console.WriteLine("End of program");
                            break;
                        default:
                            Console.WriteLine("This menu item does not exist");
                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("Error: " + error.Message);
                }
            }
        }

        static string SpecialFunctionsOfRectangleAndSquare()
        {
            Console.Write("Enter number of figure: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string res = string.Empty;

            for (int i = 0; i < Service.figureList.Count; i++)
            {
                if (Service.figureList[i].Number == number)
                {
                    if (Service.figureList[i].GetType().Name == "Rectangle")
                    {
                        Rectangle rectangle = (Rectangle)Service.figureList[i];
                        res += $"{rectangle.VertexOfRectangleAndSquare()}\nSide: {rectangle.SideOfRectangleAndSquare()}\nDiagonal: {rectangle.DiagonalOfRectangleAndSquare()}";
                    }
                    else if (Service.figureList[i].GetType().Name == "Square")
                    {
                        Square square = (Square)Service.figureList[i];
                        res += $"{square.VertexOfRectangleAndSquare()}\nSide: {square.SideOfRectangleAndSquare()}\nDiagonal{square.DiagonalOfRectangleAndSquare()}";
                    }
                }
            }

            return res;
        }

        static void CreateFigureMenu()
        {
            Console.WriteLine($"1. Create a circle\n" +
                $"2. Create a rectangle\n" +
                $"3. Create a square\n" +
                $"0. Return to main menu\n");

            int figureMenuItem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number of figure: ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (figureMenuItem)
            {
                case 1:
                    Console.WriteLine("Input center of circle:");
                    Point center = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Inpur radius:");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    Service.figureList.Add(new Circle(number, center, radius));
                    break;
                case 2:
                    Console.WriteLine("Input first point of rectangle:");
                    Point firstRectanglePoint = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Input second point of rectangle:");
                    Point secondRectanglePoint = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Service.figureList.Add(new Rectangle(number, firstRectanglePoint, secondRectanglePoint));
                    break;
                case 3:
                    Console.WriteLine("Input first point of square:");
                    Point firstSquarePoint = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Input second point of Square:");
                    Point secondSquarePoint = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Service.figureList.Add(new Square(number, firstSquarePoint, secondSquarePoint));
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("This menu item does not exist");
                    break;
            }
        }

        static string ViewAll()
        {
            string res = "";

            for (int i = 0; i < Service.figureList.Count; i++)
            {
                res += Service.figureList[i].ToString() + "\n";
            }

            return res;
        }

        static string CheckBelongPoint()
        {
            Console.Write("Enter namber of figure:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter checking point");
            var checkpoint = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            bool boolRes = false;

            for (int i = 0; i < Service.figureList.Count; i++)
            {
                if (Service.figureList[i].Number == number)
                {
                    boolRes = Service.figureList[i].CheckPoinBelonging(checkpoint);
                }
            }

            if (boolRes)
            {
                return $"Specified point belongig to selected figure";
            }
            else
            {
                return $"Specified point is not belongig to selected figure";
            }
        }

        static double SpecialFanctionOfCircle()
        {
            Console.Write("Enter number of figure: ");
            int number = Convert.ToInt32(Console.ReadLine());

            double res = 0;

            for (int i = 0; i < Service.figureList.Count; i++)
            {
                if (Service.figureList[i].Number == number)
                {
                    if (Service.figureList[i].GetType().Name == "Circle")
                    {
                        Circle circle = (Circle)Service.figureList[i];
                        res = circle.Diametr();
                    }
                }
            }

            return res;
        }
    }
}

