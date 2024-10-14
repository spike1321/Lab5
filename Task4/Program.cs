using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 50);
                
            }
            Console.Write("Массив: ");
            
            foreach (int b in array)
            {
                Console.Write(" {0}", b);
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
               if((i+1)%2==0 && array[i]%2!=0 && array[i]>0)
                {
                    count += 1;
                }
            }
           Console.Write("Количество нечетных положительных элементов, стоящих на четных местах равно: {0}",count);
            Console.ReadKey();

        }
    }
}
