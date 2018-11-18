using System;
using System.Drawing;

namespace Fractals
{
    internal static class DragonFractalTask
    {
        public static double Angle1 = Math.PI / 4;
        public static double Angle2 = Math.PI * 3 / 4;
        public static double[] Angle = { Angle1, Angle2 };

        public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
        {
            double x1 = 1.0, x;
            double y1 = 0.0, y;
            pixels.SetPixel(1.0, 0.0);
            var random = new Random(seed);
            for (int i = 0; i < iterationsCount; i++)
            {
                x = x1;
                y = y1;
                var angleSelectionFlag = random.Next(2);
                DrawPixel(pixels, angleSelectionFlag, x, y, out x1, out y1);
            }
        }

        public static void DrawPixel(Pixels pixels, int nextNumber, double x, double y, out double x1, out double y1)
        {
            x1 = (x * Math.Cos(Angle[nextNumber]) - y * Math.Sin(Angle[nextNumber])) / Math.Sqrt(2) + nextNumber;
            y1 = (x * Math.Sin(Angle[nextNumber]) + y * Math.Cos(Angle[nextNumber])) / Math.Sqrt(2);
            pixels.SetPixel(x1, y1);
        }
    }
}