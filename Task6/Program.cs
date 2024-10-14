using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bl = false;
            int sum = 0, temp_sum = 0;
            Console.WriteLine("введите размерность");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("введите i= {0} и j = {1} число: ",i+1,j+1);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            for (int i = 0; i < n; i++)
            {
                sum += array[i, i];
            }
            for (int i = 0; i < n; i++)
                temp_sum += array[i,n - i - 1];
            if (sum != temp_sum)
            {
                bl = false;
            }
            else
            {
                bl = true;
            }
            for (int i = 0; i < n; i++)
            {
                temp_sum = 0;
                for (int j = 0; j < n; j++)
                    temp_sum += array[i, j];
        if(sum != temp_sum)
                    bl = false;
                temp_sum = 0;
                for (int j = 0; j < n; j++)
                    temp_sum += array[j, i];
        if(sum != temp_sum)
                    bl = false;
            
            }
           

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }

                if(bl)
                Console.WriteLine("Является ли введенная с клавиатуры матрица магическим квадратом: да, является");
               else
                Console.WriteLine("Является ли введенная с клавиатуры матрица магическим квадратом: нет, не является");
            Console.ReadKey();
        }
    }
}

