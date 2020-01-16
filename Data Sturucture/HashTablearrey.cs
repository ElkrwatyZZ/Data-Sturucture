using System;

namespace Data_Sturucture
{
    class HashTablearrey<T>
    {
        int size;
        Entry<T>[] arrayHash;
        public HashTablearrey(int size)
        {
            this.size = size;
            arrayHash = new Entry<T>[this.size];
            for (int x = 0; x < arrayHash.Length; x++)
            {
                arrayHash[x] = new Entry<T>();
            }
        }
        int GetHash(int key)
        {
            return key % size; //   EVERY has his own hash methods
        }

        public void put(int key, T value)
        {
            int index = GetHash(key);
            Entry<T> ArrayValue = arrayHash[index];  // احنا معانا index عايزين نحطه    ف linked list
            Entry<T> NewItem = new Entry<T>(key, value);
            NewItem.next = ArrayValue.next;
            ArrayValue.next = NewItem;
        }

        public T get(int key)
        {
            T value = default(T);
            int index = GetHash(key);
            Entry<T> ArrayValue = arrayHash[index]; //  ممكن يكون في المدخل ده اكتر من عنصر فا لازم نلف عليه لانه عباره عن linked list
            while (ArrayValue != null)
            {
                if (ArrayValue.GetKey() == key)
                {
                    value = (T)ArrayValue.GetValue();
                }
                ArrayValue = ArrayValue.next;
            }

            return value;
        }
        public void display(int key)
        {
            Console.WriteLine(get(key));
        }
    }
}
