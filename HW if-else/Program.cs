using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ex1
            Console.WriteLine("Enter number x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number y:");
            int y = int.Parse(Console.ReadLine());
            if (x % y == 0)
            {
                Console.WriteLine("x is evenly divisible by y.");
            }
            else
            {
                Console.WriteLine("x is not evenly divisible by y.");
            }
            #endregion

            #region ex4
            Console.WriteLine("Enter a number to check if it's prime:");
            int num = int.Parse(Console.ReadLine());
            bool prime = false;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    prime = true;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("{0} is a prime number.", num);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number.", num);
            }
            #endregion

            #region ex6
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i * num;
            }
            Console.WriteLine("{0}! == {1}", num, sum);
            #endregion

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
