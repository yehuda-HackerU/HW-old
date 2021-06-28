using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while ex1
            /*
            Console.WriteLine("enter number < 20:");
            int x = int.Parse(Console.ReadLine());
            int iter = 0;
            while (x < 20)
            {
                int inner = x / 2;
                while (x > 14 && x % 2 == 0 && inner > 1)
                {
                    Console.WriteLine("inner loop = {0}", --inner);
                }
                x++;
                iter++;
            }
            Console.WriteLine("\n--- iterations = {0} ---", iter);
            */
            #endregion

            #region for ex1
            /*
            Console.WriteLine("Enter a number > 3:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num * 2; i++)
            {
                Console.WriteLine("iteration {0}", i);
            }
            */
            #endregion

            #region for ex2
            /*
            for (int i = 0, j = 10; i <= 10; i++, j--)
            {
                Console.WriteLine("{0} + {1} = {2}", i, j, i + j);
            }
            */
            #endregion

            #region continue & break ex1
            /*
            Console.WriteLine("Enter a number > 3:");
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num * 2; i++)
            {
                if (i == 1)
                    continue;
                else if (i > 10)
                    break;
                Console.WriteLine("iteration {0}", i);
                if (i == num * 2)
                    Console.WriteLine("END");
            }
            */
            #endregion

            #region continue & break ex2
            /*
            int iter = 0;
            do
            {
                iter++;
                Console.WriteLine("Enter a number (or 23 to break):");
                int num = int.Parse(Console.ReadLine());
                if (num == 23)
                    break;
            } 
            while (true);

            Console.WriteLine("loop iterations: {0}.", iter);
            */
            #endregion

            #region loops(2) ex1
            /*
            bool prime;
            do
            {
                Console.WriteLine("enter a nuber:");
                int num = int.Parse(Console.ReadLine());
                prime = true; 

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
            }
            while (!prime);
            */
            #endregion

            #region loops(2) ex2
            /*
            Console.WriteLine("Enter the number of students:");
            int num = int.Parse(Console.ReadLine());

            int class_100 = num / 100;
            num -= class_100 * 100;
            int class_30 = num / 30;
            num -= class_30 * 30;
            int class_10 = num / 10;
            num -= class_10 * 10;

            Console.WriteLine("classes of 100: {0}.\nclasses of 30: {1}.\nclasses of 10: {2}.\nstudents with no class: {3}.",
                class_100, class_30, class_10, num);
            */
            #endregion

            #region loops(2) ex3
            /*
            Console.WriteLine("Enter a number to play:");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            bool back = false;

            while (i > 0)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                if (back)
                    i--;
                else
                    i++;

                Console.WriteLine();
                if (i == num)
                    back = true;
            }
            */
            #endregion

            #region loops(2) ex4
            /*
            Console.WriteLine("Enter a number to play:");
            int num = int.Parse(Console.ReadLine());
            string s = "";
            string space = string.Concat(Enumerable.Repeat(" ", num));

            for (int i = 1; i <= num; i++)
            {
                s += "* ";
                space = space.Remove(0, 1);
                Console.WriteLine(space + s + space);
            }
            */
            #endregion
            
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}