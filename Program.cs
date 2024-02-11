using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Triangle Classification");
                Console.WriteLine("Enter the length of three sides:");

                Console.Write("Side 1: ");
                double side1 = double.Parse(Console.ReadLine());

                Console.Write("Side 2: ");
                double side2 = double.Parse(Console.ReadLine());

                Console.Write("Side 3: ");
                double side3 = double.Parse(Console.ReadLine());

                string result = ClassifyTriangle(side1, side2, side3);

                Console.WriteLine($"The triangle is {result}.");
                Console.ReadLine();
            }

             string ClassifyTriangle(double side1, double side2, double side3)
            {
                if (IsValidTriangle(side1, side2, side3))
                {
                    if (side1 == side2 && side2 == side3)
                    {
                        return "Equilateral";
                    }
                    else if (side1 == side2 || side2 == side3 || side1 == side3)
                    {
                        return "Isosceles";
                    }
                    else
                    {
                        return "Scalene";
                    }
                }
                else
                {
                    return "Invalid Triangle";
                }
            }

            bool IsValidTriangle(double side1, double side2, double side3)
            {
                return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
            }
        }
    }
}