// В этом пространстве имен содержатся средства для работы с изображениями. Чтобы оно стало доступно, в проект был подключен Reference на сборку System.Drawing.dll
using System;
using System.Drawing;

namespace Fractals
{
    internal static class DragonFractalTask
    {
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
                var nextNumber = random.Next(2);
                DrawPixel(pixels, nextNumber, x, y, out x1, out y1);
            }
        }

        public static void DrawPixel(Pixels pixels, int nextNumber, double x, double y, out double x1, out double y1)
        {
            if (nextNumber == 0)
            {
                x1 = (x * Math.Cos(Math.PI / 4) - y * Math.Sin(Math.PI / 4)) / Math.Sqrt(2);
                y1 = (x * Math.Sin(Math.PI / 4) + y * Math.Cos(Math.PI / 4)) / Math.Sqrt(2);
                pixels.SetPixel(x1, y1);
            }
            else
            {
                x1 = (x * Math.Cos(Math.PI * 3 / 4) - y * Math.Sin(Math.PI * 3 / 4)) / Math.Sqrt(2) + 1;
                y1 = (x * Math.Sin(Math.PI * 3 / 4) + y * Math.Cos(Math.PI * 3 / 4)) / Math.Sqrt(2);
                pixels.SetPixel(x1, y1);
            }
        }
    }
}
