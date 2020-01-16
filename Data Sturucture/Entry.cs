namespace Data_Sturucture
{
    public class Entry<T>
    {
        public int key;
        public T value;
        public Entry<T> next; //next element about entry (Be connect to it) and every Array is made up of many linked List
        public Entry(int key, T value)
        {
            this.key = key;
            this.value = value;
            next = null;
        }
        public Entry()
        {
            next = null;
        }
        public int GetKey()
        {
            return key;
        }

        public T GetValue()
        {
            return value;
        }

    }
}
