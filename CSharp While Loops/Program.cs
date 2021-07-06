using System;

namespace CSharp_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);

            //    i++;
            //}

            while (true)
            {
                Console.Write("type your name:");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }
        }
    }
}
