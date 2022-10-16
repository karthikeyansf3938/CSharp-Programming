using System;
namespace StackDs;
public partial class Stack<Type>
{
     public void Push(Type data)
    {
            if(_capacity==_count)
            {
                GrowSize();
            }
            Array[_count]=data;
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


    public Type Pop()
    {
        Type value=default(Type);
        if(_count<0)
        {
            Console.WriteLine($"Empty Stack"); 
        }
        else
        {
            System.Console.WriteLine("Value = "+Array[_count]);
            value=Array[_count];
            _count--;
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
    public Type Peek()
    {
        Type value=default(Type);
        if(_count<0)
        {
            Console.WriteLine($"Empty Stack"); 
        }
        else
        {
            System.Console.WriteLine("Value = "+Array[_count]);
            value=Array[_count];
        }
        return value;
    }
    public void Clear()
    {
        _count=0;
        _capacity=4;
    }

}