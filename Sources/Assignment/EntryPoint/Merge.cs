using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryPoint
{
    public class Merge
    {
        public static void mergeSort(Vector2 house, List<Vector2> specialBuildings, int low, int high)
        {
            if (high > low)
            {
                int middle = (high + low) / 2; 
                mergeSort(house, specialBuildings, low, middle); //left side
                mergeSort(house, specialBuildings, (middle + 1), high); //right side
                merge(specialBuildings, house, low, (middle + 1), high);
            }
        }

        public static void merge(List<Vector2> specialBuildings, Vector2 house, int low, int middle, int high)
        {
            Vector2[] temp = specialBuildings.ToArray();

            int leftEnd = (middle - 1);
            int num_elements = (high - low + 1);
            int tempIndex = low;

            while ((low <= leftEnd) && (middle <= high))
            {
                double distance_left = Math.Sqrt(Math.Pow(house.X - specialBuildings.ElementAt(low).X, 2) + Math.Pow((house.Y - specialBuildings.ElementAt(low).Y), 2)); // distance for item
                double distance_right = Math.Sqrt(Math.Pow(house.X - specialBuildings.ElementAt(middle).X, 2) + Math.Pow((house.Y - specialBuildings.ElementAt(middle).Y), 2)); //distance for next item
                if (distance_left < distance_right)
                {
                    temp[tempIndex] = specialBuildings[low];
                    low = low + 1;
                    tempIndex++;
                }
                else
                {
                    temp[tempIndex] = specialBuildings[middle];
                    middle = middle + 1;
                    tempIndex = tempIndex + 1;
                }
            }
                
            while (low <= leftEnd)
            {
                temp[tempIndex] = specialBuildings[low];
                low = low + 1;
                tempIndex++;
            }
                
            while (middle <= high)
            {
                temp[tempIndex] = specialBuildings[middle];
                middle = middle + 1;
                tempIndex = tempIndex + 1;
            }
                
            for (int i = 0; i < num_elements; i++)
            {
                specialBuildings[high] = temp[high];
                high--;
            }
            
        }
    }
}
