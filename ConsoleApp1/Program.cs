using FigureLibrary;
using FigureLibrary.Figures;
using System;

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
                            Console.WriteLine(String.Join("\n", Service.FigureList));
                            break;
                        case 3:
                            Console.WriteLine(CheckBelongPoint());
                            break;
                        case 4:
                            Console.WriteLine(SpecialFunctionsForRectangleAndSquare());
                            break;
                        case 5:
                            Console.WriteLine($"Diametr: {SpecialFunctionForCircle()}");
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

        static string SpecialFunctionsForRectangleAndSquare()
        {
            Console.Write("Enter number of figure: ");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                throw new Exception("Entered value is used be integer");
            }

            if (Service.FigureList.Count < number)
            {
                throw new Exception("Figure with such number is not exist");
            }

            string res = string.Empty;

            if(Service.FigureList[number - 1].GetType() == typeof(Rectangle))
            {
                Rectangle rectangle = (Rectangle)Service.FigureList[number - 1];
                res += $"{rectangle.VertexOfRectangleAndSquare()}\nSide: {rectangle.SideOfRectangleAndSquare()}\nDiagonal: {rectangle.DiagonalOfRectangleAndSquare()}";
            }
            else if (Service.FigureList[number - 1].GetType().Name == "Square")
            {
                Square square = (Square)Service.FigureList[number - 1];
                res += $"{square.VertexOfRectangleAndSquare()}\nSide: {square.SideOfRectangleAndSquare()}\nDiagonal{square.DiagonalOfRectangleAndSquare()}";
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

            switch (figureMenuItem)
            {
                case 1:
                    Console.WriteLine("Input center of circle:");
                    Point center = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Inpur Radius:");
                    int Radius = Convert.ToInt32(Console.ReadLine());
                    Service.FigureList.Add(new Circle(center, Radius));
                    break;
                case 2:
                    Console.WriteLine("Input first point of rectangle:");
                    Point firstRectanglePoint = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Input second point of rectangle:");
                    Point secondRectanglePoint = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Service.FigureList.Add(new Rectangle(firstRectanglePoint, secondRectanglePoint));
                    break;
                case 3:
                    Console.WriteLine("Input first point of square:");
                    Point firstSquarePoint = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Input second point of Square:");
                    Point secondSquarePoint = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Service.FigureList.Add(new Square(firstSquarePoint, secondSquarePoint));
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("This menu item does not exist");
                    break;
            }
        }

        static string CheckBelongPoint()
        {
            Console.Write("Enter number of figure:");
            if(!int.TryParse(Console.ReadLine(), out int number))
            {
                throw new Exception("Entered value is used be integer");
            }

            Console.WriteLine("Enter checking point");
            Point checkpoint = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            bool IsRequired = false;

            if (Service.FigureList.Count < number)
            {
                throw new Exception("Figure with such number is not exist");
            }

            IsRequired = Service.FigureList[number - 1].CheckPoinBelonging(checkpoint);

            if (IsRequired)
            {
                return $"Specified point belongig to selected figure";
            }
            else
            {
                return $"Specified point is not belongig to selected figure";
            }
        }

        static double SpecialFunctionForCircle()
        {
            Console.Write("Enter number of figure: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                throw new Exception("Entered value is used be integer");
            }

            if (Service.FigureList.Count < number)
            {
                throw new Exception("Figure with such number is not exist");
            }

            double res = 0;

            if (Service.FigureList[number - 1].GetType() == typeof(Circle))
            {
                Circle circle = (Circle)Service.FigureList[number - 1];
                res = circle.Diametr(circle.Radius);
            }

            return res;
        }
    }
}

