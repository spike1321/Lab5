using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            int count = 7;
            double sum = 0;
            double arg;
            double[] array = new double[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write("Введите {0} число: ", (b = i + 1));
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }


            arg = sum / array.Length;
            Console.WriteLine("Среднее арифметическое: {0}", Math.Round(arg, 2));
            Console.ReadKey();
        }
    }
}
