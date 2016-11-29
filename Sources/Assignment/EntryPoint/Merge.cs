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
        public static void mergeSort(List<double> list, int low, int high)
        {
            if (high > low)
            {
                int middle = (high + low) / 2;
                mergeSort(list, low, high);
                mergeSort(list, (middle + 1), high);
                merge(list, low, middle, high);
            }
        }

        public static List<double> merge(List<double> list, int low, int middle, int high)
        {
            int L = low;
            int R = middle + 1;
            double[] temp = new double[(high - low) + 1];
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
            return list;
        }
    }
}
