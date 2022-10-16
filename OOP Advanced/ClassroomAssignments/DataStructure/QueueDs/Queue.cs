using System;

namespace QueueDs
{
    public partial class Queue<Type>
    {
        private int _count;
        
        private int _head;
        private int _tail;
        private int _capacity;

        internal void Enqueue(int v)
        {
            throw new NotImplementedException();
        }

        private Type[] Array{get; set;}

        public int Count{get{return _count;}}

        public Queue()
        {
            _count=0;
            _head=0;
            _tail=0;
            _capacity=4;
            Array=new Type[_capacity];
        }
        public Queue(int size)
        {
            _count=0;
            _head=0;
            _tail=0;
            _capacity=4;
            Array=new Type[_capacity];
        }
    }
}