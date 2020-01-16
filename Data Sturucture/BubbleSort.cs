using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Sturucture
{
    public class BubbleSort
    {
        public void Bubbe(int[] array)
        {
            //Big-0(N2)
            int n = array.Length;  // c
            int temp = 0; // c 
            for(int x = 0; x < n; x++) //n time
            {
                for(int i = 1; i < (n - x); i++)//n time
                {
                    if(array[i-1] > array[i]) {  //c
                        temp = array[i - 1];//c 
                        array[i - 1] = array[i];//c
                        array[i] = temp;//c
                    }
                }
            }

        }
    }
}
    