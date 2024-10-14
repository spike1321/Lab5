using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 50);
                // Console.Write("Первый массив: {0}", array[i] + "\t");
            }
            Console.Write("Первый массив: ");
            foreach (int b in array)
            {
                Console.Write(" {0}", b);
            }

            // первый способ
          /*    Array.Sort(array,0, 5);
              Array.Sort(array, 5, 5);
              Array.Reverse(array, 5, 5);*/

            //второй способ
            // Сортируем первые 5 элементов по возрастанию
            for (int c = 0; c < (array.Length / 2 -1); c++)
              {
                 
                  for (int v = 0; v < ((array.Length/2-1) - c); v++)

                  {

                      if (array[v] > array[v+1])
                      {
                         int bl = array[v];
                          array[v] = array[v+1];
                          array[v+1] = bl;
                      }


                  }
              }
            // Сортируем последние 5 элементов по убыванию
            for (int c = 5; c < (array.Length - 1); c++)
              {
                  
                  for (int v = 5; v < ((array.Length -1)- (c- 5)); v++)

                  {

                      if (array[v] < array[v + 1])
                      {
                        int  bl = array[v];
                          array[v] = array[v + 1];
                          array[v + 1] = bl;
                      }


                  }
              }

            Console.Write("\nУпорядоченный массив: ");
            foreach (int mas in array)
            {
                Console.Write(" {0}", mas);
            }
            Console.ReadKey();
        }
    }
}
