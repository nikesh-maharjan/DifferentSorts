using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 3, 2, 8, 6, 3, 4, 7 };
            int initialPos = 0;
            int finalPos = array.Length - 1;

            Display(array);
            QuickSort(array, initialPos, finalPos);
            Display(array);
        }

        public static int[] QuickSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int s = Partition(arr, l, r);
                QuickSort(arr, l, s - 1);
                QuickSort(arr, s + 1, r);
            }
            return arr;
        }

        public static int Partition(int[] arr, int l, int r)
        {
            int p = arr[l];
            int i = l;
            int j = r;
            while (i < j)
            {
                while ((j >= i) && (p >= arr[i]))
                {
                    i++;
                }
                while (j >= i && p <= arr[j])
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    i++; j--;
                }
            }
            arr[l] = arr[j];
            arr[j] = p;

            return j;
        }

        public static void Display(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine(" \n");
        }
    }
}

