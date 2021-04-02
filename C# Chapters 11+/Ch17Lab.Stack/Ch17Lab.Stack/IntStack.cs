using System;

namespace Ch17Lab.Stack
{
    public class IntStack
    {
        // fields
        private readonly int _size; // initially 0
        private readonly int[] _stack; // initially null
        private int _topOfStack; // initially 0


        // constructor
        public IntStack(int size)
        {
            _size = size;
            _stack = new int[size];
        } // IntStack const ends


        // methods
        public void Push(int valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack] = valueToPush;
                _topOfStack++;
            }
        } // Push method ends

        public int Pop()
        {
            _topOfStack--;
            return _stack[_topOfStack];
        } // Pop method ends

        public bool IsEmpty()
        {
            if (_topOfStack > 0)
            {
                return false;
            }
            return true;
        } // IsEmpty method ends

        public bool IsFull()
        {
            if (_topOfStack >= _size)
            {
                return true;
            }
            return false;
        } // IsFull method ends
    } // class ends
} // namespace ends
