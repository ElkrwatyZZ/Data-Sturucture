using System;

namespace Data_Sturucture
{
    public class stackarraydynmaicc
    {
        public int sizee;
        public int[] arraysatck;
        public int top;
        public stackarraydynmaicc(int sizee)
        {
            this.sizee = sizee;
            arraysatck = new int[this.sizee];
            top = -1;
        }

        public int push(int newitem)
        {
            /*if (top == sizee - 1)
            {  ///stazk is full
                Console.WriteLine("stazk is full");
                return 0;
            }*/
            ensurecapity(top + 2);
            top = top + 1;
            return arraysatck[top] = newitem;
        }

        public void ensurecapity(int mincapsity)  //8
        {
            int oldcapacity = arraysatck.Length;  //12
            if (mincapsity > oldcapacity)   //8 > 12
            {
                int newcapity = oldcapacity * 2;  // 22
                if (newcapity < mincapsity) //delete    22 < 8 
                {
                    newcapity = mincapsity;  // 8
                }
                // data.CopyTo(data,newcapity);

                // data.CopyTo(data, newcapity);
                int[] newdata = new int[newcapity];   /// 22
                // Array.Copy(data,newcapity);
                for (int i = 0; i < oldcapacity; i++)  // 12
                {
                    //newdata[i] = data[i];
                    arraysatck[i] = newdata[i];  //   12
                }
                arraysatck = newdata;
            }
        }
        public void radiuscapacity(int mincapsity)
        {/// 8
            int oldcapacity = arraysatck.Length;  /// 12
            if (mincapsity < oldcapacity)
            {   // 8 < 12 
                int newcapity = oldcapacity / 2;  /// 6 
                if (newcapity < mincapsity)
                {  // 6 <  8
                    newcapity = mincapsity; // 6 = 6
                }
                int[] newdata = new int[newcapity]; // 6 
                for (int i = 0; i < arraysatck.Length; i++) ///  12
                {
                    //newdata[i] = data[i];
                    arraysatck[i] = newdata[i]; // copy value to arraystack
                }
                arraysatck = newdata; ///  arraystack = 6
            }
        }
        public int pop()
        {
            if (top == -1)
            { /// stack is empaty
                Console.WriteLine("stack is empaty");
                return 0;
            }
            // radiuscapacity(top + 2 ); // top = 6 (6+2=8)  fixed and test
            // else{
            int item = arraysatck[top];
            top = top - 1;
            return item;
            //}
        }
    }
}
