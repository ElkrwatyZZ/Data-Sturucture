using System;
using System.Collections.Generic;

namespace Data_Sturucture
{
    class Program
    {


        static void Main(string[] args)
        {

            int[] Number = { 6,4,5,1,2,3,0 };
            //////////////////////////////marge Bubble//////////////////////////////////
            Console.WriteLine("//////////////////////////////////////////////////////");
            Console.WriteLine("Bubble Sort is starting");
            BubbleSort bubble = new BubbleSort();
            bubble.Bubbe(Number);
            for (int x = 0; x < Number.Length; x++)
            {
                Console.Write(Number[x] + "\t");
            }
            //////////////////////////////marge Sort//////////////////////////////////
            Console.WriteLine("//////////////////////////////////////////////////////");
            Console.WriteLine("marge Sort is starting");
            margeSort masort = new margeSort();
            masort.prepareforSort(Number);
            for (int x = 0; x < Number.Length; x++)
            {
                Console.Write(Number[x] + "\t");
            }

            //////////////////////////////heap Sort//////////////////////////////////
            Console.WriteLine("//////////////////////////////////////////////////////");
            Console.WriteLine("heap Sort is starting");
            HeapSort heap = new HeapSort();
            heap.sort(Number);
            for (int x = 0; x < Number.Length; x++)
            {
                Console.Write(Number[x] + "\t");
            }
        }
    }
}
