using System;

namespace Data_Sturucture
{
    public class dynamicarray
    {
        Object[] data;
        int size = 0;
        public dynamicarray()
        {
            size = 0;
            data = new Object[1];
        }
        public int getsize()
        {
            return data.Length;
        }
        public object get(int index)
        {
            return data[index];
        }
        public void put(int element)
        {
            ensurecapity(size + 1);
            data[size++] = element;
        }
        public void ensurecapity(int mincapsity)
        {
            int oldcapacity = data.Length;
            if (mincapsity > oldcapacity)
            {
                int newcapity = oldcapacity * 2;
                if (newcapity < mincapsity) //delete
                {
                    newcapity = mincapsity;
                }
                // data.CopyTo(data,newcapity);

                // data.CopyTo(data, newcapity);
                object[] newdata = new object[newcapity];
                // Array.Copy(data,newcapity);
                for (int i = 0; i < data.Length; i++)
                {
                    //newdata[i] = data[i];
                    data[i] = newdata[i];
                }
                data = newdata;
            }
        }
    }
}
