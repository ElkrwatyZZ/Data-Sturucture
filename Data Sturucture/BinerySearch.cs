using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Sturucture
{
    class BinerySearch
    {
        int size;
        int[] number;
        int searchnumber;
        public BinerySearch(int size, int searchnumber)
        {
            this.size = size;
            this.searchnumber = searchnumber;
            number = new int[this.size];
        }

        public void search()
        {

            for(int x = 1; x < size; x++)
            {
                number[x - 1] = x;
            }
            int numbertry = 0;  
            int low = 0;
            int height = number.Length - 1;
            Boolean isfound = false;
            while (!isfound)
            {
                if(low > height)
                {
                    Console.WriteLine("number not found");
                    break;
                }
                int mid = low + ((height - low) / 2);
                numbertry++;
                if (number[mid] == searchnumber)
                {
                    Console.WriteLine("number is found ::" +searchnumber);
                    Console.WriteLine("number for try :: " + numbertry);
                    break;
                }
                if (searchnumber > number[mid])
                {
                    low = mid + 1;
                }

                if(searchnumber < number[mid])
                {
                    height = mid - 1;
                }
            }
        }
    }
}
