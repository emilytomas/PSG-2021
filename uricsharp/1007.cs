using System;

namespace aaaaaa
{
    internal class Program : ProgramBase
    {
        private override void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int a = Convert.ToInt32(userInput);
            int b = Convert.ToInt32(userInput);
            float c = (float)Convert.ToDouble(userInput);
            float d = c * b;
            Console.WriteLine("NUMBER = {}", a);
            Console.WriteLine("SALARY = U$ {0:F2}", d);

        }
    }
}
