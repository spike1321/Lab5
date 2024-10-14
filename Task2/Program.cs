using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = 15;
            int sum;
            int min = int.MaxValue;
            int max = int.MinValue;
            int[] array = new int[count];
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = rnd.Next(0, 50);
                Console.WriteLine("Элементы массива: {0}", array[i]);
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            sum = max + min;
            Console.WriteLine("Сумма максимального {0} и минимального {1} элемента равна: {2}", max, min, sum);
            Console.ReadKey();
        }
    }
}
