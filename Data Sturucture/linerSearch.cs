using System;

namespace Data_Sturucture
{
    public class linerSearch
    {
        int size;
        int seachnum;
        int[] Array;
        public linerSearch(int size, int seachnum)
        {
            this.size = size;
            this.seachnum = seachnum;
            Array = new int[this.size];
        }

        public void sarech()
        {
            for (int x = 1; x <= size; x++)
            {
                Array[x - 1] = x;
            }

            ////liner Search
            int numbertry = 0;
            for (int x = 0; x < size; x++)
            {
                numbertry++;
                if (Array[x] == seachnum)
                {
                    Console.WriteLine("found your number::" + seachnum);
                    Console.WriteLine("number for try :: " + numbertry);
                    break;
                }
            }
        }
    }
}
