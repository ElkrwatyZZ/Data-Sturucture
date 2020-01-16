using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Sturucture
{
    public class margeSort
    {
      public  int[] array;
      public int[] TempArray; //Assembling Small Array
        public void prepareforSort(int[] arr)
        {
            //prepare for sort
            this.array = arr;
            this.TempArray = new int[arr.Length];
            domargeSort(0, arr.Length - 1);
        }
        public void domargeSort(int lowerIndex, int Heightndex)  //Prepartion for sorting
        {
            //divide to small probelm
            if(lowerIndex < Heightndex)
            {
                int middle = lowerIndex + (Heightndex - lowerIndex) / 2;
                domargeSort(lowerIndex, middle); //em.(1,5)
                domargeSort(middle + 1, Heightndex);//em.(6,10)
                MargePart(lowerIndex,middle,Heightndex);
            }
        }
        public void MargePart(int lowerIndex, int middle, int Heightndex)
        {
            //marge small Problems and Sort
            for (int x = lowerIndex; x <= Heightndex; x++)
                TempArray[x] = array[x];

            int low = lowerIndex;
            int mid = middle + 1;
            int pointer = lowerIndex;
            while (low <= middle && mid <= Heightndex) // merge Part
            {
                if (TempArray[low] <= TempArray[mid]) // temp[1 <= 6]
                {
                    array[pointer] = TempArray[low]; // swap your item
                    low++;
                }
                else
                {
                    array[pointer] = TempArray[mid];
                    mid++;
                }   
                pointer++;
            }
            while (low <= middle)
            {
                array[pointer] = TempArray[low];
                pointer++;
                low++;
            }

        }
    }
}


