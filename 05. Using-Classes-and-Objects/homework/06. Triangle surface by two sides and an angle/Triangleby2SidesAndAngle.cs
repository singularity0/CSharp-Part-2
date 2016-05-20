using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalcTriangle2SidesAndAngle
{
    class Triangleby2SidesAndAngle
    {
        static void Main(string[] args)
        {
            double[] values = Input();
            double result = CalcTriangeByTwoSidesAngle(values);
            Console.WriteLine("{0:F2}", result);
        }

        private static double CalcTriangeByTwoSidesAngle(double[] values)
        {
            return (values[0] * values[1] * Math.Sin(DegreeToRadian(values[2]))) / 2;
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
        private static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
