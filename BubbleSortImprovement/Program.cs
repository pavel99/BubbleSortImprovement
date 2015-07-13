using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortImprovement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = new[] {1, 8, 2, 10, 57, 3, 5, 10};
            BubbleSort(array,array.Length);
            for (int i = 0; i <array.Length; i++)
            {
                Console.WriteLine(array[i]); 
            }
            
        }

        public static void BubbleSort(int[] arrey, int lengthOfArray)
        {
            for (int i = 1; i < arrey.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < arrey.Length - i - 1; j++)
                {

                    if (arrey[j] > arrey[j + 1])
                    {
                        int temp = arrey[j];
                        arrey[j] = arrey[j + 1];
                        arrey[j + 1] = temp;
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    break;
                }

            }
        }
    }
}
