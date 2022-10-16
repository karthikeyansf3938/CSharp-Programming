using System;
namespace QueueDs
{
    public partial class Queue<Type>
    {

        public void Enqueue(Type data)
        {
            if(_tail==_capacity)
            {
                GrowSize();
            }
            Array[_tail]=data;
            _tail++;
            _count++;
        }


        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] Array1 = new Type[_capacity];

            for(int i=0;i<Array.Length;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
        }


        public Type Dequeue()
        {
            Type value=default(Type);
            if(_head>_tail)
            {
                Console.WriteLine($"Queue Empty");
            }
            else
            {
                value=Array[_head];
                _head++;
                _count--;
            }
            return value;
        }
        public Type Peek()
        {
            Type value=default(Type);
            if(_head>_tail)
            {
                Console.WriteLine($"Queue Empty");
            }
            else
            {
                value=Array[_head];
            }
            return value;
        }
        public bool Contains(Type data)
        {
            bool value=false;
            for (int i = 0; i < Array.Length; i++)
            {
                if(Array[i].Equals(data))
                {
                    value=true;
                }
            }
            return value;
        }
    }
}