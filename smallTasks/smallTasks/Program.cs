using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallTasks
{
    class Program
    {
        public static int[] cardDeck = {5,2,4,6,1,3};
        static int deckLength = cardDeck.Length;
        

        public static void insertionSort(int[] unsortedDeck)
        {
            
            Console.WriteLine("The length of the deck is: " + deckLength);

            for(int index = 0; index < deckLength-1; index++)
            {
                int key = unsortedDeck[index];
                int prevIndex = index - 1;
                
                while(prevIndex >= 0 && unsortedDeck[prevIndex] > key)
                {
                    unsortedDeck[prevIndex + 1] = unsortedDeck[prevIndex];
                    prevIndex = prevIndex - 1;
                }
                unsortedDeck[prevIndex + 1] = key;
            }
            Console.WriteLine("done"); 
        }

        public static void getData(int[] list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }


        static void Main(string[] args)
        {
            insertionSort(cardDeck);
            getData(cardDeck);
            
            Console.ReadKey();
        }


    }
}
