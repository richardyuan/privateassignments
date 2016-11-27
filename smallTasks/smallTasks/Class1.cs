using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallTasks
{
    class Class1
    {
        public static int[] cardDeck = { 5, 4, 3, 1, 2, 6 };
        
        public static void mergeSort(int[] list, int low, int high)
        {
            if (high > low)
            {
                int middle = (high + low) / 2;
                mergeSort(list, low, high);
                mergeSort(list, (middle + 1), high);
                merge(list, low, middle, high);
            }
        }

        public static void merge(int[] list, int low, int middle, int high)
        {
            int L = low;
            int R = middle + 1;
            int[] temp = new int[(high - low) + 1];
            int tempIndex = 0;

            while ((L <= middle) && (R <= high))
            {
                if (list[L] < list[R])
                {
                    temp[tempIndex] = list[L];
                    L = L + 1;
                }
                else
                {
                    temp[tempIndex] = list[R];
                    R = R + 1;
                }
                tempIndex = tempIndex + 1;
            }

            if (L <= middle)
            {
                while (L <= middle)
                {
                    temp[tempIndex] = list[L];
                    L = L + 1;
                    tempIndex = tempIndex + 1;
                }
            }

            if (R <= high)
            {
                while (R <= high)
                {
                    temp[tempIndex] = list[R];
                    R = R + 1;
                    tempIndex = tempIndex + 1;
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {
                list[low + i] = temp[i];
            }
           
        }


        
        public static int[] insertionSort(int[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                int key = list[i];
                int current = i - 1;

                while (current >= 0 && key < list[current])
                {
                    list[current + 1] = list[current];
                    current = current - 1;
                }
                list[current + 1] = key;
            }
            return list;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The length of the deck is: " + cardDeck.Length);
            Console.WriteLine("Values before the algorithm: ");
            getData(cardDeck);
            insertionSort(cardDeck);
            Console.WriteLine("After the algorithm: ");
            getData(cardDeck);

            Console.ReadKey();
        }

        public static void getData(int[] list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
