namespace Components.BoundedQueue.Interfaces
{
    public interface IBoundedQueue<T>
    {
        void Enqueue(T Element);

        T Dequeue();

        int Count();

        int Size();
    }
}
