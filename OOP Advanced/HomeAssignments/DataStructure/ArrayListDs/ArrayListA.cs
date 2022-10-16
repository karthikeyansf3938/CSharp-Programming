using System;
namespace ArrayListDs
{
    public partial class ArrayList
    {
        private int _count;
        private int _capacity;
        private dynamic[] Array{get; set;}//dynamic [Dynamic]
        public int Count{get{return _count;}}

        public dynamic this[int i]
        {get{return Array[i];} set{Array[i]=value;}}
        
        public ArrayList()
        {
            _count=0;
            _capacity=4;
            Array = new dynamic[_capacity];
        }
        public ArrayList(int size)
        {
            _count=0;
            _capacity=4;
            Array = new dynamic[size];
        }
        
    }
}