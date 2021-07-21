using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            float r;
            float n = 3.14159F;
            float area;
            r = (float)Convert.ToDouble (Console.ReadLine());
            area = n * r * r;
            Console.WriteLine("A={0:F4}\n", area);
            Console.ReadLine();
        }
    }
}
