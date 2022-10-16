using System;
namespace ArrayListDs
{
    public partial class ArrayList
    {
        public void GrowSize()
        {   
            _capacity=_capacity*2;
            dynamic[] Array1 = new dynamic[_capacity];

            for(int i=0;i<Array.Length;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;  
        }
    public void Add(dynamic data)
    {
        if(_count == _capacity)//if _count == _capacity then it increase the capacity
        {
            GrowSize();
        }
        Array[_count] = data;
            _count++;
    }


    public void Insert(int index,dynamic data)
    {
        _capacity=_capacity*2;
        dynamic[] insert=new dynamic[_capacity];
        for(int i=0;i<_count;i++)
        {
            if(index>i)
            {
                insert[i]=Array[i];
            }
            else if(i>=index)
            {
                insert[i+1]=Array[i];
            }
            
        }
        insert[index]=data;
        Array=insert;
    }
    public void RemoveAt(int index)
    {
        for(int i=0;i<_capacity;i++)
        {
            if(index != i)
            {
                Array[i]=Array[i];
            }
            if(index == i)
            {
                Array[i]=Array[i-1];
            }
            Array=Array;
        }
        _capacity++;
    }
    public void Remove(dynamic data)
    {
        dynamic[] newArray=new dynamic[_capacity];
        int j=0;
        for(int i=0;i<_capacity;i++)
        {
            if(Array[i].Equals(data))
            {
                i++;
            }
            newArray[j]=Array[i];
            _count++;
        }
    }
    }
}