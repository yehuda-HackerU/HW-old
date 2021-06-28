using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region arrays ex1
            /*
            int[] int_array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter a value for array index {i}: ");
                int_array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine($"array [{i}] = {int_array[i]}.");
            }
            */
            #endregion

            #region arrays ex2
            /*
            string[] str_array = new string[5];
            Console.Write("Enter value for array index 0: ");
            str_array[0] = Console.ReadLine();
            Console.Write("Enter value for array index 1: ");
            str_array[1] = Console.ReadLine();
            Console.Write("Enter value for array index 2: ");
            str_array[2] = Console.ReadLine();
            Console.Write("Enter value for array index 3: ");
            str_array[3] = Console.ReadLine();
            Console.Write("Enter value for array index 4: ");
            str_array[4] = Console.ReadLine();
            
            Console.WriteLine($"array index 0 = {str_array[0]}.\narray index 1 = {str_array[1]}.\narray index 2 = {str_array[2]}.\n" +
                $"array index 3 = {str_array[3]}.\narray index 4 = {str_array[4]}");
            */
            #endregion

            #region arrays ex3
            /*
            int[] arr1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter a value for array index {i}: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int[] arr2 = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr2[i] = arr1[i];
                arr1[i] = random.Next(100);
            }
            Console.WriteLine($"first array = {string.Join(", ", arr1)}");
            Console.WriteLine($"second array = {string.Join(", ", arr2)}");

            //secod array doesn't change.
            */
            #endregion

            #region arrays ex4
            /*
            int[] arr1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter a value for array index {i}: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int[] arr2 = new int[10];
            arr2 = arr1;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = random.Next(100);
            }
            Console.WriteLine($"first array = {string.Join(", ", arr1)}");
            Console.WriteLine($"second array = {string.Join(", ", arr2)}");

            //second array does change.
            */
            #endregion

            #region arrays ex6
            /*
            Console.WriteLine("Enter the number of studets in the class");
            int students = int.Parse(Console.ReadLine());
            int[] grades = new int [students];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Enter grade for student {i + 1}");
                grades[i] = int.Parse(Console.ReadLine());
            }

            float sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }

            Console.WriteLine($"The average grade is: {sum/students}");
            */
            #endregion



            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
