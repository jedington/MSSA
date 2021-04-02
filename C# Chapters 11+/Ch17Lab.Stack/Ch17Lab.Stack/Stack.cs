using System;

namespace Ch17Lab.Stack
{
    public class Stack<TGen>
    {
        // fields
        private readonly int _size; // initially 0
        private readonly TGen[] _stack; // initially null
        private int _topOfStack; // initially 0


        // constructor
        public Stack(int size)
        {
            _size = size;
            _stack = new TGen[size];
        } // IntStack const ends


        // methods
        public void Push(TGen valueToPush)
        {
            if (_topOfStack < _size)
            {
                _stack[_topOfStack] = valueToPush;
                _topOfStack++;
            }
        } // Push method ends

        public TGen Pop()
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

