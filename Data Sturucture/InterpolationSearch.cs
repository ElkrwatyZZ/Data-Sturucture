using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Sturucture
{
    public class InterpolationSearch
    {
        int Size;
        int[] number;
        int searchnumber;
        public InterpolationSearch(int Size, int searchnumber)
        {
            this.Size = Size;
            this.searchnumber = searchnumber;
            number = new int[this.Size];
        }

        public void search()
        {
            for (int x = 0; x < Size; x++)
            {
                number[x] = x;
            }

            int numberTry=0;
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
                int mid =low + ((height - low) /(number[height] - number[low])) * (searchnumber - number[low]);
                numberTry++;
                if(number[mid] == searchnumber)
                {
                    Console.WriteLine("number is found ::" + searchnumber);
                    Console.WriteLine("number for try :: " + numberTry);
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
