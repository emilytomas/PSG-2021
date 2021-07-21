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
            int A;
            int B;
            int C;
            A = Convert.ToInt16(Console.ReadLine());
            B = Convert.ToInt16(Console.ReadLine());
            C = A + B;
            
            Console.WriteLine("X = {0}\n", C);
           
        }
    }
}
