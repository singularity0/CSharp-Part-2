using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CalcTriangleBy3sides
{
    class Triangleby2SidesAndAngle
    {
        static void Main(string[] args)
        {
            double[] values = Input();
            double result = CalcTriangeBy3Sides(values);
            Console.WriteLine("{0:F2}", result);
        }

        private static double CalcTriangeBy3Sides(double[] values)
        {
            double perimeter = (values[0] + values[1] + values[2]) / 2 ;
            double area = Math.Sqrt(perimeter * (perimeter - values[0]) * (perimeter - values[1]) * (perimeter - values[2]));
            return  area;
        }

        private static double[] Input()
        {
            double[] container = new double[3];
            for (int i = 0; i < 3; i++)
            {
                container[i] = double.Parse(Console.ReadLine());
            }
            return container;
        }

    }
}
