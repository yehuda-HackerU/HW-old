using System;

namespace HW_arrats_advc
{
    class Program
    {
        static void Main(string[] args)
        {
            #region multiplication table
            
            int[,] mul_tab = new int[10, 10];
            for (int i = 0; i < mul_tab.GetLength(0); i++)
            {
                for (int j = 0; j < mul_tab.GetLength(1); j++)
                {
                    mul_tab[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < mul_tab.GetLength(0); i++)
            {
                for (int j = 0; j < mul_tab.GetLength(1); j++)
                {
                    Console.Write($"{mul_tab[i, j], -4}");
                }
                Console.WriteLine();
            }
            
            #endregion



            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
