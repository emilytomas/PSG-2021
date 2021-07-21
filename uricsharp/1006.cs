using System;

namespace aaaaaa
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float x = (float)Convert.ToDouble(Console.ReadLine());
            float y = (float)Convert.ToDouble(Console.ReadLine());
            float z = (float)Convert.ToDouble(Console.ReadLine());
            double v = ((x * 2) + (y * 3) + (z * 5)) / 10;
            Console.WriteLine("MEDIA = {0:F1}", v);
            Console.ReadLine();
        }
    }
}
