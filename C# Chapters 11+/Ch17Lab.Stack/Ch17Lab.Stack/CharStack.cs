using System;

namespace Ch17Lab.Stack
{
    public class CharStack
    {
        // fields
        private readonly int _size; // initially 0
        private readonly char[] _stack; // initially null
        private int _topOfStack; // initially 0


        // constructor
        public CharStack(int size)
        {
            _size = size;
            _stack = new char[size];
        } // IntStack const ends


        // methods
        public void Push(char valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack] = valueToPush;
                _topOfStack++;
            }
        } // Push method ends

        public char Pop()
            => _stack[--_topOfStack];
        // Pop method ends

        public bool IsEmpty()
            => _topOfStack <= 0;
        // IsEmpty method ends

        public bool IsFull()
            => _topOfStack >= _size;
        // IsFull method ends
    } // class ends
} // namespace ends
