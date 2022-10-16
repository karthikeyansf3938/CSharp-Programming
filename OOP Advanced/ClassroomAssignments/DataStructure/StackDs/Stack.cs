namespace StackDs
{
    public partial class Stack<Type>
    {
        private Type[] Array{get; set;}

        private int _count;
        private int _capacity;

        public int Count{get{return _count;}}

        public Stack()
        {
            _count=0;
            _capacity=4;
            Array =new Type[_capacity];
        }
        public Stack(int size)
        {
            _count=0;
            _capacity=size;
            Array = new Type[_capacity];
        }
       
    }
}