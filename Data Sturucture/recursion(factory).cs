using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Sturucture
{
    class recursion_factory_
    {
       public int fact(int n)
        {
            if (n <= 1) return 1;
            else
            {
                return n * fact(n - 1);
            }
        }
        public void display(int n)
        {
            Console.WriteLine(fact(n));
        }
    }
}
