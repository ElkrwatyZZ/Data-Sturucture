namespace Data_Sturucture
{
    public class NodeDouble<T>
    {
        public T value;
        public NodeDouble<T> next;

        public NodeDouble<T> prevous;

        public NodeDouble(T value, NodeDouble<T> next, NodeDouble<T> prevous)
        {
            this.next = next;
            this.prevous = prevous;
            this.value = value;
        }
    }
}
