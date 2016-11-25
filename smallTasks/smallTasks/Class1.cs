using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallTasks
{
    class Class1
    {
        public static int[] cardDeck = { 5, 2, 4, 6, 1, 3 };
        static int deckLength = cardDeck.Length;
        
        
        public static void getData(int[] list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] insertionAlgorithm(int[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                int key = list[i];
                int j = i - 1;

                while (j >= 0 && key < list[j])
                {
                    list[j + 1] = list[j];
                    int temp = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
            return list;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The length of the deck is: " + deckLength);
            Console.WriteLine("Values before the algorithm: ");
            getData(cardDeck);
            insertionAlgorithm(cardDeck);
            Console.WriteLine("After the algorithm: ");
            getData(cardDeck);

            Console.ReadKey();

            
        }

        public static void insertionSort(int[] unsortedDeck)
        {
            for (int index = 0; index < deckLength - 1; index++)
            {
                int key = unsortedDeck[index];
                int prevIndex = index - 1;

                while (prevIndex >= 0 && unsortedDeck[prevIndex] > key)
                {
                    unsortedDeck[prevIndex + 1] = unsortedDeck[prevIndex];
                    prevIndex = prevIndex - 1;
                }
                unsortedDeck[prevIndex + 1] = key;
            }
            Console.WriteLine("done");
        }
    }
}
