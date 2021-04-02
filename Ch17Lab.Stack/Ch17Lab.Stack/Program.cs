using System;

namespace Ch17Lab.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            IntStack tenInts = new IntStack(10);
            bool empty = tenInts.IsEmpty();

            tenInts.Push(1);
            tenInts.Push(2);
            tenInts.Push(3);
            tenInts.Push(4);
            tenInts.Push(5);
            tenInts.Push(6);
            tenInts.Push(7);
            tenInts.Push(8);
            tenInts.Push(9);
            tenInts.Push(10);
            tenInts.Push(11);

            bool full = tenInts.IsFull();
            int v1 = tenInts.Pop();
            int v2 = tenInts.Pop();
        }
    }
}
